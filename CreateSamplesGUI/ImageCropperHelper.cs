using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateSamplesGUI
{
    public static class ImageCropperHelper
    {
        /// <summary>
        /// Rotates image from it's center by specific angle.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="rotationAngle"></param>
        /// <returns></returns>
        public static Image RotateImage(Image image)
        {
            var bitmap = new Bitmap(image);

            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(image, 0, 0, image.Width, image.Height);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bitmap;
        }

        /// <summary>
        /// Makes sure that image displayed in the pictureBox always keeps it's aspect ratio.
        /// </summary>
        /// <param name="imagePath">Path to image.</param>
        /// <param name="pictureBoxHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        /// <returns></returns>
        public static Image GetScaledPicture(string imagePath, float pictureBoxHeight, float pictureBoxWidth)
        {
            var picture = new Bitmap(@imagePath);

            float scaleHeight = pictureBoxHeight / picture.Height;
            float scaleWidth = pictureBoxWidth / picture.Width;
            float scale = Math.Min(scaleHeight, scaleWidth);
            var resizedImage = new Bitmap(picture, (int)(picture.Width * scale), (int)(picture.Height * scale));

            return resizedImage;
        }

        /// <summary>
        /// Makes sure that image displayed in the pictureBox always keeps it's aspect ratio.
        /// </summary>
        /// <param name="image">Image to scaled.</param>
        /// <param name="pictureBoxHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        /// <returns></returns>
        public static Image GetScaledPicture(Image image, float pictureBoxHeight, float pictureBoxWidth)
        {
            float scaleHeight = pictureBoxHeight / image.Height;
            float scaleWidth = pictureBoxWidth / image.Width;
            float scale = Math.Min(scaleHeight, scaleWidth);
            var resizedImage = new Bitmap(image, (int)(image.Width * scale), (int)(image.Height * scale));

            return resizedImage;
        }

        /// <summary>
        /// Clones image from selected rectangle.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="selectedRectangle"></param>
        /// <returns></returns>
        public static Image CloneRectangle(Image image, Rectangle selectedRectangle)
        {
            var format = image.PixelFormat;
            return ((Bitmap)image).Clone(selectedRectangle, format);
        }

        /// <summary>
        /// Saves cloned rectangle to specified path.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="outputPath"></param>
        public static void SaveImage(Bitmap image, string outputPath, int iterationNumber)
        {
            if (image != null)
            {
                var filename = Path.Combine(outputPath, $@"{iterationNumber}.png");
                image.Save(filename);
            }
        }
    }
}
