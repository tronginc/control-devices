using Devices_Control_Program.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devices_Control_Program
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void PictureIconExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn tắt phần mềm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Application.OpenForms[i].Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }



        private void Loading_Shown(object sender, EventArgs e)
        {
            
       

        }
    }
}
