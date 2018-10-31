namespace Devices_Control_Program
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelControl = new System.Windows.Forms.Panel();
            this.LoadingPicture = new System.Windows.Forms.PictureBox();
            this.PictureIconUser = new System.Windows.Forms.PictureBox();
            this.PictureIconExit = new System.Windows.Forms.PictureBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.PanelMenuLeft = new System.Windows.Forms.Panel();
            this.PanelLeftButton = new System.Windows.Forms.Panel();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.ButtonTimer = new System.Windows.Forms.Button();
            this.ButtonAddRoom = new System.Windows.Forms.Button();
            this.ButtonListRoom = new System.Windows.Forms.Button();
            this.addRoom = new Devices_Control_Program.AddRoom();
            this.listRoom = new Devices_Control_Program.ListRoom();
            this.PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).BeginInit();
            this.PanelMenuLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelControl.Controls.Add(this.LoadingPicture);
            this.PanelControl.Controls.Add(this.PictureIconUser);
            this.PanelControl.Controls.Add(this.PictureIconExit);
            this.PanelControl.Controls.Add(this.LabelLogin);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(1404, 44);
            this.PanelControl.TabIndex = 5;
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            // 
            // LoadingPicture
            // 
            this.LoadingPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoadingPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPicture.Image")));
            this.LoadingPicture.Location = new System.Drawing.Point(161, 0);
            this.LoadingPicture.Name = "LoadingPicture";
            this.LoadingPicture.Size = new System.Drawing.Size(44, 44);
            this.LoadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPicture.TabIndex = 3;
            this.LoadingPicture.TabStop = false;
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
            this.PictureIconExit.Location = new System.Drawing.Point(1369, 9);
            this.PictureIconExit.Name = "PictureIconExit";
            this.PictureIconExit.Size = new System.Drawing.Size(23, 22);
            this.PictureIconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIconExit.TabIndex = 0;
            this.PictureIconExit.TabStop = false;
            this.PictureIconExit.Click += new System.EventHandler(this.PictureIconExit_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelLogin.Location = new System.Drawing.Point(45, 9);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(101, 25);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Trang chủ";
            // 
            // PanelMenuLeft
            // 
            this.PanelMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelMenuLeft.Controls.Add(this.PanelLeftButton);
            this.PanelMenuLeft.Controls.Add(this.ButtonSetting);
            this.PanelMenuLeft.Controls.Add(this.ButtonTimer);
            this.PanelMenuLeft.Controls.Add(this.ButtonAddRoom);
            this.PanelMenuLeft.Controls.Add(this.ButtonListRoom);
            this.PanelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLeft.Location = new System.Drawing.Point(0, 44);
            this.PanelMenuLeft.Name = "PanelMenuLeft";
            this.PanelMenuLeft.Size = new System.Drawing.Size(300, 849);
            this.PanelMenuLeft.TabIndex = 7;
            // 
            // PanelLeftButton
            // 
            this.PanelLeftButton.BackColor = System.Drawing.Color.White;
            this.PanelLeftButton.Location = new System.Drawing.Point(10, 52);
            this.PanelLeftButton.Name = "PanelLeftButton";
            this.PanelLeftButton.Size = new System.Drawing.Size(7, 73);
            this.PanelLeftButton.TabIndex = 4;
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.FlatAppearance.BorderSize = 0;
            this.ButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetting.ForeColor = System.Drawing.Color.White;
            this.ButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetting.Image")));
            this.ButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSetting.Location = new System.Drawing.Point(0, 311);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.ButtonSetting.Size = new System.Drawing.Size(294, 73);
            this.ButtonSetting.TabIndex = 3;
            this.ButtonSetting.Text = "Cài đặt              ";
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // ButtonTimer
            // 
            this.ButtonTimer.FlatAppearance.BorderSize = 0;
            this.ButtonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTimer.ForeColor = System.Drawing.Color.White;
            this.ButtonTimer.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTimer.Image")));
            this.ButtonTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimer.Location = new System.Drawing.Point(1, 221);
            this.ButtonTimer.Name = "ButtonTimer";
            this.ButtonTimer.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.ButtonTimer.Size = new System.Drawing.Size(294, 73);
            this.ButtonTimer.TabIndex = 2;
            this.ButtonTimer.Text = "Hẹn giờ              ";
            this.ButtonTimer.UseVisualStyleBackColor = true;
            this.ButtonTimer.Click += new System.EventHandler(this.ButtonTimer_Click);
            // 
            // ButtonAddRoom
            // 
            this.ButtonAddRoom.FlatAppearance.BorderSize = 0;
            this.ButtonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddRoom.ForeColor = System.Drawing.Color.White;
            this.ButtonAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddRoom.Image")));
            this.ButtonAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddRoom.Location = new System.Drawing.Point(1, 142);
            this.ButtonAddRoom.Name = "ButtonAddRoom";
            this.ButtonAddRoom.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.ButtonAddRoom.Size = new System.Drawing.Size(294, 73);
            this.ButtonAddRoom.TabIndex = 1;
            this.ButtonAddRoom.Text = "Thêm phòng       ";
            this.ButtonAddRoom.UseVisualStyleBackColor = true;
            this.ButtonAddRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // ButtonListRoom
            // 
            this.ButtonListRoom.FlatAppearance.BorderSize = 0;
            this.ButtonListRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonListRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonListRoom.ForeColor = System.Drawing.Color.White;
            this.ButtonListRoom.Image = ((System.Drawing.Image)(resources.GetObject("ButtonListRoom.Image")));
            this.ButtonListRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonListRoom.Location = new System.Drawing.Point(2, 52);
            this.ButtonListRoom.Name = "ButtonListRoom";
            this.ButtonListRoom.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.ButtonListRoom.Size = new System.Drawing.Size(294, 73);
            this.ButtonListRoom.TabIndex = 0;
            this.ButtonListRoom.Text = "Danh sách phòng";
            this.ButtonListRoom.UseVisualStyleBackColor = true;
            this.ButtonListRoom.Click += new System.EventHandler(this.ButtonListRoom_Click);
            // 
            // addRoom
            // 
            this.addRoom.Location = new System.Drawing.Point(297, 44);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(1104, 849);
            this.addRoom.TabIndex = 9;
            // 
            // listRoom
            // 
            this.listRoom.Location = new System.Drawing.Point(297, 44);
            this.listRoom.Name = "listRoom";
            this.listRoom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.listRoom.Size = new System.Drawing.Size(1104, 849);
            this.listRoom.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 893);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.PanelMenuLeft);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.addRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).EndInit();
            this.PanelMenuLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.PictureBox LoadingPicture;
        private System.Windows.Forms.PictureBox PictureIconUser;
        private System.Windows.Forms.PictureBox PictureIconExit;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Panel PanelMenuLeft;
        private System.Windows.Forms.Button ButtonListRoom;
        private System.Windows.Forms.Button ButtonSetting;
        private System.Windows.Forms.Button ButtonTimer;
        private System.Windows.Forms.Button ButtonAddRoom;
        private System.Windows.Forms.Panel PanelLeftButton;
        private ListRoom listRoom;
        private AddRoom addRoom;
    }
}