using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Dpan : Form
    {
        public Dpan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;

            DirectoryInfo directoryInfo = new DirectoryInfo(node.Tag.ToString());
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            foreach (DirectoryInfo di in dirs)
            {
                TreeNode temp = new TreeNode();
                temp.Text = di.Name;
                temp.Tag = di.FullName;
                node.Nodes.Add(temp);
            }


            FileInfo[] fileInfo = directoryInfo.GetFiles();
            List<MyFile> files = new List<MyFile>();
            foreach (FileInfo myFile in fileInfo)
            {
                MyFile file = new MyFile();
                file.FileName = myFile.Name;
                file.FileLength = myFile.Length;
                file.FileType = myFile.Extension;
                file.FilePath = myFile.FullName;
                files.Add(file);
            }

            ListViewItem item = null;
            lvFiles.Items.Clear();
            foreach (MyFile file in files)
            {
                item = new ListViewItem();
                item.Text = file.FileName;
                item.SubItems.Add(file.FileLength.ToString());
                item.SubItems.Add(file.FileType);
                item.SubItems.Add(file.FilePath);
                this.lvFiles.Items.Add(item);
            }


        }

        private void Dpan_Load(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "D:\\";
            tn.Tag = "D:\\";

            this.treeView1.Nodes.Add(tn);
        }
    }
}
