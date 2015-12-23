using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace Lasf_Data_Processing_System
{
    public static class Cls_LasfParser
    {
        /// <summary>
        /// 获取LASF公共头
        /// </summary>
        /// <param name="binReader"></param>
        /// <param name="byteHeader"></param>
        /// <returns></returns>
        public static Las_Header GetLasfHeader(ref BinaryReader binReader, out int byteHeader)
        {
            Las_Header result = null;
            byteHeader = 0;

            byteHeader += 4;
            byte[] buf = binReader.ReadBytes(4);

            string signature = Encoding.Default.GetString(buf);
            if (signature == "LASF")
            {
                result = new Las_Header();
                result.FileSignature = "LASF";

                byteHeader += 4;
                buf = binReader.ReadBytes(4);
                result.FileSourceId = BitConverter.ToUInt16(buf, 0);
                result.GlobalEncoding = BitConverter.ToUInt16(buf, 2);

                byteHeader += 16;
                buf = binReader.ReadBytes(16);
                result.PorjectId1 = BitConverter.ToUInt32(buf, 0);
                result.ProjectId2 = BitConverter.ToUInt16(buf, 4);
                result.ProjectId3 = BitConverter.ToUInt16(buf, 6);
                result.ProjectId4 = new byte[8] { buf[8], buf[9], buf[10], buf[11], buf[12], buf[13], buf[14], buf[15] };

                byteHeader += 2;
                buf = binReader.ReadBytes(2);
                result.VersionMajor = buf[0];
                result.VersionMinor = buf[1];

                byteHeader += 32;
                buf = binReader.ReadBytes(32);
                result.SystemIdentifier = Encoding.Default.GetString(buf);

                byteHeader += 32;
                buf = binReader.ReadBytes(32);
                result.GeneratingSoftware = Encoding.Default.GetString(buf);

                byteHeader += 4;
                buf = binReader.ReadBytes(4);
                result.FileCreationDay = BitConverter.ToUInt16(buf, 0);
                result.FileCreationYear = BitConverter.ToUInt16(buf, 2);

                byteHeader += 2;
                buf = binReader.ReadBytes(2);
                result.HeaderSize = BitConverter.ToUInt16(buf, 0);

                buf = binReader.ReadBytes(result.HeaderSize - byteHeader);
                byteHeader = result.HeaderSize;

                result.OffsetToPointData = BitConverter.ToUInt32(buf, 0);
                result.NumberOfVariableLengthRecords = BitConverter.ToUInt32(buf, 4);
                result.PointDataFormatId = buf[8];
                result.PointDataRecordLength = BitConverter.ToUInt16(buf, 9);
                result.NumberOfPointRecords = BitConverter.ToUInt32(buf, 11);
                result.NumberOfPointsByReturn = new UInt32[5] { BitConverter.ToUInt32(buf, 15),
                                                                BitConverter.ToUInt32(buf, 19), 
                                                                BitConverter.ToUInt32(buf, 23),
                                                                BitConverter.ToUInt32(buf, 27), 
                                                                BitConverter.ToUInt32(buf, 31) };
                result.XScaleFactor = BitConverter.ToDouble(buf, 35);
                result.YScaleFactor = BitConverter.ToDouble(buf, 43);
                result.ZScaleFactor = BitConverter.ToDouble(buf, 51);
                result.XOffset = BitConverter.ToDouble(buf, 59);
                result.YOffset = BitConverter.ToDouble(buf, 67);
                result.ZOffset = BitConverter.ToDouble(buf, 75);
                result.MaxX = BitConverter.ToDouble(buf, 83);
                result.MinX = BitConverter.ToDouble(buf, 91);
                result.MaxY = BitConverter.ToDouble(buf, 99);
                result.MinY = BitConverter.ToDouble(buf, 107);
                result.MaxZ = BitConverter.ToDouble(buf, 115);
                result.MinZ = BitConverter.ToDouble(buf, 123);
            }
            return result;
        }

        /// <summary>
        /// 获取点数据
        /// </summary>
        /// <param name="binReader"></param>
        /// <param name="recordLength"></param>
        /// <returns></returns>
        public static Las_Data GetLasfData(ref BinaryReader binReader, ushort recordLength)
        {
            Las_Data result;
            Byte[] buf = binReader.ReadBytes(recordLength);
            int x = BitConverter.ToInt32(buf, 0);
            int y = BitConverter.ToInt32(buf, 4);
            int z = BitConverter.ToInt32(buf, 8);
            result = new Las_Data(x, y, z);
            return result;
        }


        /// <summary>
        /// 获取月份和日期
        /// </summary>
        /// <param name="dayOfYear"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        private static bool GetMonthDay(int dayOfYear, int year, out int month, out int day)
        {
            bool result = false;
            month = 0;
            day = 0;
 
            int[] monthDays; 


            if (DateTime.IsLeapYear(year))
            {
                monthDays = new int[13] {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
            }
            else
            {
                monthDays = new int[13] {0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335, 366 };
            }

            if (dayOfYear <= monthDays[0])
            {
            }
            else if (dayOfYear > monthDays[12])
            {
            }
            else
            {
                result = true;
                for (int M = 1; M < 13; M++)
                {
                    if (dayOfYear > monthDays[M - 1] && dayOfYear <= monthDays[M])
                    {
                        result = true;
                        month = M;
                        day = dayOfYear - monthDays[M - 1];
                        break;
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// 获取LASF数据记录日期
        /// </summary>
        /// <param name="fileCreationDay"></param>
        /// <param name="fileCreationYear"></param>
        /// <returns></returns>
        public static DateTime GetRecordDateTime(ushort fileCreationDay, ushort fileCreationYear)
        {
            DateTime result = new DateTime();
            int y, m, d;
            y = fileCreationYear;
            if (GetMonthDay(fileCreationDay, fileCreationYear, out m, out d))
            {
                result = new DateTime(y, m, d);
            }
            return result;
        }


        /// <summary>
        /// 导入TXT文件
        /// </summary>
        /// <param name="fileName"></param>
        public static Rec_Map InputMapByTextFile(string fileName)
        {
            Rec_Map result = null;
         
            return result;
        }

        /// <summary>
        /// 导入LASF文件
        /// </summary>
        /// <param name="fileName"></param>
        public static Rec_Map InputMapByLasfFile(string fileName)
        {
            Rec_Map result = null;
            return result;
        }

        public static void OutputRectangleData(string txtFileName, Rec_Map map)
        {
            txtFileName = txtFileName.Substring(0, txtFileName.Length - 4) + "_" +
                          map.RectangleX.ToString() + "×" + map.RectangleY.ToString() + ".txt";

            StreamWriter writer = new StreamWriter(txtFileName);


            foreach (var rec in map.Rectangle)
            {
                writer.WriteLine(rec.Key + " " + rec.Value.Z.ToString("0.00000"));

            }
            writer.Flush();
            writer.Close();
            MessageBox.Show("输出数据文件：" + txtFileName, "导入LASF文件", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        /// <summary>
        /// 导入线路数据
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Lin_Info InputLineData(string fileName)
        {
            Lin_Info result = null;
            return result;
        }


        /// <summary>
        /// 输出线路信息
        /// </summary>
        /// <param name="line"></param>
        /// <param name="fileName"></param>
        public static void OutputLineData(Lin_Info line, string fileName)
        {
 
     
        }


        /// <summary>
        /// 获取区间块的高差
        /// </summary>
        /// <param name="mapA"></param>
        /// <param name="mapB"></param>
        /// <returns></returns>
        public static Rec_Map MapDiffCalculate(Rec_Map mapA, Rec_Map mapB)
        {
            Rec_Map result = null;
            result = new Rec_Map(DateTime.Now, "", Enm_RectangleType.ELEVATION_DIFF, mapA.RectangleX, mapA.RectangleY);
            if (mapA.Type == Enm_RectangleType.ELEVATION_VALUE)
            {
                if (mapB.Type == Enm_RectangleType.ELEVATION_VALUE)
                {
                    if (mapA.RectangleX == mapB.RectangleX && mapA.RectangleY == mapB.RectangleY)
                    {

                        foreach (var recA in mapA.Rectangle)
                        {
                            double xA = recA.Value.X;
                            double yA = recA.Value.Y;
                            double zA = recA.Value.Z;
                            double zDiff = zA;


                            foreach (var recB in mapB.Rectangle)
                            {

                                double xB = recB.Value.X;
                                double yB = recB.Value.Y;
                                double zB = recB.Value.Z;

                                if (xA == xB && yA == yB)
                                {
                                    zDiff -= zB;
                                    break;
                                }
                            }
                            result.Rectangle.Add(xA.ToString("0.000") + " " + yA.ToString("0.000"), new Rec_Unit(result, xA, yA, zDiff, 1));
                        }
                    }
                    else
                    {
                        MessageBox.Show("未执行！地图1和地图2网络大小不同。", "计算高差", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
                else
                {
                    MessageBox.Show("未执行！地图2非高程类型。", "计算高差", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("未执行！地图1非高程类型。", "计算高差", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }



    
    }
}
