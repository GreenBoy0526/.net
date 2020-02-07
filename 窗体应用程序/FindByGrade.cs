using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 窗体应用程序
{
    public partial class FindByGrade : Form
    {
        public DataSet dateset = new DataSet();
        public FindByGrade()
        {
            InitializeComponent();
        }

        private void FindByGrade_Load(object sender, EventArgs e)
        {
            //年级
            DBhelper dbhelp = new DBhelper();
            string sql = "select * from Grade";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbhelp.getConn());

            adapter.Fill(dateset, "GradeName");
            this.comboBox1.DataSource = dateset.Tables["GradeName"];
            this.comboBox1.ValueMember = "Gradeld";
            this.comboBox1.DisplayMember = "GradeName";
             
            //sql = "select * from Student";
            //adapter = new SqlDataAdapter(sql,dbhelp.getConn());
            //adapter.Fill(dateset, "");
            //this.dataGridView1.DataSource = dateset.Tables[""];
        }
    }
}