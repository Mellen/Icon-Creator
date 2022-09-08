using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ImageToIcon
{
    public class IconGenerator
    {
        public static MemoryStream GenerateIconStreamFromBitmap(Bitmap image)
        {
            MemoryStream msBitmap = new MemoryStream();
            image.Save(msBitmap, System.Drawing.Imaging.ImageFormat.Png);
            int bitmapByteCount = (int)msBitmap.Length;
            MemoryStream msIcon = new MemoryStream();
            msIcon.Write(new byte[] { 0, 0, 1, 0, 1, 0 }, 0, 6);
            ushort bitCount = 32;
            switch(image.PixelFormat)
            {
                case System.Drawing.Imaging.PixelFormat.Format16bppRgb565:
                case System.Drawing.Imaging.PixelFormat.Format16bppRgb555:
                case System.Drawing.Imaging.PixelFormat.Format16bppGrayScale:
                case System.Drawing.Imaging.PixelFormat.Format16bppArgb1555:
                    bitCount = 16;
                    break;
                case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                    bitCount = 24;
                    break;
                case System.Drawing.Imaging.PixelFormat.Format48bppRgb:
                    bitCount = 48;
                    break;
                case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
                    bitCount = 64;
                    break;
            }

            byte[] bitCountBytes = BitConverter.GetBytes(bitCount);
            byte[] imageSizeBytes = BitConverter.GetBytes(bitmapByteCount);

            msIcon.Write(new byte[] { (byte)image.Width,
                                      (byte)image.Height,
                                      0,
                                      0,
                                      0, 0}, 0, 6);
            msIcon.Write(bitCountBytes, 0, bitCountBytes.Length);
            msIcon.Write(imageSizeBytes, 0, imageSizeBytes.Length);
            msIcon.Write(new byte[] { (byte)(6+6+bitCountBytes.Length+imageSizeBytes.Length+4),0,0,0,0 }, 0, 4);

            msIcon.Write(msBitmap.ToArray(), 0, bitmapByteCount);

            return msIcon;
        }
    }
}
