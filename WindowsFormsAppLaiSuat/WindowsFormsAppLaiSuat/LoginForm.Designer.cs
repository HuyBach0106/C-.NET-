namespace WindowsFormsAppLaiSuat
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbLogin = new GroupBox();
            btnLogin = new Button();
            btnClose = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(txtPassword);
            grbLogin.Controls.Add(txtUsername);
            grbLogin.Controls.Add(lblPassword);
            grbLogin.Controls.Add(lblUsername);
            grbLogin.Location = new Point(68, 55);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(640, 235);
            grbLogin.TabIndex = 0;
            grbLogin.TabStop = false;
            grbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(68, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(614, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(55, 61);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(107, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(55, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(168, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(436, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(436, 27);
            txtPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(grbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLogin;
        private Button btnLogin;
        private Button btnClose;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}