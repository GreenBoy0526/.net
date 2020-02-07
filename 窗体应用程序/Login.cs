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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()==""|textBox2.Text.Trim()==""| cmbLoginType.Text.Trim()=="")
            {
                MessageBox.Show("不能为空");
            }
            else
            {
                if (cmbLoginType.Text=="管理员")
                {
                    AdminMain ff = new AdminMain();
                    ff.Show();
                }
                else
                {

                }
                this.Hide();
                
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red)
            {
                BackColor = Color.Yellow;
            }
            else if (BackColor == Color.Yellow)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
