﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<=80)
            {
                progressBar1.Value = progressBar1.Value + 20;
            }
            if (pictureBox1.Width<=80)
            {
                pictureBox1.Width += 20;
            }
        }
    }
}
