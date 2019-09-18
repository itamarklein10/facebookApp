using System.Drawing;

namespace project1.Strategy
{
    internal class BmpStrategy : IImageSaveStrategy
    {
        public void SaveImage(Image image, string fileName)
        {
            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
