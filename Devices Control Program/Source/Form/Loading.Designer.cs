namespace Devices_Control_Program
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.LoadingPicture = new System.Windows.Forms.PictureBox();
            this.LabelLoading = new System.Windows.Forms.Label();
            this.PictureIconExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingPicture
            // 
            this.LoadingPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPicture.Image")));
            this.LoadingPicture.Location = new System.Drawing.Point(25, 0);
            this.LoadingPicture.Name = "LoadingPicture";
            this.LoadingPicture.Size = new System.Drawing.Size(50, 50);
            this.LoadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPicture.TabIndex = 0;
            this.LoadingPicture.TabStop = false;
            // 
            // LabelLoading
            // 
            this.LabelLoading.AutoSize = true;
            this.LabelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.LabelLoading.Location = new System.Drawing.Point(81, 14);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Size = new System.Drawing.Size(161, 25);
            this.LabelLoading.TabIndex = 1;
            this.LabelLoading.Text = "Đang tải dữ liệu...";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureIconExit
            // 
            this.PictureIconExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureIconExit.Image")));
            this.PictureIconExit.Location = new System.Drawing.Point(271, 16);
            this.PictureIconExit.Name = "PictureIconExit";
            this.PictureIconExit.Size = new System.Drawing.Size(23, 22);
            this.PictureIconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIconExit.TabIndex = 2;
            this.PictureIconExit.TabStop = false;
            this.PictureIconExit.Click += new System.EventHandler(this.PictureIconExit_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 50);
            this.Controls.Add(this.PictureIconExit);
            this.Controls.Add(this.LabelLoading);
            this.Controls.Add(this.LoadingPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadingPicture;
        private System.Windows.Forms.Label LabelLoading;
        private System.Windows.Forms.PictureBox PictureIconExit;
    }
}