namespace CreateSamplesGUI
{
    partial class MainForm
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
            this._selectSourceBtn = new System.Windows.Forms.Button();
            this._selectOutputBtn = new System.Windows.Forms.Button();
            this._sourcePathTextBox = new System.Windows.Forms.TextBox();
            this._selectedSourceLabel = new System.Windows.Forms.Label();
            this._selectedOutputLabel = new System.Windows.Forms.Label();
            this._outputPathTextBox = new System.Windows.Forms.TextBox();
            this._createBgTxtBtn = new System.Windows.Forms.Button();
            this._negSamplesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cropSourcePathTextBox = new System.Windows.Forms.TextBox();
            this._cropSelectSourceBtn = new System.Windows.Forms.Button();
            this._cropImagesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _selectSourceBtn
            // 
            this._selectSourceBtn.Location = new System.Drawing.Point(12, 36);
            this._selectSourceBtn.Name = "_selectSourceBtn";
            this._selectSourceBtn.Size = new System.Drawing.Size(162, 44);
            this._selectSourceBtn.TabIndex = 0;
            this._selectSourceBtn.Text = "Select source";
            this._selectSourceBtn.UseVisualStyleBackColor = true;
            this._selectSourceBtn.Click += new System.EventHandler(this._selectSourceBtn_Click);
            // 
            // _selectOutputBtn
            // 
            this._selectOutputBtn.Location = new System.Drawing.Point(180, 36);
            this._selectOutputBtn.Name = "_selectOutputBtn";
            this._selectOutputBtn.Size = new System.Drawing.Size(162, 44);
            this._selectOutputBtn.TabIndex = 0;
            this._selectOutputBtn.Text = "Select output";
            this._selectOutputBtn.UseVisualStyleBackColor = true;
            this._selectOutputBtn.Click += new System.EventHandler(this._selectOutputBtn_Click);
            // 
            // _sourcePathTextBox
            // 
            this._sourcePathTextBox.Location = new System.Drawing.Point(12, 99);
            this._sourcePathTextBox.Name = "_sourcePathTextBox";
            this._sourcePathTextBox.Size = new System.Drawing.Size(330, 20);
            this._sourcePathTextBox.TabIndex = 1;
            this._sourcePathTextBox.Text = "Select source path...";
            // 
            // _selectedSourceLabel
            // 
            this._selectedSourceLabel.AutoSize = true;
            this._selectedSourceLabel.Location = new System.Drawing.Point(13, 83);
            this._selectedSourceLabel.Name = "_selectedSourceLabel";
            this._selectedSourceLabel.Size = new System.Drawing.Size(108, 13);
            this._selectedSourceLabel.TabIndex = 2;
            this._selectedSourceLabel.Text = "Selected source path";
            // 
            // _selectedOutputLabel
            // 
            this._selectedOutputLabel.AutoSize = true;
            this._selectedOutputLabel.Location = new System.Drawing.Point(13, 122);
            this._selectedOutputLabel.Name = "_selectedOutputLabel";
            this._selectedOutputLabel.Size = new System.Drawing.Size(106, 13);
            this._selectedOutputLabel.TabIndex = 2;
            this._selectedOutputLabel.Text = "Selected output path";
            // 
            // _outputPathTextBox
            // 
            this._outputPathTextBox.Location = new System.Drawing.Point(12, 138);
            this._outputPathTextBox.Name = "_outputPathTextBox";
            this._outputPathTextBox.Size = new System.Drawing.Size(330, 20);
            this._outputPathTextBox.TabIndex = 1;
            this._outputPathTextBox.Text = "Select output path...";
            // 
            // _createBgTxtBtn
            // 
            this._createBgTxtBtn.Location = new System.Drawing.Point(12, 164);
            this._createBgTxtBtn.Name = "_createBgTxtBtn";
            this._createBgTxtBtn.Size = new System.Drawing.Size(330, 44);
            this._createBgTxtBtn.TabIndex = 0;
            this._createBgTxtBtn.Text = "Create bg.txt";
            this._createBgTxtBtn.UseVisualStyleBackColor = true;
            this._createBgTxtBtn.Click += new System.EventHandler(this._createBgTxtBtn_Click);
            // 
            // _negSamplesLabel
            // 
            this._negSamplesLabel.AutoSize = true;
            this._negSamplesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._negSamplesLabel.Location = new System.Drawing.Point(12, 9);
            this._negSamplesLabel.Name = "_negSamplesLabel";
            this._negSamplesLabel.Size = new System.Drawing.Size(222, 24);
            this._negSamplesLabel.TabIndex = 3;
            this._negSamplesLabel.Text = "Negative sample creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crop positive images (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected source path";
            // 
            // _cropSourcePathTextBox
            // 
            this._cropSourcePathTextBox.Location = new System.Drawing.Point(180, 254);
            this._cropSourcePathTextBox.Name = "_cropSourcePathTextBox";
            this._cropSourcePathTextBox.Size = new System.Drawing.Size(162, 20);
            this._cropSourcePathTextBox.TabIndex = 1;
            this._cropSourcePathTextBox.Text = "Select source path...";
            // 
            // _cropSelectSourceBtn
            // 
            this._cropSelectSourceBtn.Location = new System.Drawing.Point(12, 238);
            this._cropSelectSourceBtn.Name = "_cropSelectSourceBtn";
            this._cropSelectSourceBtn.Size = new System.Drawing.Size(162, 36);
            this._cropSelectSourceBtn.TabIndex = 0;
            this._cropSelectSourceBtn.Text = "Select source";
            this._cropSelectSourceBtn.UseVisualStyleBackColor = true;
            this._cropSelectSourceBtn.Click += new System.EventHandler(this._cropSelectSourceBtn_Click);
            // 
            // _cropImagesBtn
            // 
            this._cropImagesBtn.Location = new System.Drawing.Point(12, 280);
            this._cropImagesBtn.Name = "_cropImagesBtn";
            this._cropImagesBtn.Size = new System.Drawing.Size(330, 44);
            this._cropImagesBtn.TabIndex = 0;
            this._cropImagesBtn.Text = "Crop images";
            this._cropImagesBtn.UseVisualStyleBackColor = true;
            this._cropImagesBtn.Click += new System.EventHandler(this._cropImagesBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this._selectSourceBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._negSamplesLabel);
            this.Controls.Add(this._cropSelectSourceBtn);
            this.Controls.Add(this._selectSourceBtn);
            this.Controls.Add(this._cropImagesBtn);
            this.Controls.Add(this._createBgTxtBtn);
            this.Controls.Add(this._selectOutputBtn);
            this.Controls.Add(this._cropSourcePathTextBox);
            this.Controls.Add(this._selectedOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._sourcePathTextBox);
            this.Controls.Add(this._selectedSourceLabel);
            this.Controls.Add(this._outputPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CreateSamplesGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _selectSourceBtn;
        private System.Windows.Forms.Button _selectOutputBtn;
        private System.Windows.Forms.TextBox _sourcePathTextBox;
        private System.Windows.Forms.Label _selectedSourceLabel;
        private System.Windows.Forms.Label _selectedOutputLabel;
        private System.Windows.Forms.TextBox _outputPathTextBox;
        private System.Windows.Forms.Button _createBgTxtBtn;
        private System.Windows.Forms.Label _negSamplesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _cropSourcePathTextBox;
        private System.Windows.Forms.Button _cropSelectSourceBtn;
        private System.Windows.Forms.Button _cropImagesBtn;
    }
}

