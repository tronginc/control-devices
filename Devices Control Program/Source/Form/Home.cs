using ControlDevice.Source.Data;
using Devices_Control_Program.Source.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Devices_Control_Program
{
    public partial class Home : Form
    {
        /**
         * Form chính, hiển thị danh sách phòng, sửa phòng, thêm phòng, xóa phòng, hẹn giờ và cài đặt
         * Các chức năng như danh sách phòng, thêm phòng được tách ra cách control panel riêng và hiển thị (Bring to Front) khi click vào danh sách button menu bên trái
         * Các control trong Panel danh sách phòng sẽ được tạo bằng code, vì số lượng phòng không biết trước và được lấy từ server thông qua API   
         * 
         * */
        private Loading loading;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            // Bỏ comment để bỏ qua form đăng nhập (token được lấy từ lần đăng nhập trước lấy và gán luôn cho đỡ tốn time đăng nhập :D) 
            Data.User.token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiIrODQxNjQ3OTA2ODc4IiwiYXVkIjoidGhvbWkiLCJpYXQiOjE1NDA0MTY5ODJ9.t6YaSCniaUlPs7GRL9_1-Lo6wqV9R691DEYZ3EOA9oJBXKRDNcSKIHRREt2PrUDRvTMnVx0Oh2eItNZbvfUnCg";

            // Check token, kiểm tra đăng nhập, nếu chưa thì hiển thị form đăng nhập và bắt buộc đăng nhập
            if (Data.User.token == null)
            {
                SignIn signIn = new SignIn();
                signIn.ShowDialog();
                // Nếu tắt form đăng nhập mà vẫn chưa có token chứng tỏ đăng nhập không thành công => tắt form này đi
                if (Data.User.token == null) this.Close();
            }   

            // Cho phép Panel này scroll, vì số phòng không cho trước và có thể rất rất rất là nhiều
            listRoom.AutoScroll = true;

        }
        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            // Di chuyển form nếu kéo thả chuột trái khi click vào Panel trên cùng
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureIconExit_Click(object sender, EventArgs e)
        {
            // Hàm này dùng để bắt sự kiện click vào button tắt form

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn tắt phần mềm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Ngắt kết nối MQTT trước khi tắt form, vì kết nối này chạy ở luồng khác nếu không tắt thì form vẫn chạy background chứ không tắt hoàn toàn
                Mqtt.client.Disconnect();

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

        [MethodImpl(MethodImplOptions.Synchronized)]
        private bool GetData()
        {
            // Lấy danh sách phòng và thiết bị từ API
            try
            {
                return Api.GetListRoom() && Api.GetListDevice();
            }
            // Trong hàm api này có throw Exception nên bắt buộc phải bắt (Ví dụ như lỗi mạng, lỗi server,...)
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message.ToString(), "Thông báo");
            }
            return false;
        }

        private void ShowListRoom()
            /**
             * 
             * * * * - Hàm này sẽ get data là danh sách phòng từ backend về, sau đó tạo và hiển thị từng phòng bằng code  
             * * *      + Mỗi phòng sẽ được hiển thị bằng Panel
             * * *      + Mỗi Panel (phòng) sẽ được hiển thị Tên phòng, icon phòng và số thiết bị có trong phòng đó
             * * *      + Cách hiển thị: 3 phòng 1 dòng, nghĩa là sẽ có 3 cột, ở đây ta dùng dàm chia lấy số dư cho 3 ( dư 0: cột 1, dư 1: cột 2, và ngược lại cột 3)
             * * *      + Sau khi được tạo xong thì các Panel ( phòng ) này sẽ được thêm vào Panel chính đó là Panel ListRoom      
             * */
        {
            if (GetData())
            {               
                var rPadding = 50; // Khoảng cách padding trên / dưới / trái / phải
                int left = 0; // Xác định vị trí của Panel phòng. nằm đầu tiên, ở giữa hay cuối cùng
                int top = 0; // Xác định vị trí dòng của phòng
                int rWidth = (listRoom.ClientSize.Width - rPadding * 4) / 3;  // Lấy chiều rộng mỗi Panel phòng là 1/3 Panel ListRoom, có trừ các khoảng cách padding
                int rHeight = 250; // Chiều cao của Panel Phòng
                Graphics g = this.CreateGraphics();
                Font drawFontRoom = new Font("Times New Roman", 21);
                Font drawFontSub = new Font("Times New Roman", 15);
                listRoom.Controls.Clear(); // Bắt buộc phải clear đi nếu gọi hàm ShowListRoom() nhiều lần sẽ bị phòng đè phòng, không ảnh hưởng đến giao diện nhưng rất tốn tài nguyên
                for (int x = 0; x < Data.User.rooms.Count; x++)
                {

                    // Mục đích để hiển thị 3 cột
                    if (x == 0)
                    {
                        left += rPadding;
                        top += rPadding;
                    }
                    else if (x % 3 != 0)
                    {
                        left += rWidth + rPadding;
                    }
                    else if (x % 3 == 0 && x != 0)
                    {
                        top += rPadding + rHeight;
                        left = rPadding;
                    }
                    var room = Data.User.rooms[x];

                    // Tạo 1 Panel phòng
                    Panel p = new Panel();
                    p.Name = "Panel" + (listRoom.Controls.Count + 1);
                    p.BackColor = Color.FromArgb(255, 255, 255);
                    p.Size = new Size(rWidth, rHeight);
                    p.Top = top;                    
                    p.Left = left;

                    // Lắng nghe sự kiện nhấn vào Panel, ở đây sẽ mở Form hiển thị danh sách thiết bị ở phòng đó, xem hàm P_Click để rõ hơn
                    p.Click += new EventHandler((sss, eee) => P_Click(sss, eee, room));

                    // Tạo hiệu ứng đổi màu khi rê chuột ra / vào Panel phòng
                    p.MouseEnter += (object _sender, EventArgs _eventArgs) =>
                    {
                        p.BackColor = Color.FromArgb(235, 235, 235);
                    };
                    p.MouseLeave += (object _sender, EventArgs _eventArgs) =>
                    {
                        p.BackColor = Color.FromArgb(255, 255, 255);
                    };
                    
                    // Hiển thị tên phòng, icon và số thiết bị trên từng Panel phòng
                    p.Paint += (ss, ee) =>
                    {
                        String txtNumberDevices = room.numberOfDevice.ToString() + " thiết bị";
                        SizeF size = g.MeasureString(room.name, drawFontRoom);
                        ee.Graphics.DrawString(room.name, drawFontRoom, Brushes.Black, (rWidth - size.Width) / 2, 17);
                        SizeF msize = g.MeasureString(txtNumberDevices, drawFontSub);
                        ee.Graphics.DrawString(txtNumberDevices, drawFontSub, Brushes.Black, (rWidth - msize.Width) / 2, 200);
                        Image imag = Image.FromFile(@"C:\Users\TRONG\Pictures\devices\" + Data.roomIcon[room.icon]);
                        ee.Graphics.DrawImage(imag, new Point((rWidth - 131) / 2, 60));
                    };

                    // Tạo 1 button menu trên từng phòng
                    Button button = new Button();
                    button.BackColor = Color.FromArgb(255, 255, 255);
                    button.Image = Image.FromFile(@"C:\Users\TRONG\Pictures\icon\menu.png");
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Width = 50;
                    button.Height = 50;
                    button.Left = rWidth - 57;
                    button.Top = 7;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;

                    // Tạo 1 ContextMenuStrip chứa menu của phòng mở khi bấm vào button trên
                    ContextMenuStrip myMenu = new ContextMenuStrip();                    
                    myMenu.Items.Add("Sửa phòng");
                    myMenu.Items.Add("Xóa phòng"); 
                    button.Click += (object sender, EventArgs eventArgs) =>
                    {
                        myMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                    };

                    // Thêm button vào từng Panel phòng
                    p.Controls.Add(button);

                    // Thêm từng Panel phòng vào Panel ListRoom
                    listRoom.Controls.Add(p);
                    listRoom.Invalidate();

                    // Tắt Form loading
                    loading.Close();

                    // Hiển thị Panel phòng
                    listRoom.BringToFront();

                }

                // Ẩn ảnh Loading tên thanh Panel Menu
                LoadingPicture.Hide();
            }
        }
      

        private void Home_Shown(object sender, EventArgs e)
        {

            if (Data.User.rooms == null || Data.User.devices == null)
            {
                // Hiển thị Form Loading
                loading = new Loading();
                loading.Show();
                loading.TopMost = true;

                /**
                 * Tạo luồng mới để Lấy dữ liệu từ server thông qua API, việc này khá tốn thời gian tùy vào tốc độ đường truyền cũng như tốc độ xử lý của server
                 * Mục đích để Form hiển thị mượt mà không bị đơ đứng khi gọi API 
                 **/
                Thread thread = new Thread(() =>
                {
                    if (InvokeRequired)
                    {
                        Action action = new Action(ShowListRoom);
                        //Invoke(new MethodInvoker(ShowListRoom));
                        Debug.WriteLine("// Do Something LOL");
                        this.BeginInvoke(action);
                    }
                    else
                    {
                        // Do Something
                        Debug.WriteLine("// Do Something");
                        ShowListRoom();
                    }
                });
                thread.Start();

                // Tạo kết nối Mqtt.client đến broker để điều khiển thiết bị
                string clientId = Guid.NewGuid().ToString();
                Mqtt.client.Connect(clientId);
                Debug.WriteLine("Connect with clientID: " + clientId);
            }
        }
      
        // Hàm bắt sự kiện khi click vào Panel phòng
        private void P_Click(object sender, EventArgs e, Room room)
        {
            this.Hide();

            // Tìm kiếm tất cả các thiết bị nằm trong phòng đã click
            List<Device> devices = new List<Device>();
            for (int i = 0; i < Data.User.devices.Count; i++)
            {
                if (Data.User.devices[i].roomID == room.id)
                {                    
                    devices.Add(Data.User.devices[i]);
                }
            }
            
            // Hiển thị các giá trị như icon, tên phòng ở màn hình Device
            Data.User.device = devices;
            DeviceControl deviceControl = new DeviceControl();
            deviceControl.LabelRoomName.Text = room.name;
            deviceControl.PictureRoomIcon.Image = Image.FromFile(@"C:\Users\TRONG\Pictures\devices\" + Data.roomIcon[room.icon]);

            // Hiển thị form Device
            deviceControl.ShowDialog();

            // Đợi đến khi nào form Device tắt và hiển thị lại form này
            this.Show();

        }

        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            PanelLeftButton.Top = ButtonAddRoom.Top;
            // Hiển thị panel AddRoom
            addRoom.BringToFront();
        }

        private void ButtonListRoom_Click(object sender, EventArgs e)
        {     
            PanelLeftButton.Top = ButtonListRoom.Top;
            /**
                 * Tạo luồng mới để get lại phòng
                 * Mục đích để Form hiển thị mượt mà không bị đơ đứng khi gọi API 
                 **/
            Thread thread = new Thread(() =>
            {
                if (InvokeRequired)
                {
                    Action action = new Action(ShowListRoom);
                    //Invoke(new MethodInvoker(ShowListRoom));
                    Debug.WriteLine("// Do Something LOL");
                    this.BeginInvoke(action);
                }
                else
                {
                    // Do Something
                    Debug.WriteLine("// Do Something");
                    ShowListRoom();
                }
            });
            thread.Start();
            // Hiển thị panel AddRoom
            listRoom.BringToFront();
        }

        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            PanelLeftButton.Top = ButtonTimer.Top;
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            PanelLeftButton.Top = ButtonSetting.Top;
        }
    }
}
