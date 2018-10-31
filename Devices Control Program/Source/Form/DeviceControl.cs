using ControlDevice.Source.Data;
using Devices_Control_Program.Source.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Devices_Control_Program
{    
    public partial class DeviceControl : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public DeviceControl()
        {
            InitializeComponent();
        }

        private List<String> topics;

        private void LabelRoomName_SizeChanged(object sender, EventArgs e)
        {
            LabelRoomName.Left = (this.PanelInfo.Width - LabelRoomName.Size.Width) / 2;
        }

   

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Dictionary<string, MySwitch> mySwitches = new Dictionary<string, MySwitch>();
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs args)
        {
            
            Debug.WriteLine(Encoding.UTF8.GetString(args.Message), args.Topic.ToString() + "_" + 0);
            if (InvokeRequired)
            {
                Action action = new Action(() => doMqttMessageProcess(args.Topic.ToString(), Encoding.UTF8.GetString(args.Message)));
                //Invoke(new MethodInvoker(ShowListRoom));
                Debug.WriteLine("// Do Something LOL");
                this.BeginInvoke(action);
            }
          
        }

        private void doMqttMessageProcess(String mqttTopic, String mqttMessage)
        {
            try
            {
                MqttMessage message = JsonConvert.DeserializeObject<MqttMessage>(mqttMessage);
                if (message.type == 100 || message.type == 101 || message.type == 102)
                {
                    for (int i = 0; i < message.data.Count; i++)
                    {
                        if (message.data[i] != -1)
                        {
                            mySwitches[mqttTopic + "_" + i].Checked = message.data[i] == 1;
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("Message Rejected: Wrong type");
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Message Rejected: Wrong object");
            }
            //mySwitches[name].Checked = value;
        }

        private int rTop1 = 0;
        private int rTop2 = 0;
        private int rTop3 = 0;
        private Font drawFont = new Font("Times New Roman", 18);
        private int aHeight = 60;
        private int rWidth = 0;
        private int rPadding = 20;        
        private Panel DrawPanelDeviceOutput(Device device, int height)
        {            
            Panel p = new Panel();
            p.Name = device.topic;
            p.BackColor = Color.FromArgb(255, 255, 255);
            p.Size = new Size(rWidth, height);               
                p.Paint += (ss, ee) =>
                {
                    Graphics g = this.CreateGraphics();
                    ee.Graphics.DrawString(device.name, drawFont, Brushes.Black, 15, 20);
                    for (int x = 0; x < device.controls.@out.Count; x++)
                    {
                        ee.Graphics.DrawString(device.controls.@out[x].name, drawFont, Brushes.Black, 15, 20 + aHeight * (x + 1));
                        MySwitch mySwitch = new MySwitch();
                        mySwitch.Top = 20 + aHeight * (x + 1);
                        mySwitch.Left = rWidth - 80;
                        mySwitch.Width = 50;
                        mySwitch.Checked = true;
                        var pin = x;
                        mySwitch.CheckStateChanged += (object sender, EventArgs e) => mySwitches_CheckedChanged(sender, e, pin, device.topic);
                        Debug.WriteLine(device.topic + "_" + x);
                        if (!mySwitches.ContainsKey(device.topic + "_" + x)) mySwitches.Add(device.topic + "_" + x, mySwitch);
                        p.Controls.Add(mySwitch);
                    }
                };

            return p;
        }

        private void mySwitches_CheckedChanged(object sender, EventArgs e, int pin,  String topic)
        {
            JObject message = new JObject();
            message.Add("type", 1);
            JArray data = new JArray();
            data.Add(pin);
            data.Add(mySwitches[topic + "_" + pin].Checked ? 1: 0);
            message.Add("data", data);
            Debug.WriteLine("// Do Something in main process");
            Mqtt.client.Publish(topic, // topic
                              Encoding.UTF8.GetBytes(message.ToString()), // message body
                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                              false); // retained

        }

        private Panel DrawPanelDeviceInput(Device device, int height)
        {
            Panel p = new Panel();
            p.Name = device.id;
            p.BackColor = Color.FromArgb(255, 255, 255);
            p.Size = new Size(rWidth, height);
            p.Paint += (ss, ee) =>
            {
                Graphics g = this.CreateGraphics();
                ee.Graphics.DrawString(device.name, drawFont, Brushes.Black, 15, 20);

            };

            return p;
        }

        private void CreateDeviceBox()
        {           
            var devices = Data.User.device;
            rWidth = (PanelDevice1.ClientSize.Width);
            topics = new List<String>();
            List<Byte> QoS = new List<Byte>();
            LabelNumberDevices.Text = devices.Count.ToString();
            int numberofInput = 0;
            int numberofOutput = 0;
            for (int i = 0; i < devices.Count; i++)
            {
                var device = devices[i];
                QoS.Add(MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE);
                topics.Add(device.topic);
                Mqtt.client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;                
                if (device.isInput())
                {
                    numberofInput++;
                    if (rTop1 <= rTop2 && rTop1 <= rTop3)
                    {
                        int rHeight = aHeight;
                        Panel p = DrawPanelDeviceInput(device, rHeight);
                        p.Top = rTop1;
                        rTop1 += rHeight + rPadding;
                        PanelDevice1.Controls.Add(p);
                        PanelDevice1.Invalidate();
                    }
                    else if (rTop2 <= rTop1 && rTop2 <= rTop3)
                    {
                        int rHeight = aHeight;
                        Panel p = DrawPanelDeviceInput(device, rHeight);
                        p.Top = rTop2;
                        rTop2 += rHeight + rPadding;
                        PanelDevice2.Controls.Add(p);
                        PanelDevice2.Invalidate();
                    }
                    else
                    {
                        int rHeight = aHeight;
                        Panel p = DrawPanelDeviceInput(device, rHeight);
                        p.Top = rTop3;
                        rTop3 += rHeight + rPadding;
                        PanelDevice3.Controls.Add(p);
                        PanelDevice3.Invalidate();
                    }
                }
                else
                {
                    numberofOutput++;
                    if (rTop1 <= rTop2 && rTop1 <= rTop3)
                    {
                        int rHeight = aHeight * (device.controls.@out.Count + 1);
                        Panel p = DrawPanelDeviceOutput(device, rHeight);
                        p.Top = rTop1;
                        rTop1 += rHeight + rPadding;
                        PanelDevice1.Controls.Add(p);
                        PanelDevice1.Invalidate();
                    }
                    else if (rTop2 <= rTop1 && rTop2 <= rTop3)
                    {
                        int rHeight = aHeight * (device.controls.@out.Count + 1);
                        Panel p = DrawPanelDeviceOutput(device, rHeight);
                        p.Top = rTop2;
                        rTop2 += rHeight + rPadding;
                        PanelDevice2.Controls.Add(p);
                        PanelDevice2.Invalidate();
                    }
                    else
                    {
                        int rHeight = aHeight * (device.controls.@out.Count + 1);
                        Panel p = DrawPanelDeviceOutput(device, rHeight);
                        p.Top = rTop3;
                        rTop3 += rHeight + rPadding;
                        PanelDevice3.Controls.Add(p);
                        PanelDevice3.Invalidate();
                    }                    
                }
            }
            LabelNumberOutput.Text = numberofOutput.ToString();
            LabelNumberInput.Text = numberofInput.ToString();
            Debug.WriteLine("Subscrible to " + topics.ToArray());            
            if (topics.Count > 0) Mqtt.client.Subscribe(topics.ToArray<String>(), QoS.ToArray<Byte>());
        }
        private void DeviceControl_Load(object sender, EventArgs e)
        {
            CreateDeviceBox();
        }

        private void DeviceControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (topics.Count > 0) Mqtt.client.Unsubscribe(topics.ToArray<String>());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTurnOnAllDevices_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn bật hết thiết bị?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                   
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void ButtonTurnOffAllDevices_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tắt hết thiết bị?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void PanelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }    
}
