namespace CSIT555_Class_Project
{
    partial class TamperDetectionForm
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
            this.FileLocationTxtBx = new System.Windows.Forms.TextBox();
            this.FileLbl = new System.Windows.Forms.Label();
            this.BrowseForFileBtn = new System.Windows.Forms.Button();
            this.EmbedWatermarkGrpBx = new System.Windows.Forms.GroupBox();
            this.DetectWatermarkGrpBx = new System.Windows.Forms.GroupBox();
            this.InitialInstructionsLbl = new System.Windows.Forms.Label();
            this.EmbeddingInstructionsLbl = new System.Windows.Forms.Label();
            this.EmbeddingKeywordLbl = new System.Windows.Forms.Label();
            this.EmbeddingKeywordTxtBx = new System.Windows.Forms.TextBox();
            this.DetectingInstructionsLbl = new System.Windows.Forms.Label();
            this.DetectingKeywordLbl = new System.Windows.Forms.Label();
            this.DetectingKeywordTxtBx = new System.Windows.Forms.TextBox();
            this.EmbedWatermarkBtn = new System.Windows.Forms.Button();
            this.DetectWatermarkBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EmbedWatermarkGrpBx.SuspendLayout();
            this.DetectWatermarkGrpBx.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileLocationTxtBx
            // 
            this.FileLocationTxtBx.Location = new System.Drawing.Point(44, 44);
            this.FileLocationTxtBx.Name = "FileLocationTxtBx";
            this.FileLocationTxtBx.Size = new System.Drawing.Size(417, 20);
            this.FileLocationTxtBx.TabIndex = 0;
            // 
            // FileLbl
            // 
            this.FileLbl.AutoSize = true;
            this.FileLbl.Location = new System.Drawing.Point(12, 47);
            this.FileLbl.Name = "FileLbl";
            this.FileLbl.Size = new System.Drawing.Size(26, 13);
            this.FileLbl.TabIndex = 1;
            this.FileLbl.Text = "File:";
            // 
            // BrowseForFileBtn
            // 
            this.BrowseForFileBtn.Location = new System.Drawing.Point(467, 42);
            this.BrowseForFileBtn.Name = "BrowseForFileBtn";
            this.BrowseForFileBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseForFileBtn.TabIndex = 2;
            this.BrowseForFileBtn.Text = "Browse";
            this.BrowseForFileBtn.UseVisualStyleBackColor = true;
            this.BrowseForFileBtn.Click += new System.EventHandler(this.BrowseForFileBtn_Click);
            // 
            // EmbedWatermarkGrpBx
            // 
            this.EmbedWatermarkGrpBx.Controls.Add(this.EmbedWatermarkBtn);
            this.EmbedWatermarkGrpBx.Controls.Add(this.EmbeddingKeywordTxtBx);
            this.EmbedWatermarkGrpBx.Controls.Add(this.EmbeddingKeywordLbl);
            this.EmbedWatermarkGrpBx.Controls.Add(this.EmbeddingInstructionsLbl);
            this.EmbedWatermarkGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbedWatermarkGrpBx.Location = new System.Drawing.Point(12, 71);
            this.EmbedWatermarkGrpBx.Name = "EmbedWatermarkGrpBx";
            this.EmbedWatermarkGrpBx.Size = new System.Drawing.Size(262, 105);
            this.EmbedWatermarkGrpBx.TabIndex = 3;
            this.EmbedWatermarkGrpBx.TabStop = false;
            this.EmbedWatermarkGrpBx.Text = "Embed Watermark";
            // 
            // DetectWatermarkGrpBx
            // 
            this.DetectWatermarkGrpBx.Controls.Add(this.DetectWatermarkBtn);
            this.DetectWatermarkGrpBx.Controls.Add(this.DetectingKeywordTxtBx);
            this.DetectWatermarkGrpBx.Controls.Add(this.DetectingKeywordLbl);
            this.DetectWatermarkGrpBx.Controls.Add(this.DetectingInstructionsLbl);
            this.DetectWatermarkGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectWatermarkGrpBx.Location = new System.Drawing.Point(280, 71);
            this.DetectWatermarkGrpBx.Name = "DetectWatermarkGrpBx";
            this.DetectWatermarkGrpBx.Size = new System.Drawing.Size(262, 105);
            this.DetectWatermarkGrpBx.TabIndex = 4;
            this.DetectWatermarkGrpBx.TabStop = false;
            this.DetectWatermarkGrpBx.Text = "Detect Watermark";
            // 
            // InitialInstructionsLbl
            // 
            this.InitialInstructionsLbl.AutoSize = true;
            this.InitialInstructionsLbl.Location = new System.Drawing.Point(13, 13);
            this.InitialInstructionsLbl.MaximumSize = new System.Drawing.Size(530, 0);
            this.InitialInstructionsLbl.Name = "InitialInstructionsLbl";
            this.InitialInstructionsLbl.Size = new System.Drawing.Size(507, 26);
            this.InitialInstructionsLbl.TabIndex = 5;
            this.InitialInstructionsLbl.Text = "Select a text file that to either embed a digital watermark into it, or examine i" +
                "t for an pre-existing watermark. Follow the steps in the correct group of contro" +
                "ls to proceed.";
            // 
            // EmbeddingInstructionsLbl
            // 
            this.EmbeddingInstructionsLbl.AutoSize = true;
            this.EmbeddingInstructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbeddingInstructionsLbl.Location = new System.Drawing.Point(6, 16);
            this.EmbeddingInstructionsLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.EmbeddingInstructionsLbl.Name = "EmbeddingInstructionsLbl";
            this.EmbeddingInstructionsLbl.Size = new System.Drawing.Size(230, 26);
            this.EmbeddingInstructionsLbl.TabIndex = 0;
            this.EmbeddingInstructionsLbl.Text = "Embed into a text file a digital watermark that is generated based on a keyword.";
            // 
            // EmbeddingKeywordLbl
            // 
            this.EmbeddingKeywordLbl.AutoSize = true;
            this.EmbeddingKeywordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbeddingKeywordLbl.Location = new System.Drawing.Point(6, 52);
            this.EmbeddingKeywordLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmbeddingKeywordLbl.Name = "EmbeddingKeywordLbl";
            this.EmbeddingKeywordLbl.Size = new System.Drawing.Size(51, 13);
            this.EmbeddingKeywordLbl.TabIndex = 0;
            this.EmbeddingKeywordLbl.Text = "Keyword:";
            // 
            // EmbeddingKeywordTxtBx
            // 
            this.EmbeddingKeywordTxtBx.Location = new System.Drawing.Point(63, 49);
            this.EmbeddingKeywordTxtBx.Name = "EmbeddingKeywordTxtBx";
            this.EmbeddingKeywordTxtBx.Size = new System.Drawing.Size(193, 20);
            this.EmbeddingKeywordTxtBx.TabIndex = 1;
            // 
            // DetectingInstructionsLbl
            // 
            this.DetectingInstructionsLbl.AutoSize = true;
            this.DetectingInstructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectingInstructionsLbl.Location = new System.Drawing.Point(6, 16);
            this.DetectingInstructionsLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.DetectingInstructionsLbl.Name = "DetectingInstructionsLbl";
            this.DetectingInstructionsLbl.Size = new System.Drawing.Size(238, 26);
            this.DetectingInstructionsLbl.TabIndex = 0;
            this.DetectingInstructionsLbl.Text = "Attempt to detect a digital watermark in a text file using the watermark\'s associ" +
                "ated keyword.";
            // 
            // DetectingKeywordLbl
            // 
            this.DetectingKeywordLbl.AutoSize = true;
            this.DetectingKeywordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectingKeywordLbl.Location = new System.Drawing.Point(6, 52);
            this.DetectingKeywordLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DetectingKeywordLbl.Name = "DetectingKeywordLbl";
            this.DetectingKeywordLbl.Size = new System.Drawing.Size(51, 13);
            this.DetectingKeywordLbl.TabIndex = 2;
            this.DetectingKeywordLbl.Text = "Keyword:";
            // 
            // DetectingKeywordTxtBx
            // 
            this.DetectingKeywordTxtBx.Location = new System.Drawing.Point(63, 49);
            this.DetectingKeywordTxtBx.Name = "DetectingKeywordTxtBx";
            this.DetectingKeywordTxtBx.Size = new System.Drawing.Size(193, 20);
            this.DetectingKeywordTxtBx.TabIndex = 2;
            // 
            // EmbedWatermarkBtn
            // 
            this.EmbedWatermarkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbedWatermarkBtn.Location = new System.Drawing.Point(181, 75);
            this.EmbedWatermarkBtn.Name = "EmbedWatermarkBtn";
            this.EmbedWatermarkBtn.Size = new System.Drawing.Size(75, 23);
            this.EmbedWatermarkBtn.TabIndex = 2;
            this.EmbedWatermarkBtn.Text = "Embed";
            this.EmbedWatermarkBtn.UseVisualStyleBackColor = true;
            this.EmbedWatermarkBtn.Click += new System.EventHandler(this.EmbedWatermarkBtn_Click);
            // 
            // DetectWatermarkBtn
            // 
            this.DetectWatermarkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectWatermarkBtn.Location = new System.Drawing.Point(181, 75);
            this.DetectWatermarkBtn.Name = "DetectWatermarkBtn";
            this.DetectWatermarkBtn.Size = new System.Drawing.Size(75, 23);
            this.DetectWatermarkBtn.TabIndex = 3;
            this.DetectWatermarkBtn.Text = "Detect";
            this.DetectWatermarkBtn.UseVisualStyleBackColor = true;
            this.DetectWatermarkBtn.Click += new System.EventHandler(this.DetectWatermarkBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 214);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(554, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 182);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(530, 23);
            this.progressBar.TabIndex = 7;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // TamperDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 236);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.InitialInstructionsLbl);
            this.Controls.Add(this.DetectWatermarkGrpBx);
            this.Controls.Add(this.EmbedWatermarkGrpBx);
            this.Controls.Add(this.BrowseForFileBtn);
            this.Controls.Add(this.FileLbl);
            this.Controls.Add(this.FileLocationTxtBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TamperDetectionForm";
            this.Text = "Tamper Detection Digital Watermark Demo";
            this.EmbedWatermarkGrpBx.ResumeLayout(false);
            this.EmbedWatermarkGrpBx.PerformLayout();
            this.DetectWatermarkGrpBx.ResumeLayout(false);
            this.DetectWatermarkGrpBx.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileLocationTxtBx;
        private System.Windows.Forms.Label FileLbl;
        private System.Windows.Forms.Button BrowseForFileBtn;
        private System.Windows.Forms.GroupBox EmbedWatermarkGrpBx;
        private System.Windows.Forms.Button EmbedWatermarkBtn;
        private System.Windows.Forms.TextBox EmbeddingKeywordTxtBx;
        private System.Windows.Forms.Label EmbeddingKeywordLbl;
        private System.Windows.Forms.Label EmbeddingInstructionsLbl;
        private System.Windows.Forms.GroupBox DetectWatermarkGrpBx;
        private System.Windows.Forms.Button DetectWatermarkBtn;
        private System.Windows.Forms.TextBox DetectingKeywordTxtBx;
        private System.Windows.Forms.Label DetectingKeywordLbl;
        private System.Windows.Forms.Label DetectingInstructionsLbl;
        private System.Windows.Forms.Label InitialInstructionsLbl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}