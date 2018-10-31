using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Devices_Control_Program.Source.Util;

namespace Devices_Control_Program
{
    public partial class AddRoom : UserControl
    {
        private String imageFileName;
        private int iconRoomIndex;

        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            var rootDirectoryInfo = new DirectoryInfo(@"C:\Users\TRONG\Pictures\devices");
            TreeViewListIcon.Nodes.Clear();
            var directoryNode = new TreeNode(rootDirectoryInfo.Name);

            foreach (var file in rootDirectoryInfo.GetFiles())
            {
                TreeViewListIcon.Nodes.Add(new TreeNode(file.Name));
            }            
        }

        private void TreeViewListIcon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode CurrentNode = e.Node;
            if (CurrentNode.FullPath != null && CurrentNode.FullPath  != @"\")
            {                
                String imageFullPath = @"C:\Users\TRONG\Pictures\devices\" + CurrentNode.FullPath;
                LabelFileName.Text = CurrentNode.FullPath;
                imageFileName = CurrentNode.FullPath;
                PictureRoomIcon.Image = Image.FromFile(imageFullPath);
            }                 
        }

        private void LabelFileName_SizeChanged(object sender, EventArgs e)
        {
            LabelFileName.Left = (this.PanelFileName.Width - LabelFileName.Size.Width) / 2;
        }

        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            List<String> icons = Data.roomIcon;
            int index = icons.BinarySearch(imageFileName);
            if (Api.AddRoom(TextBoxUsername.Text, index))
            {
                MessageBox.Show("Thêm phòng " + TextBoxUsername.Text + " thành công!", "Thông báo");
            }
        }
       
    }
}
