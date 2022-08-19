using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LibraryManagementApp
{
	public partial class Login : Form
	{
		// Code for Shadow Effect
		private bool Drag;
		private int MouseX;
		private int MouseY;

		private const int WM_NCHITTEST = 0x84;
		private const int HTCLIENT = 0x1;
		private const int HTCAPTION = 0x2;

		private bool m_aeroEnabled;

		private const int CS_DROPSHADOW = 0x00020000;
		private const int WM_NCPAINT = 0x0085;
		private const int WM_ACTIVATEAPP = 0x001C;

		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]

		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
		[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect,
			int nTopRect,
			int nRightRect,
			int nBottomRect,
			int nWidthEllipse,
			int nHeightEllipse
			);

		public struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}
		protected override CreateParams CreateParams
		{
			get
			{
				m_aeroEnabled = CheckAeroEnabled();
				CreateParams cp = base.CreateParams;
				if (!m_aeroEnabled)
					cp.ClassStyle |= CS_DROPSHADOW; return cp;
			}
		}
		private bool CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int enabled = 0; DwmIsCompositionEnabled(ref enabled);
				return (enabled == 1) ? true : false;
			}
			return false;
		}
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case WM_NCPAINT:
					if (m_aeroEnabled)
					{
						var v = 2;
						DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
						MARGINS margins = new MARGINS()
						{
							bottomHeight = 1,
							leftWidth = 0,
							rightWidth = 0,
							topHeight = 0
						}; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
					}
					break;
				default: break;
			}
			base.WndProc(ref m);
			if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
		}
		private void PanelMove_MouseDown(object sender, MouseEventArgs e)
		{
			Drag = true;
			MouseX = Cursor.Position.X - this.Left;
			MouseY = Cursor.Position.Y - this.Top;
		}
		private void PanelMove_MouseMove(object sender, MouseEventArgs e)
		{
			if (Drag)
			{
				this.Top = Cursor.Position.Y - MouseY;
				this.Left = Cursor.Position.X - MouseX;
			}
		}
		private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
		public Login()
		{
			InitializeComponent();
		}

		// Shadow Efect End
		/// 
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
			linkLabel_dateTime.Text = DateTime.Now.ToLocalTime().ToString("dddd, dd MMM yyyy, hh:mm:ss tt");

			textBox_username.AutoSize = false;
			textBox_password.AutoSize = false;
			textBox_username.Height = 35;
			textBox_password.Height = 35;
			textBox_password.UseSystemPasswordChar = true;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			linkLabel_dateTime.Text = DateTime.Now.ToLocalTime().ToString("dddd, dd MMM yyyy, hh:mm:ss tt");

		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();



		private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		bool chk = false;
		private void button_eye_Click(object sender, EventArgs e)
		{
			if (chk != true)
			{
				//textBox_password.PasswordChar = '\0';
				textBox_password.UseSystemPasswordChar = false;
				button_eye.Text = "Hide";
				toolTip.SetToolTip(button_eye, "Hide Password");
				chk = true;
			}
			else
			{
				chk = false;
				button_eye.Text = "Show";
				toolTip.SetToolTip(button_eye, "Show Password");
				textBox_password.UseSystemPasswordChar = true;

			}

		}

		private void label_createAccount_MouseHover(object sender, EventArgs e)
		{
			//label_createAccount.Font = new Font(label_createAccount.Font, FontStyle.Bold);
			label_createAccount.LinkColor = Color.DodgerBlue;
			toolTip.SetToolTip(label_createAccount, "Create a Library Account Here");
		}

		private void label_createAccount_MouseLeave(object sender, EventArgs e)
		{
			//label_createAccount.Font = new Font(label_createAccount.Font, FontStyle.Regular);
			label_createAccount.LinkColor = Color.LightSlateGray;
		}

		private void button_login_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "data source = localhost\\SQLEXPRESS; database=library; integrated security=True";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;

			cmd.CommandText = "SELECT * FROM library.dbo.loginTable WHERE username = '" + textBox_username.Text.Trim() + "' AND pass = '" + textBox_password.Text.Trim() + "' ";
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);

			if (ds.Tables[0].Rows.Count != 0)
			{
				MessageBox.Show("Login Successfull", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (textBox_username.Text == "" || textBox_password.Text.Trim() == "")
			{
				MessageBox.Show("Username or Password cannot be empty", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password", "Login Failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}

		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			Application.Exit();
		}
		private void button_minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button_minimize_MouseDown(object sender, MouseEventArgs e)
		{
			button_minimize.ForeColor = Color.White;
		}

		private void button_minimize_MouseLeave(object sender, EventArgs e)
		{
			button_minimize.ForeColor = Color.Gray;
		}

		private void button_exit_MouseDown(object sender, MouseEventArgs e)
		{
			button_exit.ForeColor = Color.White;

		}

		private void button_exit_MouseLeave(object sender, EventArgs e)
		{
			button_exit.ForeColor = Color.Gray;
		}


		private void linkLabel_dateTime_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Navigate to a URL.
			Process.Start(new ProcessStartInfo { FileName = @"https://www.about.me/thisisazharul/", UseShellExecute = true });
		}
	}
}