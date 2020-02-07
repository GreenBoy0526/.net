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
    public partial class players : Form
    {
        public string path = "";
        public players()
        {
            InitializeComponent();
        }

        private void players_Load(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = path;
        }
    }
}
