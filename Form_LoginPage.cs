
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementApp
{
  
   

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_username.AutoSize = false;
            textBox_password.AutoSize = false;
            textBox_username.Height = 32;
            textBox_password.Height = 32;
            textBox_password.UseSystemPasswordChar = true;
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

            cmd.CommandText = "SELECT * FROM library.dbo.loginTable WHERE username = '" + textBox_username.Text + "' AND pass = '" +textBox_password.Text+ "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Login Successfull","Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","Login Failed!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }

        }

        private void button_login_MouseHover(object sender, EventArgs e)
        {
            button_login.BackColor = Color.RoyalBlue;
        }

        private void button_login_MouseLeave(object sender, EventArgs e)
        {
            button_login.BackColor = Color.DodgerBlue;
        }

        private void label_allrightreserved_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://about.me/thisisazharul/");
        }
    }
}