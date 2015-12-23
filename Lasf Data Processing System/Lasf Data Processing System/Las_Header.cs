using System;
using System.Collections.Generic;
using System.Text;

namespace Lasf_Data_Processing_System
{
    public class Las_Header
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public string FileSignature;
        public ushort FileSourceId;
        public ushort GlobalEncoding;
        public uint PorjectId1;
        public ushort ProjectId2;
        public ushort ProjectId3;
        public byte[] ProjectId4;
        public byte VersionMajor;
        public byte VersionMinor;
        public string SystemIdentifier;
        public string GeneratingSoftware;
        public ushort FileCreationDay;
        public ushort FileCreationYear;
        public ushort HeaderSize;
        public uint OffsetToPointData;
        public uint NumberOfVariableLengthRecords;
        public byte PointDataFormatId;
        public ushort PointDataRecordLength;
        public uint NumberOfPointRecords;
        public uint[] NumberOfPointsByReturn;
        public double XScaleFactor;
        public double YScaleFactor;
        public double ZScaleFactor;
        public double XOffset;
        public double YOffset;
        public double ZOffset;
        public double MaxX;
        public double MinX;
        public double MaxY;
        public double MinY;
        public double MaxZ;
        public double MinZ;
        public ulong StartOfWaveformDataPacketRecord;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Las_Header()
        {
        }
    }
}
