using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace 登录
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler, IRequiresSessionState //ashx中session需要用到IRequiresSessionState接口
    {

        public void ProcessRequest(HttpContext context)
        {
            string no = context.Request["Uname"];
            string pwd = context.Request["Pwd"];
            string connstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sqlstr = "select StudentName from Student where Studentno='" + no + "' and LoginPwd='" + pwd + "'";

            SqlCommand comm = new SqlCommand(sqlstr, conn);
            SqlDataReader dr = comm.ExecuteReader();
            string flag = "0";
            while (dr.Read())
            {
                context.Session["StudentName"] = dr["StudentName"].ToString();
                flag = "1";
            }
            conn.Close();
            context.Response.Write(flag);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}