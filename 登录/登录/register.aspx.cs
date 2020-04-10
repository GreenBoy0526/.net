using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登录
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Uname = this.uName.Text;
            string Pwd = this.Pwd.Text;
            string stuNo = this.StuNo.Value;
            string emali = this.Email.Value;
            string addr = this.Addr.Text;
            string phone = this.Phone.Text;
            string bDate = this.BornDate.Text;
            string sex = this.Sex.Text;
            string gid = this.GradeId1.Value;







            //1.从配置文件Web.config读取配置文件的字符串  connectionStrings
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            //2.引入using System.Data.SqlClient;  可以使用SqlConnection
            SqlConnection conn = new SqlConnection(connString);


            conn.Open();

            //3.声明一个sql语句
            string sqlStr = @"INSERT INTO [MySchool].[dbo].[Student]
           ([Studentno]
           ,[LoginPwd]
           ,[StudentName]
           ,[Sex]
           ,[Gradeld]
           ,[Phone]
           ,[Address]
           ,[BornDate]
           ,[Email])
     VALUES
           ('" + stuNo + "','" + Pwd + "','" + Uname + "'," + sex + "," + gid + ",'" + phone + "','" + addr + "','" + bDate + "','" + emali + "')";


            //4.SqlCommand
            SqlCommand comm = new SqlCommand(sqlStr, conn);


            int dr = comm.ExecuteNonQuery();

            if (dr > 0)
            {
                Response.Write("<script>alert('保存成功');window.location.href='Logins.aspx';</script>");

            }

            conn.Close();
        }
    }
}