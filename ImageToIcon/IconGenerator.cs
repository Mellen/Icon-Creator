using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Diagnostics;
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

            AddIconDirEntryToHeader(msIcon, image, 22);

            msIcon.Write(msBitmap.ToArray(), 0, bitmapByteCount);

            msBitmap.Close();

            return msIcon;
        }

        private static ushort GetImageBitCount(Bitmap image)
        {
            ushort bitCount = 32;
            switch (image.PixelFormat)
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

            return bitCount;
        }

        private static int AddIconDirEntryToHeader(MemoryStream stream, Bitmap image, int imageOffset)
        {
            using (MemoryStream msBitmap = new MemoryStream())
            {
                image.Save(msBitmap, System.Drawing.Imaging.ImageFormat.Png);

                int bitmapByteCount = (int)msBitmap.Length;
                ushort bitCount = GetImageBitCount(image);
                byte[] bitCountBytes = BitConverter.GetBytes(bitCount);
                byte[] imageSizeBytes = BitConverter.GetBytes(bitmapByteCount);
                byte[] imageOffsetBytes = BitConverter.GetBytes(imageOffset);

                stream.Write(new byte[] { (byte)image.Width,
                                      (byte)image.Height,
                                      0,
                                      0,
                                      0, 0}, 0, 6);
                stream.Write(bitCountBytes, 0, bitCountBytes.Length);
                stream.Write(imageSizeBytes, 0, imageSizeBytes.Length);
                stream.Write(imageOffsetBytes, 0, imageOffsetBytes.Length);

                imageOffset += bitmapByteCount;
            }

            return imageOffset;
        }

        public static MemoryStream GenerateIconStreamFromMultipleBitmaps(Bitmap[] images)
        {
            Debug.Assert(images.Length > 0);
            Debug.Assert(images.Length < 8);
            MemoryStream msIcon = new MemoryStream();
            msIcon.Write(new byte[] { 0, 0, 1, 0, (byte)images.Length, 0 }, 0, 6);
            int headerSize = 6 + 16*images.Length;
            int imageOffset = headerSize;

            foreach(Bitmap image in images)
            {
                imageOffset = AddIconDirEntryToHeader(msIcon, image, imageOffset);
            }

            foreach (Bitmap image in images)
            {
                using (MemoryStream msBitmap = new MemoryStream())
                {
                    image.Save(msBitmap, System.Drawing.Imaging.ImageFormat.Png);
                    int bitmapByteCount = (int)msBitmap.Length;

                    msIcon.Write(msBitmap.ToArray(), 0, bitmapByteCount);
                }
            }

            return msIcon;
        }
    }
}
