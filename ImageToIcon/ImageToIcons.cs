﻿using System.Drawing;
using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

namespace ImageToIcon
{
    public class ImageToIcons
    {
        private readonly Bitmap _backingImage;
        private readonly string _filename;
        private Icon _icon16;
        private Icon _icon24;
        private Icon _icon32;
        private Icon _icon48;
        private Icon _icon64;
        private Icon _icon128;
        private Icon _icon256;

        public Bitmap BackingImage
        {
            get { return _backingImage; }
        }

        public Icon Icon16
        {
            get
            {
                if (_icon16 == null)
                {
                    _icon16 = GenerateIcon(16, 16);
                }
                return _icon16;
            }
        }

        public Icon Icon24
        {
            get
            {
                if (_icon24 == null)
                {
                    _icon24 = GenerateIcon(24, 24);
                }
                return _icon24;
            }
        }
        
        public Icon Icon32
        {
            get
            {
                if (_icon32 == null)
                {
                    _icon32 = GenerateIcon(32, 32);
                }
                return _icon32;
            }
        }

        public Icon Icon48
        {
            get
            {
                if (_icon48 == null)
                {
                    _icon48 = GenerateIcon(48, 48);
                }
                return _icon48;
            }
        }

        public Icon Icon64
        {
            get
            {
                if (_icon64 == null)
                {
                    _icon64 = GenerateIcon(64, 64);
                }
                return _icon64;
            }
        }

        public Icon Icon128
        {
            get
            {
                if (_icon128 == null)
                {
                    _icon128 = GenerateIcon(128, 128);
                }
                return _icon128;
            }
        }

        public Icon Icon256
        {
            get
            {
                if (_icon256 == null)
                {
                    _icon256 = GenerateIcon(256, 256);
                }
                return _icon256;
            }
        }

        public Icon GetIconBySize(int size)
        {
            Icon icon = Icon64;
            switch(size)
            {
                case 16:
                    icon = Icon16;
                    break;
                case 24:
                    icon = Icon24;
                    break;
                case 32:
                    icon = Icon32;
                    break;
                case 48:
                    icon = Icon48;
                    break;
                case 64:
                    icon = Icon64;
                    break;
                case 128:
                    icon = Icon128;
                    break;
                case 256:
                    icon = Icon256;
                    break;
                default:
                    icon = Icon64;
                    break;
            }

            return icon;
        }

        private Icon GenerateIcon(int width, int height)
        {
            Icon result = null;
            
            using (Bitmap icon = _backingImage.GetThumbnailImage(width, height, () => false, System.IntPtr.Zero) as Bitmap)
            {
                MemoryStream iconStream = IconGenerator.GenerateIconStreamFromBitmap(icon);

                iconStream.Seek(0, SeekOrigin.Begin);

                result = new Icon(iconStream);

                iconStream.Close();
            }

            return result;
        }

        public void Save(string filename, bool use16 = true, bool use24 = true, bool use32 = true, bool use48 = true, bool use64 = true, bool use128 = true, bool use256 = true)
        {
            List<Bitmap> imagesToAdd = new List<Bitmap>();

            if(use16)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(16, 16, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use24)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(24, 24, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use32)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(32, 32, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use48)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(48, 48, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use64)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(64, 64, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use128)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(128, 128, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (use256)
            {
                Bitmap icon = _backingImage.GetThumbnailImage(256, 256, () => false, IntPtr.Zero) as Bitmap;
                imagesToAdd.Add(icon);
            }

            if (imagesToAdd.Count > 0)
            {
                MemoryStream iconStream = IconGenerator.GenerateIconStreamFromMultipleBitmaps(imagesToAdd.ToArray());
                File.WriteAllBytes(filename, iconStream.ToArray());
            }
        }

        public ImageToIcons(string imagePath)
        {
            _backingImage = new Bitmap(imagePath, false);
            _filename = imagePath;

        }

        public override string ToString()
        {
            FileInfo fi = new FileInfo(_filename);
            return fi.Name;
        }

    }
}
