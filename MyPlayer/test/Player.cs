using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        public void plays(string url) {
            this.axWindowsMediaPlayer1.URL = url;
        }
    }
}
