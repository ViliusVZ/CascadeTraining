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
            _cropOutputPathTextBox.GotFocus += OnTextFocus;
            _cropOutputPathTextBox.LostFocus += OnTextUnfocus;
        }

        private void OnTextUnfocus(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = _cueText;
            }
        }

        private string _cueText = "Select output path...";
        private void OnTextFocus(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text == _cueText)
            {
                textBox.Clear();
            }
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
            var cropperForm = new ImageCropper(_cropSourcePathTextBox.Text, _cropOutputPathTextBox.Text);
            cropperForm.ShowDialog();
        }
    }
}
