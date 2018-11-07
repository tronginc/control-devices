using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devices_Control_Program
{
    public partial class ScheduleBox : UserControl
    {
        public ScheduleBox()
        {
            InitializeComponent();
        }

        private void ScheduleBox_Load(object sender, EventArgs e)
        {
            DateTimePicker.CustomFormat = "  hh : mm    dd / MM / yyyy  ";
        }
    }
}
