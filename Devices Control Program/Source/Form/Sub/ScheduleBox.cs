using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Devices_Control_Program.Source.Util.Data;
using Devices_Control_Program.Source.Util;

namespace Devices_Control_Program
{
    public partial class ScheduleBox : UserControl
    {
        public ScheduleBox()
        {
            InitializeComponent();
        }
        private Font drawFont = new Font("Times New Roman", 18);
        private void ScheduleBox_Load(object sender, EventArgs e)
        {
            DateTimePicker.CustomFormat = "  hh : mm    dd / MM / yyyy  ";           
            PanelListDevices.HorizontalScroll.Maximum = 0;
            PanelListDevices.AutoScroll = false;
            PanelListDevices.VerticalScroll.Visible = false;
            PanelListDevices.AutoScroll = true;
            PanelListChedules.HorizontalScroll.Maximum = 0;
            PanelListChedules.AutoScroll = false;
            PanelListChedules.VerticalScroll.Visible = false;
            PanelListChedules.AutoScroll = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour : DateTime.Now.Hour.ToString();
            String minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute : DateTime.Now.Minute.ToString();
            String second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second : DateTime.Now.Second.ToString();
            String day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day : DateTime.Now.Day.ToString();
            String month = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month : DateTime.Now.Month.ToString();
            String year = DateTime.Now.Year < 10 ? "0" + DateTime.Now.Year : DateTime.Now.Year.ToString();
            this.LabelTime.Text = hour + ":" + minute + ":" + second;
            this.LabelDay.Text = day + "" + month + "/" + year;
        }
    }
}
