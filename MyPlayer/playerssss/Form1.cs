using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playerssss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<files> lf = new List<files>();
            files ff = new files();
            ff.FileName = "视频";
            ff.FilePath = "D:/QU/-116640902.mp4";

            lf.Add(ff);

            ff = new files();
            ff.FileName = "音频";
            ff.FilePath = "D:/QU/Cheerful.mp3";

            lf.Add(ff);

            this.dataGridView1.DataSource = lf;

        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.dataGridView1.CurrentRow.Cells["FilePath"].Value.ToString();
            players pp = new players();
            pp.path = path;
            pp.ShowDialog();
        }
    }
}
