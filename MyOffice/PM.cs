using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    /// <summary>
    /// 项目经理类

    /// </summary>
    class PM:Employee
    {
        public PM(string id, string name, int age, Gender gender, int yearOfExperience, List<Job> list)
            : base(id, age, name, gender,list)
        {
            this.YearOfExperience = yearOfExperience;
        }

        public PM() { }

        /// <summary>
        /// 资历
        /// </summary>
        private int _yearOfExperience; 
        public int YearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }

       

        /// <summary>
        /// 工作
        /// </summary>
        /// <returns></returns>
        public string DoWork() 
        {
            string message=this.Name+"：管理员工完成工作内容！";
            return message;
        }
    }
}
