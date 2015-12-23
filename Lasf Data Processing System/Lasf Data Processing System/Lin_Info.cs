using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Lin_Info
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public string LineName;                 //线路:"轨交16号线"
        public string Interval;                 //区间,以"~"分割起始站点名:"书院~惠南东"
        public List<Lin_Pos> LinePos;           //坐标点集合
        public double Mileage;                  //里程
        public string DbName;                   //数据库名
  

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="lineName"></param>
        /// <param name="interval"></param>
        public Lin_Info(string lineName, string interval)
        {
            this.LineName = lineName;
            this.Interval = interval;
            this.LinePos = new List<Lin_Pos>();
            this.Mileage = 0;
            this.DbName = "";
        }

        /// <summary>
        /// 增加一个坐标
        /// </summary>
        /// <param name="pos"></param>
        public void AppendPos(Lin_Pos pos)
        {
            //同时更新线路里程
            if (this.LinePos.Count == 0)
            {
                this.Mileage = 0;
            }
            else
            {
                double x = this.LinePos[this.LinePos.Count - 1].X - pos.X;
                double y = this.LinePos[this.LinePos.Count - 1].Y - pos.Y;
                double z = Math.Sqrt(x * x + y * y);
                this.Mileage += z;
            }
            this.LinePos.Add(pos);
        }

        /// <summary>
        /// 增加一组坐标
        /// </summary>
        /// <param name="pos"></param>
        public void AppendPos(List<Lin_Pos> pos)
        {
            for (int P = 0; P < pos.Count; P++)
            {
                this.AppendPos(pos[P]);
            }
        }


        /// <summary>
        /// 获取线路里程
        /// </summary>
        public void GetMileage()
        {
            this.Mileage = 0;
            for (int P = 0; P < this.LinePos.Count - 1; P++)
            {
                double x = this.LinePos[P].X - this.LinePos[P + 1].X;
                double y = this.LinePos[P].Y - this.LinePos[P + 1].Y;
                double z = Math.Sqrt(x * x + y * y);
                this.Mileage += z;
            }
        }


        /// <summary>
        /// 监测矩形是否在线路的指定距离范围内
        /// </summary>
        /// <param name="line"></param>
        /// <param name="rectangle"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static bool CheckInRange(Lin_Info line, Rec_Unit rectangle, double range)
        {
            bool result = false;

            for (int I = 0; I < line.LinePos.Count; I++)
            {
                if (Math.Abs(line.LinePos[I].X - rectangle.X) <= range && Math.Abs(line.LinePos[I].Y - rectangle.Y) <= range)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }



        public static bool CheckInRange(Lin_Info line, Rec_Unit rectangle, double range, out double mileage)
        {
            bool result = false;
            mileage = 0;

            double rX = rectangle.X;
            double rY = rectangle.Y;


            for (int I = 0; I < line.LinePos.Count - 1; I++)
            {
                double aX = line.LinePos[I].X;
                double aY = line.LinePos[I].Y;

                double bX = line.LinePos[I + 1].X;
                double bY = line.LinePos[I + 1].Y;





            }



            return result;
        }




    }
}
