namespace BIT694_TMA3
{
    partial class Form1
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
            this.browseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invertedIndex2 = new System.Windows.Forms.Button();
            this.invertedIndex1 = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.displayStatistics = new System.Windows.Forms.Button();
            this.totalFiles = new System.Windows.Forms.TextBox();
            this.averageTerm = new System.Windows.Forms.TextBox();
            this.totalTerms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileList = new System.Windows.Forms.TextBox();
            this.filesFound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(551, 21);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(105, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invertedIndex2);
            this.groupBox1.Controls.Add(this.invertedIndex1);
            this.groupBox1.Controls.Add(this.selectFolder);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Folder";
            // 
            // invertedIndex2
            // 
            this.invertedIndex2.Location = new System.Drawing.Point(6, 88);
            this.invertedIndex2.Name = "invertedIndex2";
            this.invertedIndex2.Size = new System.Drawing.Size(650, 23);
            this.invertedIndex2.TabIndex = 3;
            this.invertedIndex2.Text = "Refresh Inverted Index";
            this.invertedIndex2.UseVisualStyleBackColor = true;
            this.invertedIndex2.Click += new System.EventHandler(this.invertedIndex2_Click);
            // 
            // invertedIndex1
            // 
            this.invertedIndex1.Location = new System.Drawing.Point(6, 59);
            this.invertedIndex1.Name = "invertedIndex1";
            this.invertedIndex1.Size = new System.Drawing.Size(650, 23);
            this.invertedIndex1.TabIndex = 2;
            this.invertedIndex1.Text = "Build Inverted Index";
            this.invertedIndex1.UseVisualStyleBackColor = true;
            this.invertedIndex1.Click += new System.EventHandler(this.invertedIndex1_Click);
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(6, 22);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(539, 22);
            this.selectFolder.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayStatistics);
            this.groupBox2.Controls.Add(this.totalFiles);
            this.groupBox2.Controls.Add(this.averageTerm);
            this.groupBox2.Controls.Add(this.totalTerms);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // displayStatistics
            // 
            this.displayStatistics.Location = new System.Drawing.Point(9, 62);
            this.displayStatistics.Name = "displayStatistics";
            this.displayStatistics.Size = new System.Drawing.Size(642, 23);
            this.displayStatistics.TabIndex = 6;
            this.displayStatistics.Text = "Display Statistics";
            this.displayStatistics.UseVisualStyleBackColor = true;
            this.displayStatistics.Click += new System.EventHandler(this.displayStatistics_Click);
            // 
            // totalFiles
            // 
            this.totalFiles.Location = new System.Drawing.Point(551, 31);
            this.totalFiles.Name = "totalFiles";
            this.totalFiles.Size = new System.Drawing.Size(100, 22);
            this.totalFiles.TabIndex = 5;
            // 
            // averageTerm
            // 
            this.averageTerm.Location = new System.Drawing.Point(362, 29);
            this.averageTerm.Name = "averageTerm";
            this.averageTerm.Size = new System.Drawing.Size(93, 22);
            this.averageTerm.TabIndex = 4;
            // 
            // totalTerms
            // 
            this.totalTerms.Location = new System.Drawing.Point(100, 29);
            this.totalTerms.Name = "totalTerms";
            this.totalTerms.Size = new System.Drawing.Size(100, 22);
            this.totalTerms.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Files: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Term Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Terms:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileList);
            this.groupBox3.Controls.Add(this.filesFound);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchWord);
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 298);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(11, 93);
            this.fileList.Multiline = true;
            this.fileList.Name = "fileList";
            this.fileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileList.Size = new System.Drawing.Size(644, 188);
            this.fileList.TabIndex = 6;
            // 
            // filesFound
            // 
            this.filesFound.Location = new System.Drawing.Point(98, 59);
            this.filesFound.Name = "filesFound";
            this.filesFound.Size = new System.Drawing.Size(106, 22);
            this.filesFound.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Files Found: ";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(551, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(6, 21);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(539, 22);
            this.searchWord.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button invertedIndex2;
        private System.Windows.Forms.Button invertedIndex1;
        private System.Windows.Forms.TextBox selectFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button displayStatistics;
        private System.Windows.Forms.TextBox totalFiles;
        private System.Windows.Forms.TextBox averageTerm;
        private System.Windows.Forms.TextBox totalTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox fileList;
        private System.Windows.Forms.TextBox filesFound;
        private System.Windows.Forms.Label label4;
    }
}

