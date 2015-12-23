using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Rec_Unit
    {
         /// <summary>
        /// 全局变量
        /// </summary>
        public Rec_Map Map;                 //所属地图指针
        public double X;                    //X坐标
        public double Y;                    //Y坐标
        public double Z;                    //Z高程或高差
        public int ZCount;                  //Z元素个数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="map"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="zCount"></param>
        public Rec_Unit(Rec_Map map, double x, double y, double z, int zCount)
        {
            this.Map = map;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.ZCount = zCount;
        }

        /// <summary>
        /// 增加一个Z元素
        /// </summary>
        /// <param name="z"></param>
        public void AppendPoint(double z)
        {
            this.Z = (this.Z * this.ZCount + z) / (this.ZCount + 1);
            this.ZCount++;
        }

        /// <summary>
        /// 获取矩形单元的中心坐标
        /// </summary>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        public void GetCenterPos(out double pX, out double pY)
        {
            pX = this.X + this.Map.RectangleX / 2;
            pY = this.Y + this.Map.RectangleY / 2;
        }

    }
}
