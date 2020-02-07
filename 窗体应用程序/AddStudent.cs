using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 窗体应用程序
{
    public partial class AddStudent : Form
    {
        SqlConnection conn;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void AddStudent_Load(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(str);
            conn.Open();
            string sql = "select GradeName from Grade ";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                this.comboBox1.Items.Add(reader["GradeName"]);
            }
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码");
            }
            else if (txtPwd1.Text != txtPwd.Text)
            {
                MessageBox.Show("密码输入不一致");
            }
            else
            {

            }
            
        }
        
    }
}
