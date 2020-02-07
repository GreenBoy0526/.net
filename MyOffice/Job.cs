using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    public class Job
    {
        //工作名称
        public string Name { get; set; }

        //描述
        public string Description { get; set; }

        public Job(string name, string descrition )
        {
            this.Name = name;
            this.Description = descrition;
        }
    }
}
