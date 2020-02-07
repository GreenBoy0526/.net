using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MyPlayer
{
    public partial class FrmPlayer : Form
    {
        //独一无二的实例

        private static FrmPlayer uniquePlayer;
        
        //私有构造函数

        private FrmPlayer()
        {
            InitializeComponent();
        }
        //检查并创建唯一实例
        public static FrmPlayer GetInstance() 
        {
            if (uniquePlayer == null) 
            {
                uniquePlayer = new FrmPlayer();
            }
            return uniquePlayer;
        }

        //播放节目
        public bool Play(string videoPath)
        {
            try
            {
                this.wmp.URL = videoPath;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放器异常" + ex.Message);
                return false;
            }
        }

        //关闭过程中将实例引用设为null
        private void FrmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPlayer.uniquePlayer = null;
        }
    }
}
