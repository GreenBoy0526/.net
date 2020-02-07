using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 写入文件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.ofdFile.ShowDialog();  //打开打开窗口
            string str = ofdFile.FileName;  //获取选中的文件

            string desc = this.richTextBox1.Text;

            //if (!File.Exists(str))
            //{
            //    File.Create(str).Close();
            //}

            //创建文件流
            FileStream fs = new FileStream(str, FileMode.Append);


            //写入文件
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);


            //内容写到文件当中去
            sw.Write(desc);

            sw.Close();

            fs.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ofdFile.ShowDialog();
            string str = ofdFile.FileName;

            //创建文件流
            FileStream fs = new FileStream(str, FileMode.Open);


            //读取文件
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);


            //内容写到文件当中去
            this.richTextBox1.Text = sr.ReadToEnd();

            sr.Close();

            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string str = "";
            XmlDocument fff = new XmlDocument();
            fff.Load("../../凤凰卫视.xml");


            XmlNode xn = fff.DocumentElement;
            
            foreach (XmlNode item in xn.ChildNodes)  //xml 有几层子节点，就写几个foreach循环，找到最后一层的数据
            {
                foreach (XmlNode items in item.ChildNodes)
                {
                    if (items.Name == "Program")
                    {
                        foreach (XmlNode ssss in item.ChildNodes)
                        {
                            foreach (XmlNode item2 in ssss.ChildNodes)
                            {
                                if (item2.Name == "playTime")
                                {
                                    str += item2.InnerText + "|";
                                }

                                if (item2.Name == "name")
                                {
                                    str += item2.InnerText + "|";
                                }
                                if (item2.Name == "path")
                                {
                                    str += item2.InnerText + "|";
                                }

                            }
                        }
                    }
                }
            }

            //创建文件流
            FileStream fs = new FileStream("D:\\FHWS.txt", FileMode.Append);


            //写入文件
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);


            //内容写到文件当中去
            sw.Write(str);

            sw.Close();

            fs.Close();



        }

        /// <summary>
        /// 移动-剪切黏贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.ofdFile.ShowDialog();

            string path = ofdFile.FileName;


        //    File.Move(path,"D:\\TTTAAAsss.txt");


            Directory.Move(path, "D:\\dddddTTTAss.txt");

        }
    }
}
