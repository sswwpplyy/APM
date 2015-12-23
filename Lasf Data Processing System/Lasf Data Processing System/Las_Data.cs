using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Las_Data
    {
         /// <summary>
        /// 全局变量
        /// </summary>
        public static double XFactor;
        public static double XOffset;
        public static double YFactor;
        public static double YOffset;
        public static double ZFactor;
        public static double ZOffset;
        public double DblX;
        public double DblY;
        public double DblZ;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="intX"></param>
        /// <param name="intY"></param>
        /// <param name="intZ"></param>
        public Las_Data(int intX, int intY, int intZ)
        {
            this.DblX = intX * Las_Data.XFactor + Las_Data.XOffset;
            this.DblY = intY * Las_Data.YFactor + Las_Data.YOffset;
            this.DblZ = intZ * Las_Data.ZFactor + Las_Data.ZOffset;
        }

        /// <summary>
        /// 初始化参数
        /// </summary>
        /// <param name="xFactor"></param>
        /// <param name="xOffset"></param>
        /// <param name="yFactor"></param>
        /// <param name="yOffset"></param>
        /// <param name="zFactor"></param>
        /// <param name="zOffset"></param>
        public static void InitialParameter(double xFactor, double xOffset, double yFactor, double yOffset, double zFactor, double zOffset)
        {
            Las_Data.XFactor = xFactor;
            Las_Data.XOffset = xOffset;
            Las_Data.YFactor = yFactor;
            Las_Data.YOffset = yOffset;
            Las_Data.ZFactor = zFactor;
            Las_Data.ZOffset = zOffset;
        }
    }
}
