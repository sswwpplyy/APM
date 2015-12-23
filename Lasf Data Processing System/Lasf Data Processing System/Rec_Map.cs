using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Rec_Map
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public DateTime RecordDate;                             //数据记录日期
        public string MapId;                                    //数据库中的Id

        public Enm_RectangleType Type;                          //地图类型:高程/高差
        public double RectangleX;                               //X长度
        public double RectangleY;                               //Y长度
        public Dictionary<string, Rec_Unit> Rectangle;          //矩形元素
        public string MinPos;                                   //最小坐标(右上角)
        
        
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="recordDate"></param>
        /// <param name="mapId"></param>
        /// <param name="type"></param>
        /// <param name="rectangleX"></param>
        /// <param name="rectangleY"></param>
        public  Rec_Map(DateTime recordDate, string mapId, Enm_RectangleType type, double rectangleX, double rectangleY)
        {
            this.RecordDate = recordDate;
            this.MapId = mapId;
            this.Type = type;
            this.RectangleX = rectangleX;
            this.RectangleY = rectangleY;
            this.Rectangle = new Dictionary<string, Rec_Unit>();
            this.MinPos = "_";
        }

        /// <summary>
        /// 根据XY网格调整原XY坐标
        /// </summary>
        /// <param name="xAdj"></param>
        /// <param name="yAdj"></param>
        public void AdjustAxis(ref double xAdj, ref double yAdj)
        {
            if (this.RectangleX != 0)
            {
                xAdj = (int)(xAdj / this.RectangleX) * this.RectangleX;
            }
            if (this.RectangleY != 0)
            {
                yAdj = (int)(yAdj / this.RectangleY) * this.RectangleY;
            }
        }


        /// <summary>
        /// 合并一个LASF数据
        /// </summary>
        /// <param name="data"></param>
        public void MergeLasfData(Las_Data data)
        {
            double xAdj, yAdj, zAdj;

            xAdj = data.DblX;
            yAdj = data.DblY;
            zAdj = data.DblZ;

            this.AdjustAxis(ref xAdj, ref yAdj);
            string axes = xAdj.ToString("0.000") + " " + yAdj.ToString("0.000");


            if (this.Rectangle.ContainsKey(axes))
            {
                this.Rectangle[axes].AppendPoint(zAdj);
            }
            else
            {
                this.Rectangle.Add(axes, new Rec_Unit(this, xAdj, yAdj, zAdj, 1));

                //更新最小坐标
                if (this.MinPos != "_")
                {
                    double minX = double.Parse(this.MinPos.Split('_')[0]);
                    double minY = double.Parse(this.MinPos.Split('_')[1]);

                    if (xAdj < minX && yAdj < minY)
                    {
                        this.MinPos = xAdj.ToString("0.000") + "_" + yAdj.ToString("0.000");
                    }
                }
                else
                {
                    this.MinPos = xAdj.ToString("0.000") + "_" + yAdj.ToString("0.000");
                }
            }
        }
    

    }

    /// <summary>
    /// 矩形地图类型枚举
    /// </summary>
    public enum Enm_RectangleType
    {
        ELEVATION_VALUE,    //高程
        ELEVATION_DIFF      //高差
    }
}
