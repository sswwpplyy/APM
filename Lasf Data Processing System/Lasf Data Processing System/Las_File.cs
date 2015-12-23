using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Las_File
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public Las_Header Header;
        public List<Las_Data> Point;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="header"></param>
        public Las_File(Las_Header header)
        {
            this.Header = header;
            this.Point = new List<Las_Data>();
        }
    }
}
