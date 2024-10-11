namespace printingcheque1aa
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxExtractedText = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(18, 18);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(180, 35);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxExtractedText
            // 
            this.textBoxExtractedText.Location = new System.Drawing.Point(18, 77);
            this.textBoxExtractedText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExtractedText.Multiline = true;
            this.textBoxExtractedText.Name = "textBoxExtractedText";
            this.textBoxExtractedText.ReadOnly = true;
            this.textBoxExtractedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExtractedText.Size = new System.Drawing.Size(538, 229);
            this.textBoxExtractedText.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(18, 323);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(349, 20);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Upload an image to extract text using Tesseract.";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 371);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxExtractedText);
            this.Controls.Add(this.buttonUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "Tesseract OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxExtractedText;
        private System.Windows.Forms.Label labelInfo;
    }
}
