namespace Devices_Control_Program
{
    partial class DeviceControl
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
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LabelRoomName = new System.Windows.Forms.Label();
            this.PictureRoomIcon = new System.Windows.Forms.PictureBox();
            this._LabelNumberDevices = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelNumberDevices = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelNumberOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonTurnOffAllDevices = new System.Windows.Forms.Button();
            this.ButtonTurnOnAllDevices = new System.Windows.Forms.Button();
            this.PanelDevice1 = new System.Windows.Forms.Panel();
            this.PanelDevice2 = new System.Windows.Forms.Panel();
            this.PanelDevice3 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelNumberInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRoomIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopBar
            // 
            this.PanelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTopBar.Name = "PanelTopBar";
            this.PanelTopBar.Size = new System.Drawing.Size(1404, 7);
            this.PanelTopBar.TabIndex = 0;
            this.PanelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTopBar_MouseMove);
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelInfo.Controls.Add(this.LabelRoomName);
            this.PanelInfo.Controls.Add(this.PictureRoomIcon);
            this.PanelInfo.Location = new System.Drawing.Point(35, 7);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(205, 138);
            this.PanelInfo.TabIndex = 1;
            // 
            // LabelRoomName
            // 
            this.LabelRoomName.AutoSize = true;
            this.LabelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomName.ForeColor = System.Drawing.Color.White;
            this.LabelRoomName.Location = new System.Drawing.Point(61, 97);
            this.LabelRoomName.Name = "LabelRoomName";
            this.LabelRoomName.Size = new System.Drawing.Size(95, 20);
            this.LabelRoomName.TabIndex = 2;
            this.LabelRoomName.Text = "Chưa có tên";
            this.LabelRoomName.SizeChanged += new System.EventHandler(this.LabelRoomName_SizeChanged);
            // 
            // PictureRoomIcon
            // 
            this.PictureRoomIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureRoomIcon.Location = new System.Drawing.Point(63, 6);
            this.PictureRoomIcon.Name = "PictureRoomIcon";
            this.PictureRoomIcon.Size = new System.Drawing.Size(75, 75);
            this.PictureRoomIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRoomIcon.TabIndex = 1;
            this.PictureRoomIcon.TabStop = false;
            // 
            // _LabelNumberDevices
            // 
            this._LabelNumberDevices.AutoSize = true;
            this._LabelNumberDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabelNumberDevices.ForeColor = System.Drawing.Color.White;
            this._LabelNumberDevices.Location = new System.Drawing.Point(70, 75);
            this._LabelNumberDevices.Name = "_LabelNumberDevices";
            this._LabelNumberDevices.Size = new System.Drawing.Size(55, 18);
            this._LabelNumberDevices.TabIndex = 3;
            this._LabelNumberDevices.Text = "Thiết bị";
            this._LabelNumberDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LabelNumberDevices);
            this.panel1.Controls.Add(this._LabelNumberDevices);
            this.panel1.Location = new System.Drawing.Point(271, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 100);
            this.panel1.TabIndex = 4;
            // 
            // LabelNumberDevices
            // 
            this.LabelNumberDevices.AutoSize = true;
            this.LabelNumberDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberDevices.ForeColor = System.Drawing.Color.White;
            this.LabelNumberDevices.Location = new System.Drawing.Point(68, 5);
            this.LabelNumberDevices.Name = "LabelNumberDevices";
            this.LabelNumberDevices.Size = new System.Drawing.Size(57, 63);
            this.LabelNumberDevices.TabIndex = 4;
            this.LabelNumberDevices.Text = "0";
            this.LabelNumberDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.LabelNumberOutput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(492, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 100);
            this.panel2.TabIndex = 5;
            // 
            // LabelNumberOutput
            // 
            this.LabelNumberOutput.AutoSize = true;
            this.LabelNumberOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOutput.ForeColor = System.Drawing.Color.White;
            this.LabelNumberOutput.Location = new System.Drawing.Point(66, 5);
            this.LabelNumberOutput.Name = "LabelNumberOutput";
            this.LabelNumberOutput.Size = new System.Drawing.Size(57, 63);
            this.LabelNumberOutput.TabIndex = 5;
            this.LabelNumberOutput.Text = "0";
            this.LabelNumberOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng điện";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(932, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 100);
            this.panel4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 63);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "kWh";
            // 
            // ButtonTurnOffAllDevices
            // 
            this.ButtonTurnOffAllDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.ButtonTurnOffAllDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTurnOffAllDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTurnOffAllDevices.ForeColor = System.Drawing.Color.White;
            this.ButtonTurnOffAllDevices.Location = new System.Drawing.Point(1150, 103);
            this.ButtonTurnOffAllDevices.Name = "ButtonTurnOffAllDevices";
            this.ButtonTurnOffAllDevices.Size = new System.Drawing.Size(227, 42);
            this.ButtonTurnOffAllDevices.TabIndex = 8;
            this.ButtonTurnOffAllDevices.Text = "Tắt tất cả thiết bị";
            this.ButtonTurnOffAllDevices.UseVisualStyleBackColor = false;
            this.ButtonTurnOffAllDevices.Click += new System.EventHandler(this.ButtonTurnOffAllDevices_Click);
            // 
            // ButtonTurnOnAllDevices
            // 
            this.ButtonTurnOnAllDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.ButtonTurnOnAllDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTurnOnAllDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTurnOnAllDevices.ForeColor = System.Drawing.Color.White;
            this.ButtonTurnOnAllDevices.Location = new System.Drawing.Point(1150, 45);
            this.ButtonTurnOnAllDevices.Name = "ButtonTurnOnAllDevices";
            this.ButtonTurnOnAllDevices.Size = new System.Drawing.Size(227, 42);
            this.ButtonTurnOnAllDevices.TabIndex = 9;
            this.ButtonTurnOnAllDevices.Text = "Bật tất cả thiết bị";
            this.ButtonTurnOnAllDevices.UseVisualStyleBackColor = false;
            this.ButtonTurnOnAllDevices.Click += new System.EventHandler(this.ButtonTurnOnAllDevices_Click);
            // 
            // PanelDevice1
            // 
            this.PanelDevice1.Location = new System.Drawing.Point(35, 168);
            this.PanelDevice1.Name = "PanelDevice1";
            this.PanelDevice1.Size = new System.Drawing.Size(424, 637);
            this.PanelDevice1.TabIndex = 12;
            // 
            // PanelDevice2
            // 
            this.PanelDevice2.Location = new System.Drawing.Point(493, 168);
            this.PanelDevice2.Name = "PanelDevice2";
            this.PanelDevice2.Size = new System.Drawing.Size(424, 637);
            this.PanelDevice2.TabIndex = 13;
            // 
            // PanelDevice3
            // 
            this.PanelDevice3.Location = new System.Drawing.Point(952, 168);
            this.PanelDevice3.Name = "PanelDevice3";
            this.PanelDevice3.Size = new System.Drawing.Size(424, 637);
            this.PanelDevice3.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.LabelNumberInput);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(712, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 100);
            this.panel3.TabIndex = 6;
            // 
            // LabelNumberInput
            // 
            this.LabelNumberInput.AutoSize = true;
            this.LabelNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberInput.ForeColor = System.Drawing.Color.White;
            this.LabelNumberInput.Location = new System.Drawing.Point(69, 5);
            this.LabelNumberInput.Name = "LabelNumberInput";
            this.LabelNumberInput.Size = new System.Drawing.Size(57, 63);
            this.LabelNumberInput.TabIndex = 5;
            this.LabelNumberInput.Text = "0";
            this.LabelNumberInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cảm biến";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Devices_Control_Program.Properties.Resources.add_circular_outlined_button;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1163, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "   Thêm thiết bị";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::Devices_Control_Program.Properties.Resources.delete_button;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(1296, 7);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(80, 34);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "   Đóng";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // DeviceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 893);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonTurnOffAllDevices);
            this.Controls.Add(this.PanelDevice3);
            this.Controls.Add(this.PanelDevice2);
            this.Controls.Add(this.PanelDevice1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonTurnOnAllDevices);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.PanelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceControl_FormClosed);
            this.Load += new System.EventHandler(this.DeviceControl_Load);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRoomIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopBar;
        private System.Windows.Forms.Panel PanelInfo;
        protected internal System.Windows.Forms.Label LabelRoomName;
        protected internal System.Windows.Forms.PictureBox PictureRoomIcon;
        protected internal System.Windows.Forms.Label _LabelNumberDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        protected internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonTurnOffAllDevices;
        private System.Windows.Forms.Button ButtonTurnOnAllDevices;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelDevice1;
        private System.Windows.Forms.Panel PanelDevice2;
        private System.Windows.Forms.Panel PanelDevice3;
        protected internal System.Windows.Forms.Label LabelNumberDevices;
        protected internal System.Windows.Forms.Label LabelNumberOutput;
        protected internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Label LabelNumberInput;
        protected internal System.Windows.Forms.Label label2;
    }
}