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
            this.label2 = new System.Windows.Forms.Label();
            this._cropSourcePathTextBox = new System.Windows.Forms.TextBox();
            this._cropSelectSourceBtn = new System.Windows.Forms.Button();
            this._cropImagesBtn = new System.Windows.Forms.Button();
            this._negativeSampleCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._cropOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cropSelectOutputBtn = new System.Windows.Forms.Button();
            this._negativeSampleCreationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _selectSourceBtn
            // 
            this._selectSourceBtn.Location = new System.Drawing.Point(5, 18);
            this._selectSourceBtn.Name = "_selectSourceBtn";
            this._selectSourceBtn.Size = new System.Drawing.Size(105, 35);
            this._selectSourceBtn.TabIndex = 0;
            this._selectSourceBtn.Text = "Select source";
            this._selectSourceBtn.UseVisualStyleBackColor = true;
            this._selectSourceBtn.Click += new System.EventHandler(this._selectSourceBtn_Click);
            // 
            // _selectOutputBtn
            // 
            this._selectOutputBtn.Location = new System.Drawing.Point(5, 59);
            this._selectOutputBtn.Name = "_selectOutputBtn";
            this._selectOutputBtn.Size = new System.Drawing.Size(105, 35);
            this._selectOutputBtn.TabIndex = 0;
            this._selectOutputBtn.Text = "Select output";
            this._selectOutputBtn.UseVisualStyleBackColor = true;
            this._selectOutputBtn.Click += new System.EventHandler(this._selectOutputBtn_Click);
            // 
            // _sourcePathTextBox
            // 
            this._sourcePathTextBox.Location = new System.Drawing.Point(116, 35);
            this._sourcePathTextBox.Name = "_sourcePathTextBox";
            this._sourcePathTextBox.Size = new System.Drawing.Size(209, 20);
            this._sourcePathTextBox.TabIndex = 1;
            this._sourcePathTextBox.Text = "Select source path...";
            // 
            // _selectedSourceLabel
            // 
            this._selectedSourceLabel.AutoSize = true;
            this._selectedSourceLabel.Location = new System.Drawing.Point(116, 18);
            this._selectedSourceLabel.Name = "_selectedSourceLabel";
            this._selectedSourceLabel.Size = new System.Drawing.Size(108, 13);
            this._selectedSourceLabel.TabIndex = 2;
            this._selectedSourceLabel.Text = "Selected source path";
            // 
            // _selectedOutputLabel
            // 
            this._selectedOutputLabel.AutoSize = true;
            this._selectedOutputLabel.Location = new System.Drawing.Point(116, 59);
            this._selectedOutputLabel.Name = "_selectedOutputLabel";
            this._selectedOutputLabel.Size = new System.Drawing.Size(106, 13);
            this._selectedOutputLabel.TabIndex = 2;
            this._selectedOutputLabel.Text = "Selected output path";
            // 
            // _outputPathTextBox
            // 
            this._outputPathTextBox.Location = new System.Drawing.Point(116, 76);
            this._outputPathTextBox.Name = "_outputPathTextBox";
            this._outputPathTextBox.Size = new System.Drawing.Size(209, 20);
            this._outputPathTextBox.TabIndex = 1;
            this._outputPathTextBox.Text = "Select output path...";
            // 
            // _createBgTxtBtn
            // 
            this._createBgTxtBtn.Location = new System.Drawing.Point(5, 101);
            this._createBgTxtBtn.Name = "_createBgTxtBtn";
            this._createBgTxtBtn.Size = new System.Drawing.Size(320, 35);
            this._createBgTxtBtn.TabIndex = 0;
            this._createBgTxtBtn.Text = "Create bg.txt";
            this._createBgTxtBtn.UseVisualStyleBackColor = true;
            this._createBgTxtBtn.Click += new System.EventHandler(this._createBgTxtBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected source path";
            // 
            // _cropSourcePathTextBox
            // 
            this._cropSourcePathTextBox.Location = new System.Drawing.Point(115, 35);
            this._cropSourcePathTextBox.Name = "_cropSourcePathTextBox";
            this._cropSourcePathTextBox.Size = new System.Drawing.Size(210, 20);
            this._cropSourcePathTextBox.TabIndex = 1;
            this._cropSourcePathTextBox.Text = "Select source path...";
            // 
            // _cropSelectSourceBtn
            // 
            this._cropSelectSourceBtn.Location = new System.Drawing.Point(5, 18);
            this._cropSelectSourceBtn.Name = "_cropSelectSourceBtn";
            this._cropSelectSourceBtn.Size = new System.Drawing.Size(104, 36);
            this._cropSelectSourceBtn.TabIndex = 0;
            this._cropSelectSourceBtn.Text = "Select source";
            this._cropSelectSourceBtn.UseVisualStyleBackColor = true;
            this._cropSelectSourceBtn.Click += new System.EventHandler(this._cropSelectSourceBtn_Click);
            // 
            // _cropImagesBtn
            // 
            this._cropImagesBtn.Location = new System.Drawing.Point(5, 103);
            this._cropImagesBtn.Name = "_cropImagesBtn";
            this._cropImagesBtn.Size = new System.Drawing.Size(320, 35);
            this._cropImagesBtn.TabIndex = 0;
            this._cropImagesBtn.Text = "Crop images";
            this._cropImagesBtn.UseVisualStyleBackColor = true;
            this._cropImagesBtn.Click += new System.EventHandler(this._cropImagesBtn_Click);
            // 
            // _negativeSampleCreationGroupBox
            // 
            this._negativeSampleCreationGroupBox.Controls.Add(this._selectSourceBtn);
            this._negativeSampleCreationGroupBox.Controls.Add(this._sourcePathTextBox);
            this._negativeSampleCreationGroupBox.Controls.Add(this._selectedSourceLabel);
            this._negativeSampleCreationGroupBox.Controls.Add(this._createBgTxtBtn);
            this._negativeSampleCreationGroupBox.Controls.Add(this._selectedOutputLabel);
            this._negativeSampleCreationGroupBox.Controls.Add(this._outputPathTextBox);
            this._negativeSampleCreationGroupBox.Controls.Add(this._selectOutputBtn);
            this._negativeSampleCreationGroupBox.Location = new System.Drawing.Point(9, 10);
            this._negativeSampleCreationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this._negativeSampleCreationGroupBox.Name = "_negativeSampleCreationGroupBox";
            this._negativeSampleCreationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this._negativeSampleCreationGroupBox.Size = new System.Drawing.Size(331, 143);
            this._negativeSampleCreationGroupBox.TabIndex = 4;
            this._negativeSampleCreationGroupBox.TabStop = false;
            this._negativeSampleCreationGroupBox.Text = "Negative sample creation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cropSelectOutputBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._cropSelectSourceBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._cropOutputPathTextBox);
            this.groupBox1.Controls.Add(this._cropImagesBtn);
            this.groupBox1.Controls.Add(this._cropSourcePathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(331, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crop positive images (optional)";
            // 
            // _cropOutputPathTextBox
            // 
            this._cropOutputPathTextBox.Location = new System.Drawing.Point(115, 77);
            this._cropOutputPathTextBox.Name = "_cropOutputPathTextBox";
            this._cropOutputPathTextBox.Size = new System.Drawing.Size(210, 20);
            this._cropOutputPathTextBox.TabIndex = 1;
            this._cropOutputPathTextBox.Text = "Select output path...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected output path";
            // 
            // _cropSelectOutputBtn
            // 
            this._cropSelectOutputBtn.Location = new System.Drawing.Point(5, 60);
            this._cropSelectOutputBtn.Name = "_cropSelectOutputBtn";
            this._cropSelectOutputBtn.Size = new System.Drawing.Size(104, 36);
            this._cropSelectOutputBtn.TabIndex = 0;
            this._cropSelectOutputBtn.Text = "Select output";
            this._cropSelectOutputBtn.UseVisualStyleBackColor = true;
            this._cropSelectOutputBtn.Click += new System.EventHandler(this._cropSelectSourceBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this._selectSourceBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._negativeSampleCreationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CreateSamplesGUI";
            this._negativeSampleCreationGroupBox.ResumeLayout(false);
            this._negativeSampleCreationGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _selectSourceBtn;
        private System.Windows.Forms.Button _selectOutputBtn;
        private System.Windows.Forms.TextBox _sourcePathTextBox;
        private System.Windows.Forms.Label _selectedSourceLabel;
        private System.Windows.Forms.Label _selectedOutputLabel;
        private System.Windows.Forms.TextBox _outputPathTextBox;
        private System.Windows.Forms.Button _createBgTxtBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _cropSelectSourceBtn;
        private System.Windows.Forms.Button _cropImagesBtn;
        private System.Windows.Forms.GroupBox _negativeSampleCreationGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox _cropSourcePathTextBox;
        private System.Windows.Forms.Button _cropSelectOutputBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox _cropOutputPathTextBox;
    }
}

