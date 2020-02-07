using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用程序
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void 新增学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.MdiParent = this;
            add.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
           
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.MdiParent = this;
            about.Show();
        }
    }
}
