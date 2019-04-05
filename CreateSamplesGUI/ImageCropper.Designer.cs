namespace CreateSamplesGUI
{
    partial class ImageCropper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cropperPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._cropperPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _cropperPictureBox
            // 
            this._cropperPictureBox.BackColor = System.Drawing.Color.Black;
            this._cropperPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cropperPictureBox.Location = new System.Drawing.Point(0, 0);
            this._cropperPictureBox.Name = "_cropperPictureBox";
            this._cropperPictureBox.Size = new System.Drawing.Size(1240, 790);
            this._cropperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._cropperPictureBox.TabIndex = 0;
            this._cropperPictureBox.TabStop = false;
            this._cropperPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this._cropperPictureBox_Paint);
            this._cropperPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._cropperPictureBox_MouseDown);
            this._cropperPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this._cropperPictureBox_MouseMove);
            // 
            // ImageCropper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 790);
            this.Controls.Add(this._cropperPictureBox);
            this.Name = "ImageCropper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCropper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageCropper_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this._cropperPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox _cropperPictureBox;
    }
}