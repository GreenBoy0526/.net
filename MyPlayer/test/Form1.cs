using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string urls = dataGridView1.CurrentRow.Cells["FileUrl"].Value.ToString();

            if (!File.Exists(urls))
            {
                MessageBox.Show("当前文件不存在");
                return;
            }

            Player p = new Player();

            p.plays(urls);
            p.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Files> lf = new List<Files>();
            Files ff1 = new Files();
            ff1.FileName = "月光下的凤尾竹";
            ff1.FileUrl = "E://song//志扬教育//深入.NET平台和C#编程//Chapter08//视频//03 月光下的凤尾竹.mp3";

            Files ff2 = new Files();
            ff2.FileName = "XXX歌";
            ff2.FileUrl = "E://song//志扬教育//深入.NET平台和C#编程//Chapter08//视频//ccc.mp3";

            lf.Add(ff1);
            lf.Add(ff2);

            this.dataGridView1.DataSource = lf;


        }
    }
}
