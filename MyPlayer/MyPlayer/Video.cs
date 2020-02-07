using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPlayer
{
    class Video
    {
        public Video(string id, string name, string path)
        {
            this.ID = id;
            this.Name = name;
            this.Path = path;
        }

        //编号
        public string ID { get; set; }

        //名称
        public string Name { get; set; }

        //路径
        public string Path { get; set; }
    }
}
