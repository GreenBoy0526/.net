using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pisa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            XmlDocument fff = new XmlDocument();
            fff.Load("../../凤凰卫视.xml");

            XmlNode xn = fff.DocumentElement;

            TreeNode tn = new TreeNode();
            tn = this.treeView1.Nodes.Add("电视台");  //为treeview控件添加根节点，并付给一个节点（tn）变量，再为这个节点变量添加他自己的子节点
            foreach (XmlNode item in xn.ChildNodes)  //xml 有几层子节点，就写几个foreach循环，找到最后一层的数据
            {
                foreach (XmlNode items in item.ChildNodes)
                {
                    if (items.Name == "Program")
                    {
                        foreach (XmlNode item2 in item.ChildNodes)
                        {
                            tn.Nodes.Add(item2["name"].InnerText);
                        }
                    }
                }
            }

            TreeNode tn2 = new TreeNode();
            tn2 = this.treeView1.Nodes.Add("电视台2");


            tn2.Nodes.Add("电视台2");
            tn2.Nodes.Add("电视台3");
            tn2.Nodes.Add("电视台4");
            tn2.Nodes.Add("电视台5");


            this.textBox1.Text = str;
        }
    }
}
