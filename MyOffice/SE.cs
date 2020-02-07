using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    
    /// <summary>
    /// 程序员类
    /// </summary>
    class SE:Employee
    {
        /// <summary>
        /// 带参构造函数
        /// </summary>
        /// <param name="id">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="gender">性别</param>
        /// <param name="popularity">人气值</param>
        public SE(string id,string name,int age, Gender gender, int popularity,List<Job> list): base(id,age,  name,gender,list)
        {
            this.Popularity = popularity;
        }

        public SE() { }

        /// <summary>
        /// 人气值
        /// </summary>
        public int Popularity { get; set; }

       /// <summary>
       /// 工作
       /// </summary>
       /// <returns></returns>
        public string DoWork() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name+":\n");
            for (int i = 0; i < this.WorkList.Count; i++ ) 
            {
                sb.Append((i + 1) + "、" + WorkList[i].Name + ":" + WorkList[i].Description+"\n");
            }
            return sb.ToString();
        }
    }
}
