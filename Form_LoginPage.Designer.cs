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
            this.label_allrightreserved = new System.Windows.Forms.Label();
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
            this.panel_login = new System.Windows.Forms.Panel();
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
            this.label_title.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_title.Location = new System.Drawing.Point(105, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(407, 45);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Library Management System";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // label_allrightreserved
            // 
            this.label_allrightreserved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_allrightreserved.AutoSize = true;
            this.label_allrightreserved.Cursor = System.Windows.Forms.Cursors.Help;
            this.label_allrightreserved.ForeColor = System.Drawing.Color.Silver;
            this.label_allrightreserved.Location = new System.Drawing.Point(234, 346);
            this.label_allrightreserved.Name = "label_allrightreserved";
            this.label_allrightreserved.Size = new System.Drawing.Size(145, 16);
            this.label_allrightreserved.TabIndex = 0;
            this.label_allrightreserved.Text = "All Rights Reserved ©2022";
            this.label_allrightreserved.Click += new System.EventHandler(this.label_allrightreserved_Click);
            this.label_allrightreserved.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_heading.Location = new System.Drawing.Point(60, 17);
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
            this.label_username.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_username.Location = new System.Drawing.Point(14, 54);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(71, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_username.Location = new System.Drawing.Point(14, 76);
            this.textBox_username.MaxLength = 50;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.PlaceholderText = " Enter your username";
            this.textBox_username.Size = new System.Drawing.Size(264, 29);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.Location = new System.Drawing.Point(14, 145);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PlaceholderText = " Enter your password";
            this.textBox_password.Size = new System.Drawing.Size(264, 29);
            this.textBox_password.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_password.Location = new System.Drawing.Point(14, 123);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 19);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(14, 207);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(90, 37);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            this.button_login.MouseLeave += new System.EventHandler(this.button_login_MouseLeave);
            this.button_login.MouseHover += new System.EventHandler(this.button_login_MouseHover);
            // 
            // label_createAccount
            // 
            this.label_createAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.label_createAccount.AutoSize = true;
            this.label_createAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_createAccount.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_createAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.label_createAccount.LinkColor = System.Drawing.Color.DimGray;
            this.label_createAccount.Location = new System.Drawing.Point(174, 218);
            this.label_createAccount.Name = "label_createAccount";
            this.label_createAccount.Size = new System.Drawing.Size(104, 16);
            this.label_createAccount.TabIndex = 0;
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
            this.button_eye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button_eye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eye.Location = new System.Drawing.Point(231, 145);
            this.button_eye.Name = "button_eye";
            this.button_eye.Size = new System.Drawing.Size(45, 28);
            this.button_eye.TabIndex = 0;
            this.button_eye.Text = "Show";
            this.toolTip.SetToolTip(this.button_eye, "Show Password");
            this.button_eye.UseVisualStyleBackColor = false;
            this.button_eye.Click += new System.EventHandler(this.button_eye_Click);
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.button_eye);
            this.panel_login.Controls.Add(this.label_createAccount);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.label_password);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.label_username);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.label_heading);
            this.panel_login.Location = new System.Drawing.Point(310, 81);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(290, 262);
            this.panel_login.TabIndex = 5;
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 371);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.label_allrightreserved);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private Label label_allrightreserved;
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
    }
}