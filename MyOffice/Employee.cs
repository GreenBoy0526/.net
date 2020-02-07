using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    public class Employee
    {
        public Employee() { }

        public Employee(string id, int age, string name, Gender gender,List<Job> list)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.WorkList = list;
        }

        /// <summary>
        /// 工号
        /// </summary>
        protected string ID { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        protected int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        protected Gender Gender { get; set; }

        /// <summary>
        /// 工作列表
        /// </summary>
        protected List<Job> WorkList { get; set; }
    }
}
