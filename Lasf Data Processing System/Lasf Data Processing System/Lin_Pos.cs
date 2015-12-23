using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Lin_Pos
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public double X;
        public double Y;
        public double Mileage;          //里程

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mileage"></param>
        public Lin_Pos(double x, double y, double mileage)
        {
            this.X = x;
            this.Y = y;
            this.Mileage = mileage;
        }
    }
}
