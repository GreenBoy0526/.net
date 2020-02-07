using System;
using System.Windows.Forms;

namespace 大小图标切换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
    }
}
