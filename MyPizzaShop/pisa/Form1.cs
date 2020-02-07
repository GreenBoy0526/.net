using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nl = this.rbNaiLao.Text;
            //string pg = this.rbPeiGen.Text;

            factory fa = new factory();
            pisaPar pa = null;
            string ck = "";
            if (this.rbNaiLao.Checked)
            {
                pa = fa.show(this.rbNaiLao.Text);
            }
            else
            if (this.rbPeiGen.Checked)
            {
                pa = fa.show(this.rbPeiGen.Text);
            }


            MessageBox.Show(pa.show());





        }
    }
}
