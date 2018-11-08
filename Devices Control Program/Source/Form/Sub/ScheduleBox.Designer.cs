namespace Devices_Control_Program
{
    partial class ScheduleBox
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
            this.components = new System.ComponentModel.Container();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelListDevices = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelListChedules = new System.Windows.Forms.Panel();
            this.PanelDevice = new System.Windows.Forms.Panel();
            this.ButtonAddNew = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelUnderlineName = new System.Windows.Forms.Panel();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(189, 74);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(257, 29);
            this.DateTimePicker.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chọn thiết bị";
            // 
            // PanelListDevices
            // 
            this.PanelListDevices.Location = new System.Drawing.Point(50, 149);
            this.PanelListDevices.Name = "PanelListDevices";
            this.PanelListDevices.Size = new System.Drawing.Size(396, 276);
            this.PanelListDevices.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(45, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Danh sách thiết bị hẹn giờ";
            // 
            // PanelListChedules
            // 
            this.PanelListChedules.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelListChedules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelListChedules.Location = new System.Drawing.Point(50, 485);
            this.PanelListChedules.Name = "PanelListChedules";
            this.PanelListChedules.Size = new System.Drawing.Size(999, 343);
            this.PanelListChedules.TabIndex = 16;
            // 
            // PanelDevice
            // 
            this.PanelDevice.Location = new System.Drawing.Point(488, 137);
            this.PanelDevice.Name = "PanelDevice";
            this.PanelDevice.Size = new System.Drawing.Size(561, 323);
            this.PanelDevice.TabIndex = 16;
            // 
            // ButtonAddNew
            // 
            this.ButtonAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.ButtonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNew.ForeColor = System.Drawing.Color.White;
            this.ButtonAddNew.Location = new System.Drawing.Point(908, 61);
            this.ButtonAddNew.Name = "ButtonAddNew";
            this.ButtonAddNew.Size = new System.Drawing.Size(141, 42);
            this.ButtonAddNew.TabIndex = 10;
            this.ButtonAddNew.Text = "Thêm mới";
            this.ButtonAddNew.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelName.Location = new System.Drawing.Point(483, 76);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(53, 25);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Tên:";
            // 
            // PanelUnderlineName
            // 
            this.PanelUnderlineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.PanelUnderlineName.Location = new System.Drawing.Point(542, 103);
            this.PanelUnderlineName.Name = "PanelUnderlineName";
            this.PanelUnderlineName.Size = new System.Drawing.Size(354, 1);
            this.PanelUnderlineName.TabIndex = 19;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(544, 73);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(353, 23);
            this.TextBoxName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(45, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giờ hiện tại:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelTime.Location = new System.Drawing.Point(184, 33);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(42, 25);
            this.LabelTime.TabIndex = 21;
            this.LabelTime.Text = "Giờ";
            // 
            // LabelDay
            // 
            this.LabelDay.AutoSize = true;
            this.LabelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelDay.Location = new System.Drawing.Point(279, 33);
            this.LabelDay.Name = "LabelDay";
            this.LabelDay.Size = new System.Drawing.Size(112, 25);
            this.LabelDay.TabIndex = 22;
            this.LabelDay.Text = "Ngày tháng";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScheduleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelDay);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelUnderlineName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonAddNew);
            this.Controls.Add(this.PanelDevice);
            this.Controls.Add(this.PanelListChedules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelListDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "ScheduleBox";
            this.Size = new System.Drawing.Size(1104, 849);
            this.Load += new System.EventHandler(this.ScheduleBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Panel PanelListChedules;
        protected internal System.Windows.Forms.Panel PanelListDevices;
        protected internal System.Windows.Forms.Panel PanelDevice;
        protected internal System.Windows.Forms.Button ButtonAddNew;
        protected internal System.Windows.Forms.TextBox TextBoxName;
        protected internal System.Windows.Forms.Label LabelName;
        protected internal System.Windows.Forms.Panel PanelUnderlineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDay;
        private System.Windows.Forms.Timer timer1;
        protected internal System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}
