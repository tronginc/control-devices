using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Devices_Control_Program.Source.Util;
using System.Threading;

namespace Devices_Control_Program
{
    public partial class SignIn : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public SignIn()
        {
            InitializeComponent();
        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

  

        private void SignIn_Load(object sender, EventArgs e)
        {
            TextBoxUsername.Text = "+841647906878";
            TextBoxPassword.Text = "123456";
            LoadingPicture.Hide();
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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoadingPicture.Show();
            ButtonLogin.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            PanelRight.Enabled = false;
            try
            {           
                if (Api.SignIn(TextBoxUsername.Text, TextBoxPassword.Text))
                {
                    Thread.Sleep(1000);
                    ButtonLogin.Enabled = true;
                    Cursor.Current = Cursors.Default;
                    PanelRight.Enabled = true;
                    LoadingPicture.Hide();
                    if (Data.User.token != null)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Thông báo");               
                ButtonLogin.Enabled = true;
                Cursor.Current = Cursors.Default;
                PanelRight.Enabled = true;
                LoadingPicture.Hide();
            }
        }
    }
}
