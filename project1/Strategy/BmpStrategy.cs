using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace project1.Strategy
{
    internal class BmpStrategy: IImageSaveStrategy
    {
        public void SaveImage(Image image, string fileName)
        {
            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
