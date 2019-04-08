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
        private List<string> _imagesToCrop { get; set; }
        private string _outputDirectory { get; set; }
        private Rectangle _selectorRectangle { get; set; }
        private const int _frameWidth = 800;
        public string OriginalImage { get; set; }

        public ImageCropper(string originalImagePath, string outputDirectory, List<string> imagesToCrop)
        {
            InitializeComponent();

            _imagesToCrop = imagesToCrop;
            _outputDirectory = outputDirectory;

            this.Width = _frameWidth + 16;
            this.Height = _frameWidth + 39;

            _cropperPictureBox.Width = _frameWidth;
            _cropperPictureBox.Height = _frameWidth;

            foreach (var imageToCrop in imagesToCrop)
            {

            }

            OriginalImage = originalImagePath;

            var image = ImageCropperHelper.GetScaledPicture(OriginalImage, _frameWidth, _frameWidth);
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
