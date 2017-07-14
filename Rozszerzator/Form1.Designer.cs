namespace Rozszerzator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.renameFileButton = new System.Windows.Forms.Button();
            this.extensionBar = new System.Windows.Forms.TextBox();
            this.changeLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CHB_mp3 = new System.Windows.Forms.CheckBox();
            this.CHB_wav = new System.Windows.Forms.CheckBox();
            this.CHB_txt = new System.Windows.Forms.CheckBox();
            this.CHB_thm = new System.Windows.Forms.CheckBox();
            this.CHB_jpg = new System.Windows.Forms.CheckBox();
            this.CHB_bmp = new System.Windows.Forms.CheckBox();
            this.CHB_selectAll = new System.Windows.Forms.CheckBox();
            this.CHB_unlisted = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteFiles = new System.Windows.Forms.Button();
            this.moveFiles = new System.Windows.Forms.Button();
            this.compressFiles = new System.Windows.Forms.Button();
            this.decompressFiles = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.CHB_onlyZIP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 49);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(144, 41);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "POMOC";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(11, 103);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(217, 41);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "OTWÓRZ FOLDER";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // renameFileButton
            // 
            this.renameFileButton.Location = new System.Drawing.Point(11, 160);
            this.renameFileButton.Name = "renameFileButton";
            this.renameFileButton.Size = new System.Drawing.Size(217, 41);
            this.renameFileButton.TabIndex = 3;
            this.renameFileButton.Text = "ZMIEŃ NA";
            this.renameFileButton.UseVisualStyleBackColor = true;
            this.renameFileButton.Click += new System.EventHandler(this.renameFileButton_Click);
            // 
            // extensionBar
            // 
            this.extensionBar.Location = new System.Drawing.Point(11, 207);
            this.extensionBar.Name = "extensionBar";
            this.extensionBar.Size = new System.Drawing.Size(217, 20);
            this.extensionBar.TabIndex = 4;
            this.extensionBar.Text = "*.*";
            // 
            // changeLog
            // 
            this.changeLog.BackColor = System.Drawing.Color.DarkGreen;
            this.changeLog.ForeColor = System.Drawing.Color.SkyBlue;
            this.changeLog.Location = new System.Drawing.Point(235, 103);
            this.changeLog.Name = "changeLog";
            this.changeLog.ReadOnly = true;
            this.changeLog.Size = new System.Drawing.Size(304, 124);
            this.changeLog.TabIndex = 6;
            this.changeLog.Text = "Status:\n[PUSTY LOG] - Wprowadź zmiany ";
            this.changeLog.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // CHB_mp3
            // 
            this.CHB_mp3.AutoSize = true;
            this.CHB_mp3.Location = new System.Drawing.Point(429, 49);
            this.CHB_mp3.Name = "CHB_mp3";
            this.CHB_mp3.Size = new System.Drawing.Size(51, 17);
            this.CHB_mp3.TabIndex = 8;
            this.CHB_mp3.Text = ".MP3";
            this.CHB_mp3.UseVisualStyleBackColor = true;
            // 
            // CHB_wav
            // 
            this.CHB_wav.AutoSize = true;
            this.CHB_wav.Location = new System.Drawing.Point(429, 72);
            this.CHB_wav.Name = "CHB_wav";
            this.CHB_wav.Size = new System.Drawing.Size(54, 17);
            this.CHB_wav.TabIndex = 9;
            this.CHB_wav.Text = ".WAV";
            this.CHB_wav.UseVisualStyleBackColor = true;
            // 
            // CHB_txt
            // 
            this.CHB_txt.AutoSize = true;
            this.CHB_txt.Location = new System.Drawing.Point(489, 49);
            this.CHB_txt.Name = "CHB_txt";
            this.CHB_txt.Size = new System.Drawing.Size(50, 17);
            this.CHB_txt.TabIndex = 10;
            this.CHB_txt.Text = ".TXT";
            this.CHB_txt.UseVisualStyleBackColor = true;
            // 
            // CHB_thm
            // 
            this.CHB_thm.AutoSize = true;
            this.CHB_thm.Location = new System.Drawing.Point(489, 72);
            this.CHB_thm.Name = "CHB_thm";
            this.CHB_thm.Size = new System.Drawing.Size(53, 17);
            this.CHB_thm.TabIndex = 11;
            this.CHB_thm.Text = ".THM";
            this.CHB_thm.UseVisualStyleBackColor = true;
            // 
            // CHB_jpg
            // 
            this.CHB_jpg.AutoSize = true;
            this.CHB_jpg.Location = new System.Drawing.Point(338, 49);
            this.CHB_jpg.Name = "CHB_jpg";
            this.CHB_jpg.Size = new System.Drawing.Size(85, 17);
            this.CHB_jpg.TabIndex = 12;
            this.CHB_jpg.Text = ".JPG (JPEG)";
            this.CHB_jpg.UseVisualStyleBackColor = true;
            // 
            // CHB_bmp
            // 
            this.CHB_bmp.AutoSize = true;
            this.CHB_bmp.Location = new System.Drawing.Point(338, 72);
            this.CHB_bmp.Name = "CHB_bmp";
            this.CHB_bmp.Size = new System.Drawing.Size(52, 17);
            this.CHB_bmp.TabIndex = 13;
            this.CHB_bmp.Text = ".BMP";
            this.CHB_bmp.UseVisualStyleBackColor = true;
            // 
            // CHB_selectAll
            // 
            this.CHB_selectAll.AutoSize = true;
            this.CHB_selectAll.Location = new System.Drawing.Point(235, 49);
            this.CHB_selectAll.Name = "CHB_selectAll";
            this.CHB_selectAll.Size = new System.Drawing.Size(72, 17);
            this.CHB_selectAll.TabIndex = 14;
            this.CHB_selectAll.Text = "Wszystko";
            this.CHB_selectAll.UseVisualStyleBackColor = true;
            this.CHB_selectAll.CheckedChanged += new System.EventHandler(this.CHB_selectAll_CheckedChanged);
            // 
            // CHB_unlisted
            // 
            this.CHB_unlisted.AutoSize = true;
            this.CHB_unlisted.Location = new System.Drawing.Point(235, 72);
            this.CHB_unlisted.Name = "CHB_unlisted";
            this.CHB_unlisted.Size = new System.Drawing.Size(97, 17);
            this.CHB_unlisted.TabIndex = 15;
            this.CHB_unlisted.Text = "Niewymienione";
            this.CHB_unlisted.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(109, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pasek rozszerzeń pliku";
            // 
            // deleteFiles
            // 
            this.deleteFiles.Location = new System.Drawing.Point(545, 49);
            this.deleteFiles.Name = "deleteFiles";
            this.deleteFiles.Size = new System.Drawing.Size(217, 41);
            this.deleteFiles.TabIndex = 17;
            this.deleteFiles.Text = "USUŃ PLIKI";
            this.deleteFiles.UseVisualStyleBackColor = true;
            this.deleteFiles.Click += new System.EventHandler(this.deleteFiles_Click);
            // 
            // moveFiles
            // 
            this.moveFiles.Location = new System.Drawing.Point(545, 103);
            this.moveFiles.Name = "moveFiles";
            this.moveFiles.Size = new System.Drawing.Size(158, 41);
            this.moveFiles.TabIndex = 20;
            this.moveFiles.Text = "PRZENIEŚ PLIKI";
            this.moveFiles.UseVisualStyleBackColor = true;
            this.moveFiles.Click += new System.EventHandler(this.moveFiles_Click);
            // 
            // compressFiles
            // 
            this.compressFiles.Location = new System.Drawing.Point(545, 150);
            this.compressFiles.Name = "compressFiles";
            this.compressFiles.Size = new System.Drawing.Size(217, 33);
            this.compressFiles.TabIndex = 22;
            this.compressFiles.Text = "KOMPRESUJ PLIKI (.ZIP)";
            this.compressFiles.UseVisualStyleBackColor = true;
            this.compressFiles.Click += new System.EventHandler(this.compressFiles_Click);
            // 
            // decompressFiles
            // 
            this.decompressFiles.Location = new System.Drawing.Point(545, 194);
            this.decompressFiles.Name = "decompressFiles";
            this.decompressFiles.Size = new System.Drawing.Size(217, 33);
            this.decompressFiles.TabIndex = 23;
            this.decompressFiles.Text = "DEKOMPRESUJ PLIKI (.ZIP)";
            this.decompressFiles.UseVisualStyleBackColor = true;
            this.decompressFiles.Click += new System.EventHandler(this.decompressFiles_Click);
            // 
            // selectFolder
            // 
            this.selectFolder.Image = ((System.Drawing.Image)(resources.GetObject("selectFolder.Image")));
            this.selectFolder.Location = new System.Drawing.Point(709, 103);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(53, 41);
            this.selectFolder.TabIndex = 24;
            this.selectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(162, 49);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(66, 41);
            this.clearLog.TabIndex = 25;
            this.clearLog.Text = "CZYŚĆ";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // CHB_onlyZIP
            // 
            this.CHB_onlyZIP.AutoSize = true;
            this.CHB_onlyZIP.Location = new System.Drawing.Point(625, 26);
            this.CHB_onlyZIP.Name = "CHB_onlyZIP";
            this.CHB_onlyZIP.Size = new System.Drawing.Size(137, 17);
            this.CHB_onlyZIP.TabIndex = 26;
            this.CHB_onlyZIP.Text = "Tylko dekompresja (zip)";
            this.CHB_onlyZIP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(771, 242);
            this.Controls.Add(this.CHB_onlyZIP);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.decompressFiles);
            this.Controls.Add(this.compressFiles);
            this.Controls.Add(this.moveFiles);
            this.Controls.Add(this.deleteFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CHB_unlisted);
            this.Controls.Add(this.CHB_selectAll);
            this.Controls.Add(this.CHB_bmp);
            this.Controls.Add(this.CHB_jpg);
            this.Controls.Add(this.CHB_thm);
            this.Controls.Add(this.CHB_txt);
            this.Controls.Add(this.CHB_wav);
            this.Controls.Add(this.CHB_mp3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeLog);
            this.Controls.Add(this.extensionBar);
            this.Controls.Add(this.renameFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(787, 281);
            this.MinimumSize = new System.Drawing.Size(787, 281);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kombinator v.1.0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button renameFileButton;
        private System.Windows.Forms.TextBox extensionBar;
        private System.Windows.Forms.RichTextBox changeLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CHB_mp3;
        private System.Windows.Forms.CheckBox CHB_wav;
        private System.Windows.Forms.CheckBox CHB_txt;
        private System.Windows.Forms.CheckBox CHB_thm;
        private System.Windows.Forms.CheckBox CHB_jpg;
        private System.Windows.Forms.CheckBox CHB_bmp;
        private System.Windows.Forms.CheckBox CHB_selectAll;
        private System.Windows.Forms.CheckBox CHB_unlisted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteFiles;
        private System.Windows.Forms.Button moveFiles;
        private System.Windows.Forms.Button compressFiles;
        private System.Windows.Forms.Button decompressFiles;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.CheckBox CHB_onlyZIP;
    }
}

