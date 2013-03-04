﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.IO.Writing;

namespace EvilDICOM.Core.IO.Data
{
    public class LittleEndianWriter
    {
        public static byte[] WriteTag(Tag tag)
        {
            //TODO modify to make VM > 1 possible
            return MultiplicityComposer.ComposeMultipleBinary<Tag>(new Tag[]{tag}, WriteTagSingle);
        }

        public static byte[] WriteSinglePrecision(float[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<float>(data, WriteSinglePrecisionSingle);
        }

        public static byte[] WriteDoublePrecision(double[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<double>(data, WriteDoublePrecisionSingle);
        }

        public static byte[] WriteSignedLong(int[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<int>(data, WriteSignedLongSingle);
        }

        public static byte[] WriteUnsignedLong(uint[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<uint>(data, WriteUnsignedLongSingle);
        }

        public static byte[] WriteSignedShort(short[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<short>(data, WriteSignedShortSingle);
        }

        public static byte[] WriteUnsignedShort(ushort[] data)
        {
            return MultiplicityComposer.ComposeMultipleBinary<ushort>(data, WriteUnsignedShortSingle);
        }

        //Writes a single data element (VM = 1)
        #region SINGLE WRITERS
        public static byte[] WriteTagSingle(Tag tag)
        {
            return DICOMTagWriter.WriteLittleEndian(tag);
        }

        public static byte[] WriteSinglePrecisionSingle(float data)
        {
            return BitConverter.GetBytes(data);
        }

        public static byte[] WriteDoublePrecisionSingle(double data)
        {
            return BitConverter.GetBytes(data);
        }

        public static byte[] WriteSignedLongSingle(int data)
        {
            return BitConverter.GetBytes(data);
        }

        public static byte[] WriteUnsignedLongSingle(uint data)
        {
            return BitConverter.GetBytes(data);
        }

        public static byte[] WriteSignedShortSingle(short data)
        {
            return BitConverter.GetBytes(data);
        }

        public static byte[] WriteUnsignedShortSingle(ushort data)
        {
            return BitConverter.GetBytes(data);
        }
        #endregion
    }
}
