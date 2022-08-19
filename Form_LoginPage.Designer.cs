namespace LibraryManagementApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_heading = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label_createAccount = new System.Windows.Forms.LinkLabel();
            this.button_eye = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_minimize = new System.Windows.Forms.Button();
            this.linkLabel_dateTime = new System.Windows.Forms.LinkLabel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_title.Location = new System.Drawing.Point(133, 39);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(616, 65);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Library Management System";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.BackColor = System.Drawing.Color.Transparent;
            this.label_heading.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_heading.Location = new System.Drawing.Point(72, 35);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(182, 21);
            this.label_heading.TabIndex = 0;
            this.label_heading.Text = "Please Login to Continue";
            this.label_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_username.Location = new System.Drawing.Point(24, 83);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(71, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_username.Location = new System.Drawing.Point(27, 105);
            this.textBox_username.MaxLength = 50;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.PlaceholderText = " Enter your username";
            this.textBox_username.Size = new System.Drawing.Size(264, 29);
            this.textBox_username.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBox_username, "Insert Username");
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.Location = new System.Drawing.Point(27, 188);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PlaceholderText = " Enter your password";
            this.textBox_password.Size = new System.Drawing.Size(264, 29);
            this.textBox_password.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBox_password, "Insert Password");
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_password.Location = new System.Drawing.Point(24, 166);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 19);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_login.Location = new System.Drawing.Point(112, 248);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(90, 37);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_createAccount
            // 
            this.label_createAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.label_createAccount.AutoSize = true;
            this.label_createAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_createAccount.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_createAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.label_createAccount.LinkColor = System.Drawing.Color.DimGray;
            this.label_createAccount.Location = new System.Drawing.Point(97, 311);
            this.label_createAccount.Name = "label_createAccount";
            this.label_createAccount.Size = new System.Drawing.Size(122, 19);
            this.label_createAccount.TabIndex = 5;
            this.label_createAccount.TabStop = true;
            this.label_createAccount.Text = "Create an Account";
            this.label_createAccount.MouseLeave += new System.EventHandler(this.label_createAccount_MouseLeave);
            this.label_createAccount.MouseHover += new System.EventHandler(this.label_createAccount_MouseHover);
            // 
            // button_eye
            // 
            this.button_eye.BackColor = System.Drawing.Color.Transparent;
            this.button_eye.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_eye.FlatAppearance.BorderSize = 0;
            this.button_eye.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_eye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eye.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_eye.Location = new System.Drawing.Point(244, 190);
            this.button_eye.Name = "button_eye";
            this.button_eye.Size = new System.Drawing.Size(45, 28);
            this.button_eye.TabIndex = 3;
            this.button_eye.Text = "Show";
            this.toolTip.SetToolTip(this.button_eye, "Show Password");
            this.button_eye.UseVisualStyleBackColor = false;
            this.button_eye.Click += new System.EventHandler(this.button_eye_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_minimize.ForeColor = System.Drawing.Color.DarkGray;
            this.button_minimize.Location = new System.Drawing.Point(792, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(45, 25);
            this.button_minimize.TabIndex = 6;
            this.button_minimize.Text = "—";
            this.toolTip.SetToolTip(this.button_minimize, "Minimize");
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            this.button_minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_minimize_MouseDown);
            this.button_minimize.MouseLeave += new System.EventHandler(this.button_minimize_MouseLeave);
            this.button_minimize.MouseHover += new System.EventHandler(this.button_minimize_MouseLeave);
            // 
            // linkLabel_dateTime
            // 
            this.linkLabel_dateTime.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_dateTime.AutoSize = true;
            this.linkLabel_dateTime.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabel_dateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_dateTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_dateTime.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_dateTime.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_dateTime.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.linkLabel_dateTime.Location = new System.Drawing.Point(294, 518);
            this.linkLabel_dateTime.Name = "linkLabel_dateTime";
            this.linkLabel_dateTime.Size = new System.Drawing.Size(254, 21);
            this.linkLabel_dateTime.TabIndex = 0;
            this.linkLabel_dateTime.TabStop = true;
            this.linkLabel_dateTime.Text = "Date and Time will be shown here";
            this.toolTip.SetToolTip(this.linkLabel_dateTime, "Click to know about me!");
            this.linkLabel_dateTime.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dateTime_LinkClicked);
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_login.BackgroundImage")));
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_login.Controls.Add(this.button_eye);
            this.panel_login.Controls.Add(this.label_createAccount);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.label_password);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.label_username);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.label_heading);
            this.panel_login.Location = new System.Drawing.Point(521, 138);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(317, 365);
            this.panel_login.TabIndex = 0;
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_exit.Location = new System.Drawing.Point(838, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(45, 25);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "✕";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_exit_MouseDown);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.linkLabel_dateTime);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Library Management App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_title;
        private PictureBox pictureBox1;
        private Label label_heading;
        private Label label_username;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label_password;
        private Button button_login;
        private LinkLabel label_createAccount;
        private Button button_eye;
        private ToolTip toolTip;
        private Panel panel_login;
        private Button button_minimize;
        private Button button_exit;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel linkLabel_dateTime;
    }
}