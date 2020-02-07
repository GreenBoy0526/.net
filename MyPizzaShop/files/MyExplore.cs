using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    public class MyFile
    {
        /// <summary>
        /// 文件名
        /// </summary>
        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        /// <summary>
        /// 文件类型
        /// </summary>
        private string fileType;
        public string FileType
        {
            get { return fileType; }
            set
            {
                if (value.Length > 1)
                {
                    fileType = value.Substring(1, value.Length - 1);
                }
            }
        }

        /// <summary>
        /// 文件大小
        /// </summary>
        private float fileLength;
        public float FileLength
        {
            get { return fileLength; }
            set
            {
                //将字节大小转换为KB为单位

                fileLength = float.Parse(Math.Round(value / 1024, 2).ToString());
            }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

    }
}
