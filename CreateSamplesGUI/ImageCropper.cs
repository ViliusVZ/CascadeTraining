using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateSamplesGUI
{
    public partial class ImageCropper : Form
    {
        public List<string> ImagesToCrop { get; set; }
        public string OriginalImage { get; set; }
        public Rectangle _selectorRectangle { get; set; }
        private string _outputDirectory { get; set; }
        private const int _frameWidth = 1000;

        public ImageCropper(string originalImagePath, string outputDirectory)
        {
            InitializeComponent();
            OriginalImage = originalImagePath;
            _outputDirectory = outputDirectory;
            var image = ImageCropperHelper.GetScaledPicture(OriginalImage, _frameWidth, _frameWidth);
            this.Width = _frameWidth + 16;
            this.Height = _frameWidth + 39;
            _cropperPictureBox.Width = _frameWidth;
            _cropperPictureBox.Height = _frameWidth;
            _cropperPictureBox.Image = image;
            Refresh();
        }

        private void ImageCropper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                _cropperPictureBox.Image = (Bitmap)ImageCropperHelper.RotateImage(_cropperPictureBox.Image);
                GC.Collect();
            }
            if (e.KeyCode == Keys.S)
            {
                var image = _cropperPictureBox.Image;
                //int offsetX = (_cropperPictureBox.Width - _cropperPictureBox.Image.Width) / 2;
                //int offsetY = (_cropperPictureBox.Height - _cropperPictureBox.Image.Height) / 2;
                var diff = _cropperPictureBox.Image.Width - _cropperPictureBox.Image.Height;
                var location =
                    diff > 0
                        ? new Point(_selectorRectangle.X, _selectorRectangle.Y - diff / 2)
                        : new Point(_selectorRectangle.X + diff / 2, _selectorRectangle.Y);
                var area = new Rectangle(location, _selectorRectangle.Size);
                try
                {
                    using (var croppedImage = ((Bitmap)image).Clone(area, image.PixelFormat))
                    {
                        var path = Path.Combine(_outputDirectory, "1.png");
                        croppedImage?.Save(path);
                    }
                }
                catch { }
                GC.Collect();
            }
        }

        private void _cropperPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _selectorRectangle = new Rectangle(e.X, e.Y, 0, 0);
            _cropperPictureBox.Invalidate();
        }

        private void _cropperPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _selectorRectangle = new Rectangle(_selectorRectangle.Left, _selectorRectangle.Top, e.X - _selectorRectangle.Left, e.Y - _selectorRectangle.Top);
            }
            _cropperPictureBox.Invalidate();
        }

        private void _cropperPictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, _selectorRectangle);
            }
        }
    }
}
