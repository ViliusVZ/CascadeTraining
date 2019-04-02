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
using System.Windows.Shell;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;

namespace CreateSamplesGUI
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _selectSourceBtn_Click(object sender, EventArgs e)
        {
            _sourcePathTextBox.Text = PathSelector.GetFilePath();
        }

        private void _selectOutputBtn_Click(object sender, EventArgs e)
        {
            _outputPathTextBox.Text = PathSelector.GetFilePath();
        }

        private void _createBgTxtBtn_Click(object sender, EventArgs e)
        {

            var rawPaths = PathSelector.GetAllChildPaths(_sourcePathTextBox.Text);
            var negativePaths = NegativeSampleCreator.ConvertToNegativeSamplePath(rawPaths);
            NegativeSampleCreator.CreateBgTxt(negativePaths, _outputPathTextBox.Text);
            MessageBox.Show($"bg.txt successfully created at \n {_outputPathTextBox.Text}", "Success!");
        }

        private void _cropSelectSourceBtn_Click(object sender, EventArgs e)
        {
            _cropSourcePathTextBox.Text = PathSelector.GetFilePath();
        }

        private void _cropImagesBtn_Click(object sender, EventArgs e)
        {
            var image = new Mat(@"C:\Users\viliu\Desktop\cat photos\20190321_212857.jpg");
            var point = new Point2f(image.Cols/2f,image.Rows/2f);
            if (Cv2.WaitKey(33) == 'r')
            {
                var lol = Cv2.GetRotationMatrix2D(point, 90, 1);

            }           
               

            var window = new Window("Okay", WindowMode.FreeRatio, image);

        }
    }
}
