using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 枚举类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.name = "张三";
            st.sex = (int)Sex.female;
            ListViewItem item = new ListViewItem(st.name);
            item.SubItems.Add(st.sex.ToString());
            listView1.Items.Add(item);
        }
    }
}
