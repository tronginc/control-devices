namespace Devices_Control_Program
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.PictureIconUser = new System.Windows.Forms.PictureBox();
            this.PictureIconExit = new System.Windows.Forms.PictureBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelNoAccount = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelUnderlinePassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelUnderlineUsername = new System.Windows.Forms.Panel();
            this.LoadingPicture = new System.Windows.Forms.PictureBox();
            this.PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).BeginInit();
            this.PanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(368, 288);
            this.PanelLeft.TabIndex = 0;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelLogin.Location = new System.Drawing.Point(45, 9);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(189, 25);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Đăng nhập hệ thống";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelUsername.Location = new System.Drawing.Point(15, 23);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(99, 25);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Tài khoản";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(23, 51);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(353, 23);
            this.TextBoxUsername.TabIndex = 3;
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelControl.Controls.Add(this.LoadingPicture);
            this.PanelControl.Controls.Add(this.PictureIconUser);
            this.PanelControl.Controls.Add(this.PictureIconExit);
            this.PanelControl.Controls.Add(this.LabelLogin);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.Location = new System.Drawing.Point(368, 0);
            this.PanelControl.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(395, 44);
            this.PanelControl.TabIndex = 4;
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            // 
            // PictureIconUser
            // 
            this.PictureIconUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureIconUser.Image")));
            this.PictureIconUser.Location = new System.Drawing.Point(19, 11);
            this.PictureIconUser.Name = "PictureIconUser";
            this.PictureIconUser.Size = new System.Drawing.Size(20, 20);
            this.PictureIconUser.TabIndex = 2;
            this.PictureIconUser.TabStop = false;
            // 
            // PictureIconExit
            // 
            this.PictureIconExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureIconExit.Image")));
            this.PictureIconExit.Location = new System.Drawing.Point(355, 9);
            this.PictureIconExit.Name = "PictureIconExit";
            this.PictureIconExit.Size = new System.Drawing.Size(23, 22);
            this.PictureIconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIconExit.TabIndex = 0;
            this.PictureIconExit.TabStop = false;
            this.PictureIconExit.Click += new System.EventHandler(this.PictureIconExit_Click);
            // 
            // PanelRight
            // 
            this.PanelRight.Controls.Add(this.label3);
            this.PanelRight.Controls.Add(this.label2);
            this.PanelRight.Controls.Add(this.LabelNoAccount);
            this.PanelRight.Controls.Add(this.ButtonLogin);
            this.PanelRight.Controls.Add(this.PanelUnderlinePassword);
            this.PanelRight.Controls.Add(this.TextBoxPassword);
            this.PanelRight.Controls.Add(this.label1);
            this.PanelRight.Controls.Add(this.PanelUnderlineUsername);
            this.PanelRight.Controls.Add(this.TextBoxUsername);
            this.PanelRight.Controls.Add(this.LabelUsername);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelRight.Location = new System.Drawing.Point(368, 45);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(395, 243);
            this.PanelRight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(249, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quên mật khẩu?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(195, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đăng ký tài khoản mới";
            // 
            // LabelNoAccount
            // 
            this.LabelNoAccount.AutoSize = true;
            this.LabelNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoAccount.Location = new System.Drawing.Point(25, 213);
            this.LabelNoAccount.Name = "LabelNoAccount";
            this.LabelNoAccount.Size = new System.Drawing.Size(176, 20);
            this.LabelNoAccount.TabIndex = 9;
            this.LabelNoAccount.Text = "Bạn chưa có tài khoản?";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(19, 169);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(356, 41);
            this.ButtonLogin.TabIndex = 8;
            this.ButtonLogin.Text = "Đăng nhập";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PanelUnderlinePassword
            // 
            this.PanelUnderlinePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelUnderlinePassword.Location = new System.Drawing.Point(21, 141);
            this.PanelUnderlinePassword.Name = "PanelUnderlinePassword";
            this.PanelUnderlinePassword.Size = new System.Drawing.Size(354, 1);
            this.PanelUnderlinePassword.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(23, 115);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.Size = new System.Drawing.Size(353, 23);
            this.TextBoxPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mật khẩu";
            // 
            // PanelUnderlineUsername
            // 
            this.PanelUnderlineUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelUnderlineUsername.Location = new System.Drawing.Point(21, 77);
            this.PanelUnderlineUsername.Name = "PanelUnderlineUsername";
            this.PanelUnderlineUsername.Size = new System.Drawing.Size(354, 1);
            this.PanelUnderlineUsername.TabIndex = 4;
            // 
            // LoadingPicture
            // 
            this.LoadingPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoadingPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPicture.Image")));
            this.LoadingPicture.Location = new System.Drawing.Point(240, 0);
            this.LoadingPicture.Name = "LoadingPicture";
            this.LoadingPicture.Size = new System.Drawing.Size(44, 44);
            this.LoadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPicture.TabIndex = 3;
            this.LoadingPicture.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 288);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).EndInit();
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelUnderlineUsername;
        private System.Windows.Forms.Panel PanelUnderlinePassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelNoAccount;
        private System.Windows.Forms.PictureBox PictureIconExit;
        private System.Windows.Forms.PictureBox PictureIconUser;
        private System.Windows.Forms.PictureBox LoadingPicture;
    }
}

