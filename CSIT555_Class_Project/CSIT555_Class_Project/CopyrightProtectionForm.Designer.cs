/////////////////////////////////////////////////////////////////////////////////////////////////
/// This file is part of CSIT 555 Digital Watermarks Demo.
///
/// CSIT 555 Digital Watermarks Demo is free software: you can 
/// redistribute it and/or modify it under the terms of the GNU 
/// General Public License as published by the Free Software 
/// Foundation, either version 3 of the License, or (at your 
/// option) any later version.
///
/// CSIT 555 Digital Watermarks Demo is distributed in the hope 
/// that it will be useful, but WITHOUT ANY WARRANTY; without even 
/// the implied warranty of MERCHANTABILITY or FITNESS FOR A 
/// PARTICULAR PURPOSE.  See the GNU General Public License for 
/// more details.
///
/// You should have received a copy of the GNU General Public 
/// License along with CSIT 555 Digital Watermarks Demo.  If not, 
/// see <http://www.gnu.org/licenses/>.
/////////////////////////////////////////////////////////////////////////////////////////////////

namespace CSIT555_Class_Project
{
    partial class CopyrightProtectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyrightProtectionForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InitialInstructionsLbl = new System.Windows.Forms.Label();
            this.BrowseForFileBtn = new System.Windows.Forms.Button();
            this.FileLbl = new System.Windows.Forms.Label();
            this.FileLocationTxtBx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OwnerLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.OwnerTxtBx = new System.Windows.Forms.TextBox();
            this.DateTxtBx = new System.Windows.Forms.TextBox();
            this.CorporationLbl = new System.Windows.Forms.Label();
            this.CorporationTxtBx = new System.Windows.Forms.TextBox();
            this.EmbedBtn = new System.Windows.Forms.Button();
            this.DateFormatLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmbeddingInstructionsLbl = new System.Windows.Forms.Label();
            this.DetectingInstructionsLbl = new System.Windows.Forms.Label();
            this.DetectedCopyrightInformationTxtBx = new System.Windows.Forms.TextBox();
            this.DetectBtn = new System.Windows.Forms.Button();
            this.EmbedBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.DetectBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.CopyrightOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(554, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // InitialInstructionsLbl
            // 
            this.InitialInstructionsLbl.AutoSize = true;
            this.InitialInstructionsLbl.Location = new System.Drawing.Point(12, 9);
            this.InitialInstructionsLbl.MaximumSize = new System.Drawing.Size(530, 0);
            this.InitialInstructionsLbl.Name = "InitialInstructionsLbl";
            this.InitialInstructionsLbl.Size = new System.Drawing.Size(524, 26);
            this.InitialInstructionsLbl.TabIndex = 6;
            this.InitialInstructionsLbl.Text = resources.GetString("InitialInstructionsLbl.Text");
            // 
            // BrowseForFileBtn
            // 
            this.BrowseForFileBtn.Location = new System.Drawing.Point(467, 36);
            this.BrowseForFileBtn.Name = "BrowseForFileBtn";
            this.BrowseForFileBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseForFileBtn.TabIndex = 9;
            this.BrowseForFileBtn.Text = "Browse";
            this.BrowseForFileBtn.UseVisualStyleBackColor = true;
            this.BrowseForFileBtn.Click += new System.EventHandler(this.BrowseForFileBtn_Click);
            // 
            // FileLbl
            // 
            this.FileLbl.AutoSize = true;
            this.FileLbl.Location = new System.Drawing.Point(12, 41);
            this.FileLbl.Name = "FileLbl";
            this.FileLbl.Size = new System.Drawing.Size(26, 13);
            this.FileLbl.TabIndex = 8;
            this.FileLbl.Text = "File:";
            // 
            // FileLocationTxtBx
            // 
            this.FileLocationTxtBx.Location = new System.Drawing.Point(44, 38);
            this.FileLocationTxtBx.Name = "FileLocationTxtBx";
            this.FileLocationTxtBx.Size = new System.Drawing.Size(417, 20);
            this.FileLocationTxtBx.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmbeddingInstructionsLbl);
            this.groupBox1.Controls.Add(this.DateFormatLbl);
            this.groupBox1.Controls.Add(this.EmbedBtn);
            this.groupBox1.Controls.Add(this.CorporationTxtBx);
            this.groupBox1.Controls.Add(this.CorporationLbl);
            this.groupBox1.Controls.Add(this.DateTxtBx);
            this.groupBox1.Controls.Add(this.OwnerTxtBx);
            this.groupBox1.Controls.Add(this.DateLbl);
            this.groupBox1.Controls.Add(this.OwnerLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 118);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Embed Watermark";
            // 
            // OwnerLbl
            // 
            this.OwnerLbl.AutoSize = true;
            this.OwnerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLbl.Location = new System.Drawing.Point(36, 39);
            this.OwnerLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.OwnerLbl.Name = "OwnerLbl";
            this.OwnerLbl.Size = new System.Drawing.Size(41, 13);
            this.OwnerLbl.TabIndex = 0;
            this.OwnerLbl.Text = "Owner:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(331, 65);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(33, 13);
            this.DateLbl.TabIndex = 1;
            this.DateLbl.Text = "Date:";
            // 
            // OwnerTxtBx
            // 
            this.OwnerTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerTxtBx.Location = new System.Drawing.Point(83, 36);
            this.OwnerTxtBx.Name = "OwnerTxtBx";
            this.OwnerTxtBx.Size = new System.Drawing.Size(242, 20);
            this.OwnerTxtBx.TabIndex = 2;
            // 
            // DateTxtBx
            // 
            this.DateTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTxtBx.Location = new System.Drawing.Point(370, 62);
            this.DateTxtBx.Name = "DateTxtBx";
            this.DateTxtBx.Size = new System.Drawing.Size(82, 20);
            this.DateTxtBx.TabIndex = 3;
            // 
            // CorporationLbl
            // 
            this.CorporationLbl.AutoSize = true;
            this.CorporationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorporationLbl.Location = new System.Drawing.Point(13, 65);
            this.CorporationLbl.Name = "CorporationLbl";
            this.CorporationLbl.Size = new System.Drawing.Size(64, 13);
            this.CorporationLbl.TabIndex = 4;
            this.CorporationLbl.Text = "Corporation:";
            // 
            // CorporationTxtBx
            // 
            this.CorporationTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorporationTxtBx.Location = new System.Drawing.Point(83, 62);
            this.CorporationTxtBx.Name = "CorporationTxtBx";
            this.CorporationTxtBx.Size = new System.Drawing.Size(242, 20);
            this.CorporationTxtBx.TabIndex = 5;
            // 
            // EmbedBtn
            // 
            this.EmbedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbedBtn.Location = new System.Drawing.Point(449, 88);
            this.EmbedBtn.Name = "EmbedBtn";
            this.EmbedBtn.Size = new System.Drawing.Size(75, 23);
            this.EmbedBtn.TabIndex = 6;
            this.EmbedBtn.Text = "Embed";
            this.EmbedBtn.UseVisualStyleBackColor = true;
            this.EmbedBtn.Click += new System.EventHandler(this.EmbedBtn_Click);
            // 
            // DateFormatLbl
            // 
            this.DateFormatLbl.AutoSize = true;
            this.DateFormatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFormatLbl.Location = new System.Drawing.Point(458, 65);
            this.DateFormatLbl.Name = "DateFormatLbl";
            this.DateFormatLbl.Size = new System.Drawing.Size(61, 13);
            this.DateFormatLbl.TabIndex = 7;
            this.DateFormatLbl.Text = "mm-dd-yyyy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DetectBtn);
            this.groupBox2.Controls.Add(this.DetectedCopyrightInformationTxtBx);
            this.groupBox2.Controls.Add(this.DetectingInstructionsLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detect Watermark";
            // 
            // EmbeddingInstructionsLbl
            // 
            this.EmbeddingInstructionsLbl.AutoSize = true;
            this.EmbeddingInstructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbeddingInstructionsLbl.Location = new System.Drawing.Point(6, 16);
            this.EmbeddingInstructionsLbl.Name = "EmbeddingInstructionsLbl";
            this.EmbeddingInstructionsLbl.Size = new System.Drawing.Size(402, 13);
            this.EmbeddingInstructionsLbl.TabIndex = 8;
            this.EmbeddingInstructionsLbl.Text = "Enter the following copyright information that you want embedded into the image f" +
    "ile.";
            // 
            // DetectingInstructionsLbl
            // 
            this.DetectingInstructionsLbl.AutoSize = true;
            this.DetectingInstructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectingInstructionsLbl.Location = new System.Drawing.Point(6, 16);
            this.DetectingInstructionsLbl.Name = "DetectingInstructionsLbl";
            this.DetectingInstructionsLbl.Size = new System.Drawing.Size(499, 13);
            this.DetectingInstructionsLbl.TabIndex = 1;
            this.DetectingInstructionsLbl.Text = "Click the Detect button to search for copyright information. Any information foun" +
    "d will be displayed below.";
            // 
            // DetectedCopyrightInformationTxtBx
            // 
            this.DetectedCopyrightInformationTxtBx.Location = new System.Drawing.Point(6, 32);
            this.DetectedCopyrightInformationTxtBx.Multiline = true;
            this.DetectedCopyrightInformationTxtBx.Name = "DetectedCopyrightInformationTxtBx";
            this.DetectedCopyrightInformationTxtBx.ReadOnly = true;
            this.DetectedCopyrightInformationTxtBx.Size = new System.Drawing.Size(518, 76);
            this.DetectedCopyrightInformationTxtBx.TabIndex = 2;
            // 
            // DetectBtn
            // 
            this.DetectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectBtn.Location = new System.Drawing.Point(449, 114);
            this.DetectBtn.Name = "DetectBtn";
            this.DetectBtn.Size = new System.Drawing.Size(75, 23);
            this.DetectBtn.TabIndex = 3;
            this.DetectBtn.Text = "Detect";
            this.DetectBtn.UseVisualStyleBackColor = true;
            this.DetectBtn.Click += new System.EventHandler(this.DetectBtn_Click);
            // 
            // EmbedBackgroundWorker
            // 
            this.EmbedBackgroundWorker.WorkerReportsProgress = true;
            this.EmbedBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EmbedBackgroundWorker_DoWork);
            this.EmbedBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EmbedBackgroundWorker_ProgressChanged);
            this.EmbedBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EmbedBackgroundWorker_RunWorkerCompleted);
            // 
            // DetectBackgroundWorker
            // 
            this.DetectBackgroundWorker.WorkerReportsProgress = true;
            this.DetectBackgroundWorker.WorkerSupportsCancellation = true;
            this.DetectBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DetectBackgroundWorker_DoWork);
            this.DetectBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DetectBackgroundWorker_ProgressChanged);
            this.DetectBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DetectBackgroundWorker_RunWorkerCompleted);
            // 
            // CopyrightOpenFileDialog
            // 
            this.CopyrightOpenFileDialog.FileName = "CopyrightOpenFileDialog";
            this.CopyrightOpenFileDialog.Filter = "JPEG Files|*.jpg, *.jpeg";
            this.CopyrightOpenFileDialog.InitialDirectory = "Application.ExecutablePath";
            this.CopyrightOpenFileDialog.Title = "Open File";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 337);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(530, 23);
            this.progressBar.TabIndex = 12;
            // 
            // CopyrightProtectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 388);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BrowseForFileBtn);
            this.Controls.Add(this.FileLbl);
            this.Controls.Add(this.FileLocationTxtBx);
            this.Controls.Add(this.InitialInstructionsLbl);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CopyrightProtectionForm";
            this.Text = "Copyright Protection Digital Watermark Demo";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label InitialInstructionsLbl;
        private System.Windows.Forms.Button BrowseForFileBtn;
        private System.Windows.Forms.Label FileLbl;
        private System.Windows.Forms.TextBox FileLocationTxtBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CorporationTxtBx;
        private System.Windows.Forms.Label CorporationLbl;
        private System.Windows.Forms.TextBox DateTxtBx;
        private System.Windows.Forms.TextBox OwnerTxtBx;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label OwnerLbl;
        private System.Windows.Forms.Label DateFormatLbl;
        private System.Windows.Forms.Button EmbedBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EmbeddingInstructionsLbl;
        private System.Windows.Forms.Label DetectingInstructionsLbl;
        private System.Windows.Forms.Button DetectBtn;
        private System.Windows.Forms.TextBox DetectedCopyrightInformationTxtBx;
        private System.ComponentModel.BackgroundWorker EmbedBackgroundWorker;
        private System.ComponentModel.BackgroundWorker DetectBackgroundWorker;
        private System.Windows.Forms.OpenFileDialog CopyrightOpenFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}