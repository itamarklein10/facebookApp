using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace project1.Strategy
{
    internal interface IImageSaveStrategy
    {
        void SaveImage(Image image, string fileName);
    }
}
