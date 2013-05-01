using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace Steganography
{
    public class BitmapSteganography
    {
        #region Static Methods

        public static void ExtractDataFromBitmap(string bitmapFile, string dataFile, int hideLevel)
        {
            FileStream fr = null;
            FileStream fd = null;

            try
            {
                if (8 % hideLevel != 0)
                    throw new Exception("Hide Level should be a divisor of 8");

                int byteRepeat = 8 / hideLevel;

                if (File.Exists(dataFile))
                    File.Delete(dataFile);

                fr = File.OpenRead(bitmapFile);
                fd = File.OpenWrite(dataFile);

                byte[] header = new byte[14];
                fr.Read(header, 0, 14);

                int databaslangic = 0;
                for (int i = 10; i < 14; i++)
                    databaslangic += ((int)header[i]) * (1 << (8 * (i - 10)));
                databaslangic -= 14;

                byte[] buffer = new byte[1024];
                fr.Read(buffer, 0, databaslangic);

                int tmpdata, part, datalen = 0;
                // Extract total file size from hidden bitmap.
                // Recover 4-bytes as 32-bit integer.
                for (int i = 0; i < 4 * byteRepeat; i++)
                {
                    // Recover Last hidelevel-bit
                    part = fr.ReadByte() & ~(0xFF << hideLevel);
                    // Add partial bit data to the datalen variable.
                    datalen |= part << (hideLevel * i);
                }

                // Recover every byte of data from byteRepeat bytes of input bitmap
                for (int i = 0; i < datalen; i++)
                {
                    tmpdata = 0;
                    // Combine LSB hideLevel-bits into a byte
                    for (int j = 0; j < byteRepeat; j++)
                    {
                        // Recover Last hidelevel-bit
                        part = fr.ReadByte();
                        if (part < 0)
                        {
                            fr.Close();
                            fd.Close();
                            throw new Exception("There was an error! Probably hide level is selected wrong.");
                        }
                        part &= ~(0xFF << hideLevel);
                        tmpdata |= part << (hideLevel * j);
                    }
                    // Write the recovered byte
                    fd.WriteByte((byte)tmpdata);
                }

                // Close files.
                fr.Close();
                fd.Close();

            }
            catch (Exception exp)
            {
                fr.Close();
                fd.Close();
                throw exp;
            }


        }

        public static void HideDataInBitmap(string bitmapFile, string outputFile, string dataFile, int hideLevel)
        {
            // Only 1, 2, 4 and 8 are accepted as hide level.
            // 8 means embed file fully into a byte which means totally destruction of the bitmap.
            if (8 % hideLevel != 0)
                throw new Exception("Hide Level should be a divisor of 8");

            // Every data byte will be represented by byteRepeat bytes in bitmap.
            int byteRepeat = 8 / hideLevel;

            if (File.Exists(outputFile))
                File.Delete(outputFile);

            FileStream fr = File.OpenRead(bitmapFile);
            FileStream fw = File.OpenWrite(outputFile);
            FileStream fd = File.OpenRead(dataFile);

            // Read BMP bitmap header and copy to the output.
            byte[] header = new byte[14];
            fr.Read(header, 0, 14);
            fw.Write(header, 0, 14);

            // Extract the start offset of the bitmap data from header
            int databaslangic = 0;
            for (int i = 10; i < 14; i++)
                databaslangic += ((int)header[i]) * (1 << (8 * (i - 10)));
            databaslangic -= 14;

            // Copy everyting upto bitmap data start offset
            byte[] buffer = new byte[1024];
            fr.Read(buffer, 0, databaslangic);
            fw.Write(buffer, 0, databaslangic);

            // Find number of free bytes in input bitmap to modify.
            int outputlen = (int)fr.Length - databaslangic - header.Length;
            // Find size of the data which will be hidden into the bitmap
            int datalen = (int)fd.Length;
            // Check if there is enough space in the bitmap for data bytes.
            if ((datalen * 8) + 32 > outputlen * hideLevel)
            {
                fr.Close();
                fw.Close();
                fd.Close();
                if (File.Exists(outputFile))
                    File.Delete(outputFile);
                throw new Exception(string.Format("Data is bigger than the hiding place!\nMaximum size to hide is {0} bytes for the selected bitmap!", (outputlen * hideLevel / 8) - 4));
            }

            int tmp, tmpdata;

            // Hide the size of data file as 4 bytes into bitmap file
            byte[] data_len = BitConverter.GetBytes(datalen);

            for (int i = 0; i < 4; i++)
            {
                // Put every byte in to byteRepeat chunks where length is hideLevel-bits.
                int part = 0;
                for (int j = 0; j < byteRepeat; j++)
                {
                    // Recover hideLevel-bits of byte
                    part = (data_len[i] >> (j * hideLevel)) & ~(0xFF << hideLevel);
                    //Debug.WriteLine(string.Format("{0},{1}: {2}",i,j,part));
                    tmp = fr.ReadByte();
                    // Replace LSB hideLevel-bits with the data and write to bitmap. 
                    fw.WriteByte((byte)((tmp & (0xFF << hideLevel)) | part));
                }
            }

            // While we have data to read
            tmpdata = fd.ReadByte();
            while (tmpdata > -1)
            {
                int part = 0;
                for (int j = 0; j < byteRepeat; j++)
                {
                    part = (tmpdata >> (j * hideLevel)) & ~(0xFF << hideLevel);
                    tmp = fr.ReadByte();
                    fw.WriteByte((byte)((tmp & (0xFF << hideLevel)) | part));
                }
                tmpdata = fd.ReadByte();
            }

            // Copy rest of the bitmap
            tmp = fr.ReadByte();
            while (tmp > -1)
            {
                fw.WriteByte((byte)tmp);
                tmp = fr.ReadByte();
            }

            // Close files
            fr.Close();
            fw.Close();
            fd.Close();
        }

        public static void ToggleMSBInBitmap(string bitmapFile, string outputFile)
        {
            if (File.Exists(outputFile))
                File.Delete(outputFile);

            FileStream fr = File.OpenRead(bitmapFile);
            FileStream fw = File.OpenWrite(outputFile);

            // Read BMP bitmap header and copy to the output.
            byte[] header = new byte[14];
            fr.Read(header, 0, 14);
            fw.Write(header, 0, 14);

            // Extract the start offset of the bitmap data from header
            int databaslangic = 0;
            for (int i = 10; i < 14; i++)
                databaslangic += ((int)header[i]) * (1 << (8 * (i - 10)));
            databaslangic -= 14;

            // Copy everyting upto bitmap data start offset
            byte[] buffer = new byte[1024];
            fr.Read(buffer, 0, databaslangic);
            fw.Write(buffer, 0, databaslangic);

            // Copy rest of the bitmap data with modification
            int tmp = fr.ReadByte();
            while (tmp > -1)
            {
                fw.WriteByte((byte)(tmp ^ 0x80));
                tmp = fr.ReadByte();
            }

            // Close files
            fr.Close();
            fw.Close();
        }

        public static void ToggleLSBInBitmap(string bitmapFile, string outputFile)
        {
            if (File.Exists(outputFile))
                File.Delete(outputFile);

            FileStream fr = File.OpenRead(bitmapFile);
            FileStream fw = File.OpenWrite(outputFile);

            // Read BMP bitmap header and copy to the output.
            byte[] header = new byte[14];
            fr.Read(header, 0, 14);
            fw.Write(header, 0, 14);

            // Extract the start offset of the bitmap data from header
            int databaslangic = 0;
            for (int i = 10; i < 14; i++)
                databaslangic += ((int)header[i]) * (1 << (8 * (i - 10)));
            databaslangic -= 14;

            // Copy everyting upto bitmap data start offset
            byte[] buffer = new byte[1024];
            fr.Read(buffer, 0, databaslangic);
            fw.Write(buffer, 0, databaslangic);

            // Copy rest of the bitmap data with modification
            int tmp = fr.ReadByte();
            while (tmp > -1)
            {
                fw.WriteByte((byte)(tmp ^ 0x01));
                tmp = fr.ReadByte();
            }

            // Close files
            fr.Close();
            fw.Close();
        }

        #endregion
    }
}
