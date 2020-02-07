using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyPlayer
{
    public partial class FrmMain : Form
    {
        List<Video> videoList = new List<Video>();

        public FrmMain()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            videoList.Add(new Video("1", "柠檬树", "D:\\video\\柠檬树.mp3"));
            videoList.Add(new Video("2", "Leo", "D:\\video\\leo.mp3"));
            videoList.Add(new Video("3", "dreamen", "D:\\video\\dreamen.mp3"));

            UpdateDgv();
        }

        public void UpdateDgv()
        {
            this.dgvVedioList.DataSource = videoList;
        }

        private void tsmiPlayer_Click(object sender, EventArgs e)
        {
            //获取播放路径
            string videoPath = this.dgvVedioList.CurrentRow.Cells["path"].Value.ToString();
            if (!File.Exists(videoPath))
            {
                MessageBox.Show("文件不存在！","提示");
                return;
            }
            //创建单例
            FrmPlayer myPlayer = FrmPlayer.GetInstance();
            bool result = myPlayer.Play(videoPath);
            if (result)
            {
                //显示
                myPlayer.Show();
            }
            else
            {
                //释放
                myPlayer.Dispose();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
