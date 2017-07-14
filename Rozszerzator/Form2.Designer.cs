namespace Rozszerzator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.helpScreen = new System.Windows.Forms.RichTextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.authorButton = new System.Windows.Forms.Button();
            this.pages = new System.Windows.Forms.Label();
            this.Button11 = new System.Windows.Forms.PictureBox();
            this.Button22 = new System.Windows.Forms.PictureBox();
            this.Button33 = new System.Windows.Forms.PictureBox();
            this.Button1Text = new System.Windows.Forms.Label();
            this.Button2Text = new System.Windows.Forms.Label();
            this.Button3Text = new System.Windows.Forms.Label();
            this.ExtensionBar11 = new System.Windows.Forms.PictureBox();
            this.AllExtensionsText = new System.Windows.Forms.Label();
            this.ExtensionBarText = new System.Windows.Forms.Label();
            this.Explain1 = new System.Windows.Forms.Label();
            this.Explain3 = new System.Windows.Forms.Label();
            this.CheckBox11 = new System.Windows.Forms.PictureBox();
            this.ExtensionText = new System.Windows.Forms.Label();
            this.Explain2 = new System.Windows.Forms.Label();
            this.Explain4 = new System.Windows.Forms.Label();
            this.Explain5 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.PictureBox();
            this.ClearText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Button11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionBar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).BeginInit();
            this.SuspendLayout();
            // 
            // helpScreen
            // 
            this.helpScreen.BackColor = System.Drawing.Color.DarkGray;
            this.helpScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.helpScreen.Location = new System.Drawing.Point(12, 12);
            this.helpScreen.Name = "helpScreen";
            this.helpScreen.ReadOnly = true;
            this.helpScreen.Size = new System.Drawing.Size(601, 279);
            this.helpScreen.TabIndex = 0;
            this.helpScreen.Text = "";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(175, 297);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(99, 32);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "<<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(351, 297);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(99, 32);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = ">>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(514, 297);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(99, 32);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(12, 297);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(99, 32);
            this.authorButton.TabIndex = 4;
            this.authorButton.Text = "Autor";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // pages
            // 
            this.pages.AutoSize = true;
            this.pages.Location = new System.Drawing.Point(275, 307);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(75, 13);
            this.pages.TabIndex = 5;
            this.pages.Text = "STRONA: 1/3";
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(22, 25);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(144, 41);
            this.Button11.TabIndex = 6;
            this.Button11.TabStop = false;
            // 
            // Button22
            // 
            this.Button22.Location = new System.Drawing.Point(22, 116);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(144, 41);
            this.Button22.TabIndex = 7;
            this.Button22.TabStop = false;
            // 
            // Button33
            // 
            this.Button33.Location = new System.Drawing.Point(22, 230);
            this.Button33.Name = "Button33";
            this.Button33.Size = new System.Drawing.Size(144, 41);
            this.Button33.TabIndex = 8;
            this.Button33.TabStop = false;
            // 
            // Button1Text
            // 
            this.Button1Text.AutoSize = true;
            this.Button1Text.Location = new System.Drawing.Point(41, 39);
            this.Button1Text.Name = "Button1Text";
            this.Button1Text.Size = new System.Drawing.Size(102, 13);
            this.Button1Text.TabIndex = 10;
            this.Button1Text.Text = "OTWÓRZ FOLDER";
            this.Button1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button2Text
            // 
            this.Button2Text.AutoSize = true;
            this.Button2Text.Location = new System.Drawing.Point(45, 130);
            this.Button2Text.Name = "Button2Text";
            this.Button2Text.Size = new System.Drawing.Size(59, 13);
            this.Button2Text.TabIndex = 11;
            this.Button2Text.Text = "ZMIEŃ NA";
            this.Button2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button3Text
            // 
            this.Button3Text.AutoSize = true;
            this.Button3Text.Location = new System.Drawing.Point(45, 244);
            this.Button3Text.Name = "Button3Text";
            this.Button3Text.Size = new System.Drawing.Size(67, 13);
            this.Button3Text.TabIndex = 12;
            this.Button3Text.Text = "USUŃ PLIKI";
            this.Button3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtensionBar11
            // 
            this.ExtensionBar11.BackColor = System.Drawing.Color.White;
            this.ExtensionBar11.Location = new System.Drawing.Point(21, 185);
            this.ExtensionBar11.Name = "ExtensionBar11";
            this.ExtensionBar11.Size = new System.Drawing.Size(144, 19);
            this.ExtensionBar11.TabIndex = 13;
            this.ExtensionBar11.TabStop = false;
            // 
            // AllExtensionsText
            // 
            this.AllExtensionsText.AutoSize = true;
            this.AllExtensionsText.BackColor = System.Drawing.Color.White;
            this.AllExtensionsText.Location = new System.Drawing.Point(23, 189);
            this.AllExtensionsText.Name = "AllExtensionsText";
            this.AllExtensionsText.Size = new System.Drawing.Size(18, 13);
            this.AllExtensionsText.TabIndex = 14;
            this.AllExtensionsText.Text = "*.*";
            // 
            // ExtensionBarText
            // 
            this.ExtensionBarText.AutoSize = true;
            this.ExtensionBarText.BackColor = System.Drawing.Color.White;
            this.ExtensionBarText.ForeColor = System.Drawing.Color.DimGray;
            this.ExtensionBarText.Location = new System.Drawing.Point(99, 187);
            this.ExtensionBarText.Name = "ExtensionBarText";
            this.ExtensionBarText.Size = new System.Drawing.Size(63, 13);
            this.ExtensionBarText.TabIndex = 15;
            this.ExtensionBarText.Text = "Pasek roz...";
            // 
            // Explain1
            // 
            this.Explain1.AutoSize = true;
            this.Explain1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Explain1.Location = new System.Drawing.Point(173, 29);
            this.Explain1.Name = "Explain1";
            this.Explain1.Size = new System.Drawing.Size(369, 26);
            this.Explain1.TabIndex = 16;
            this.Explain1.Text = "Przenosi pliki pod wskazany folder. Należy wcześniej wybrać folder docelowy\r\nprze" +
    "noszenia plików poprzez wciśnięcie przycisku wyboru folderu.";
            // 
            // Explain3
            // 
            this.Explain3.AutoSize = true;
            this.Explain3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Explain3.Location = new System.Drawing.Point(173, 124);
            this.Explain3.Name = "Explain3";
            this.Explain3.Size = new System.Drawing.Size(322, 13);
            this.Explain3.TabIndex = 17;
            this.Explain3.Text = "Po naciśnięciu przycisku ruszy proces kompresji wybranych plików.";
            // 
            // CheckBox11
            // 
            this.CheckBox11.BackColor = System.Drawing.Color.White;
            this.CheckBox11.Location = new System.Drawing.Point(70, 80);
            this.CheckBox11.Name = "CheckBox11";
            this.CheckBox11.Size = new System.Drawing.Size(19, 19);
            this.CheckBox11.TabIndex = 18;
            this.CheckBox11.TabStop = false;
            // 
            // ExtensionText
            // 
            this.ExtensionText.AutoSize = true;
            this.ExtensionText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExtensionText.Location = new System.Drawing.Point(90, 86);
            this.ExtensionText.Name = "ExtensionText";
            this.ExtensionText.Size = new System.Drawing.Size(32, 13);
            this.ExtensionText.TabIndex = 19;
            this.ExtensionText.Text = ".MP3";
            // 
            // Explain2
            // 
            this.Explain2.AutoSize = true;
            this.Explain2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Explain2.Location = new System.Drawing.Point(173, 83);
            this.Explain2.Name = "Explain2";
            this.Explain2.Size = new System.Drawing.Size(383, 13);
            this.Explain2.TabIndex = 20;
            this.Explain2.Text = "Przycisk wyboru folderu. Działa na zasadzie jak przycisk \"OTWÓRZ FOLDER\".";
            // 
            // Explain4
            // 
            this.Explain4.AutoSize = true;
            this.Explain4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Explain4.Location = new System.Drawing.Point(173, 177);
            this.Explain4.Name = "Explain4";
            this.Explain4.Size = new System.Drawing.Size(395, 52);
            this.Explain4.TabIndex = 21;
            this.Explain4.Text = resources.GetString("Explain4.Text");
            // 
            // Explain5
            // 
            this.Explain5.AutoSize = true;
            this.Explain5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Explain5.Location = new System.Drawing.Point(173, 236);
            this.Explain5.Name = "Explain5";
            this.Explain5.Size = new System.Drawing.Size(345, 26);
            this.Explain5.TabIndex = 22;
            this.Explain5.Text = "Usuwa wszystkie pliki o danym rozszerzeniu lub wszystkie pliki z folderu \r\n(jeżel" +
    "i wybrano wszystkie)";
            // 
            // openFolder
            // 
            this.openFolder.Image = ((System.Drawing.Image)(resources.GetObject("openFolder.Image")));
            this.openFolder.Location = new System.Drawing.Point(66, 71);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(50, 41);
            this.openFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openFolder.TabIndex = 23;
            this.openFolder.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(42, 175);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 41);
            this.ClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearButton.TabIndex = 24;
            this.ClearButton.TabStop = false;
            // 
            // ClearText
            // 
            this.ClearText.AutoSize = true;
            this.ClearText.Location = new System.Drawing.Point(68, 190);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(42, 13);
            this.ClearText.TabIndex = 25;
            this.ClearText.Text = "CZYŚĆ";
            this.ClearText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 336);
            this.Controls.Add(this.ClearText);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.Explain5);
            this.Controls.Add(this.Explain4);
            this.Controls.Add(this.Explain2);
            this.Controls.Add(this.ExtensionText);
            this.Controls.Add(this.CheckBox11);
            this.Controls.Add(this.Explain3);
            this.Controls.Add(this.Explain1);
            this.Controls.Add(this.ExtensionBarText);
            this.Controls.Add(this.AllExtensionsText);
            this.Controls.Add(this.ExtensionBar11);
            this.Controls.Add(this.Button3Text);
            this.Controls.Add(this.Button2Text);
            this.Controls.Add(this.Button1Text);
            this.Controls.Add(this.Button33);
            this.Controls.Add(this.Button22);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.helpScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(641, 375);
            this.MinimumSize = new System.Drawing.Size(641, 375);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kombinator v.1.0.0.0 - Pomoc";
            ((System.ComponentModel.ISupportInitialize)(this.Button11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionBar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpScreen;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Label pages;
        private System.Windows.Forms.PictureBox Button11;
        private System.Windows.Forms.PictureBox Button22;
        private System.Windows.Forms.PictureBox Button33;
        private System.Windows.Forms.Label Button1Text;
        private System.Windows.Forms.Label Button2Text;
        private System.Windows.Forms.Label Button3Text;
        private System.Windows.Forms.PictureBox ExtensionBar11;
        private System.Windows.Forms.Label AllExtensionsText;
        private System.Windows.Forms.Label ExtensionBarText;
        private System.Windows.Forms.Label Explain1;
        private System.Windows.Forms.Label Explain3;
        private System.Windows.Forms.PictureBox CheckBox11;
        private System.Windows.Forms.Label ExtensionText;
        private System.Windows.Forms.Label Explain2;
        private System.Windows.Forms.Label Explain4;
        private System.Windows.Forms.Label Explain5;
        private System.Windows.Forms.PictureBox openFolder;
        private System.Windows.Forms.PictureBox ClearButton;
        private System.Windows.Forms.Label ClearText;
    }
}