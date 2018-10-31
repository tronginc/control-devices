namespace Devices_Control_Program
{
    partial class AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelUnderlineUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TreeViewListIcon = new System.Windows.Forms.TreeView();
            this.ButtonAddRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureRoomIcon = new System.Windows.Forms.PictureBox();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.PanelFileName = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRoomIcon)).BeginInit();
            this.PanelFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUnderlineUsername
            // 
            this.PanelUnderlineUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelUnderlineUsername.Location = new System.Drawing.Point(492, 578);
            this.PanelUnderlineUsername.Name = "PanelUnderlineUsername";
            this.PanelUnderlineUsername.Size = new System.Drawing.Size(354, 1);
            this.PanelUnderlineUsername.TabIndex = 7;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(494, 548);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(353, 23);
            this.TextBoxUsername.TabIndex = 6;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelUsername.Location = new System.Drawing.Point(487, 520);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelUsername.TabIndex = 5;
            this.LabelUsername.Text = "Tên phòng";
            // 
            // TreeViewListIcon
            // 
            this.TreeViewListIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeViewListIcon.Location = new System.Drawing.Point(56, 73);
            this.TreeViewListIcon.Name = "TreeViewListIcon";
            this.TreeViewListIcon.Size = new System.Drawing.Size(395, 565);
            this.TreeViewListIcon.TabIndex = 8;
            this.TreeViewListIcon.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewListIcon_AfterSelect);
            // 
            // ButtonAddRoom
            // 
            this.ButtonAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.ButtonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddRoom.ForeColor = System.Drawing.Color.White;
            this.ButtonAddRoom.Location = new System.Drawing.Point(490, 597);
            this.ButtonAddRoom.Name = "ButtonAddRoom";
            this.ButtonAddRoom.Size = new System.Drawing.Size(356, 41);
            this.ButtonAddRoom.TabIndex = 9;
            this.ButtonAddRoom.Text = "Thêm phòng";
            this.ButtonAddRoom.UseVisualStyleBackColor = false;
            this.ButtonAddRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn icon";
            // 
            // PictureRoomIcon
            // 
            this.PictureRoomIcon.Location = new System.Drawing.Point(537, 73);
            this.PictureRoomIcon.Name = "PictureRoomIcon";
            this.PictureRoomIcon.Size = new System.Drawing.Size(262, 262);
            this.PictureRoomIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRoomIcon.TabIndex = 11;
            this.PictureRoomIcon.TabStop = false;
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelFileName.Location = new System.Drawing.Point(159, 14);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 25);
            this.LabelFileName.TabIndex = 12;
            this.LabelFileName.SizeChanged += new System.EventHandler(this.LabelFileName_SizeChanged);
            // 
            // PanelFileName
            // 
            this.PanelFileName.Controls.Add(this.LabelFileName);
            this.PanelFileName.Location = new System.Drawing.Point(492, 341);
            this.PanelFileName.Name = "PanelFileName";
            this.PanelFileName.Size = new System.Drawing.Size(352, 53);
            this.PanelFileName.TabIndex = 13;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureRoomIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAddRoom);
            this.Controls.Add(this.TreeViewListIcon);
            this.Controls.Add(this.PanelUnderlineUsername);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.PanelFileName);
            this.Name = "AddRoom";
            this.Size = new System.Drawing.Size(1104, 849);
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureRoomIcon)).EndInit();
            this.PanelFileName.ResumeLayout(false);
            this.PanelFileName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUnderlineUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TreeView TreeViewListIcon;
        private System.Windows.Forms.Button ButtonAddRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureRoomIcon;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Panel PanelFileName;
    }
}
