namespace download_youtube
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.audioRadioButton = new System.Windows.Forms.RadioButton();
            this.videoRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(93, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(418, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Youtube URL:";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(435, 29);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // audioRadioButton
            // 
            this.audioRadioButton.AutoSize = true;
            this.audioRadioButton.Location = new System.Drawing.Point(93, 29);
            this.audioRadioButton.Name = "audioRadioButton";
            this.audioRadioButton.Size = new System.Drawing.Size(52, 17);
            this.audioRadioButton.TabIndex = 3;
            this.audioRadioButton.TabStop = true;
            this.audioRadioButton.Text = "Audio";
            this.audioRadioButton.UseVisualStyleBackColor = true;
            // 
            // videoRadioButton
            // 
            this.videoRadioButton.AutoSize = true;
            this.videoRadioButton.Location = new System.Drawing.Point(151, 29);
            this.videoRadioButton.Name = "videoRadioButton";
            this.videoRadioButton.Size = new System.Drawing.Size(52, 17);
            this.videoRadioButton.TabIndex = 4;
            this.videoRadioButton.TabStop = true;
            this.videoRadioButton.Text = "Video";
            this.videoRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 72);
            this.Controls.Add(this.videoRadioButton);
            this.Controls.Add(this.audioRadioButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.RadioButton audioRadioButton;
        private System.Windows.Forms.RadioButton videoRadioButton;
    }
}

