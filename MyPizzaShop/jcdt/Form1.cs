using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jcdt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name,string addr,int age,string se
            //SE se = new SE("张三","山东日照",22,"程序员");

            //MessageBox.Show(se.SayHi());







        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string name,string addr,int age,string se
            PM pm = new PM("张经理", "山东青岛", 42, "经理");

            MessageBox.Show(pm.SayHi());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //SE se = new SE("张三", "山东日照", 22, "程序员");
            //SE se2 = new SE("调试员", "山东济南", 24, "调试员");
            //PM pm = new PM("张经理", "山东青岛", 42, "经理");


            //List<Empolyee> ep = new List<Empolyee>();

            //ep.Add(se);
            //ep.Add(pm);
            //ep.Add(se2);

            //ep[1].SayHi();





            
            //foreach (Empolyee item in ep)
            //{

            //    MessageBox.Show(item.SayHi());

            //    //if (item is SE)
            //    //{
            //    //    //
            //    //    SE s = item as SE;
            //    //    MessageBox.Show(s.SayHi());

            //    //}
            //    //if (item is PM)
            //    //{
            //    //    //
            //    //    PM p = (PM)item;
            //    //    MessageBox.Show(p.SayHi());

            //    //}

            //}

            //MessageBox.Show(ep[0].GoHome(new car()));
            //MessageBox.Show(ep[1].GoHome(new byc()));
            //MessageBox.Show(ep[2].GoHome(new buscs()));



        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.textBox1.Text);
            int b = int.Parse(this.textBox2.Text);

            string op = this.comboBox1.Text;

            factory fa = new factory();
            option ops = fa.CaoZuo(op);


            Oadd oa = new Oadd(a,b);

            this.label2.Text = oa.result(a,b).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SE se = new SE("张三", "山东日照", "22");
            SE se2 = new SE("调试员", "山东济南", "22");
            SE pm = new SE("张经理", "山东青岛", "22");


            List<SE> ep = new List<SE>();

            ep.Add(se);
            ep.Add(pm);
            ep.Add(se2);

            this.dataGridView1.DataSource = ep;

            axWindowsMediaPlayer1.URL = "D:\\Documents\\Tencent Files\\1052454198\\FileRecv\\一出好戏 TS全网首播 (1).mp4";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
