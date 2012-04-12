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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InitialInstructionsLbl = new System.Windows.Forms.Label();
            this.TamperDetectionBtn = new System.Windows.Forms.Button();
            this.CopyrightProtectionBtn = new System.Windows.Forms.Button();
            this.SourceTrackingBtn = new System.Windows.Forms.Button();
            this.TamperDetectionDescriptionLbl = new System.Windows.Forms.Label();
            this.CopyrightProtectionDescriptionLbl = new System.Windows.Forms.Label();
            this.SourceTrackingDescriptionLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.WindowToolStripMenuItem.Text = "Window";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // InitialInstructionsLbl
            // 
            this.InitialInstructionsLbl.AutoSize = true;
            this.InitialInstructionsLbl.Location = new System.Drawing.Point(12, 24);
            this.InitialInstructionsLbl.Name = "InitialInstructionsLbl";
            this.InitialInstructionsLbl.Padding = new System.Windows.Forms.Padding(5);
            this.InitialInstructionsLbl.Size = new System.Drawing.Size(266, 23);
            this.InitialInstructionsLbl.TabIndex = 2;
            this.InitialInstructionsLbl.Text = "Select a digital watermarking demonstration example.";
            // 
            // TamperDetectionBtn
            // 
            this.TamperDetectionBtn.Location = new System.Drawing.Point(15, 57);
            this.TamperDetectionBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TamperDetectionBtn.Name = "TamperDetectionBtn";
            this.TamperDetectionBtn.Size = new System.Drawing.Size(110, 23);
            this.TamperDetectionBtn.TabIndex = 3;
            this.TamperDetectionBtn.Text = "Tamper Detection";
            this.TamperDetectionBtn.UseVisualStyleBackColor = true;
            this.TamperDetectionBtn.Click += new System.EventHandler(this.TamperDetectionBtn_Click);
            // 
            // CopyrightProtectionBtn
            // 
            this.CopyrightProtectionBtn.Location = new System.Drawing.Point(12, 132);
            this.CopyrightProtectionBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CopyrightProtectionBtn.Name = "CopyrightProtectionBtn";
            this.CopyrightProtectionBtn.Size = new System.Drawing.Size(110, 23);
            this.CopyrightProtectionBtn.TabIndex = 4;
            this.CopyrightProtectionBtn.Text = "Copyright Protection";
            this.CopyrightProtectionBtn.UseVisualStyleBackColor = true;
            this.CopyrightProtectionBtn.Click += new System.EventHandler(this.CopyrightProtectionBtn_Click);
            // 
            // SourceTrackingBtn
            // 
            this.SourceTrackingBtn.Location = new System.Drawing.Point(12, 207);
            this.SourceTrackingBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.SourceTrackingBtn.Name = "SourceTrackingBtn";
            this.SourceTrackingBtn.Size = new System.Drawing.Size(113, 23);
            this.SourceTrackingBtn.TabIndex = 5;
            this.SourceTrackingBtn.Text = "Source Tracking";
            this.SourceTrackingBtn.UseVisualStyleBackColor = true;
            this.SourceTrackingBtn.Click += new System.EventHandler(this.SourceTrackingBtn_Click);
            // 
            // TamperDetectionDescriptionLbl
            // 
            this.TamperDetectionDescriptionLbl.AutoSize = true;
            this.TamperDetectionDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamperDetectionDescriptionLbl.Location = new System.Drawing.Point(39, 83);
            this.TamperDetectionDescriptionLbl.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.TamperDetectionDescriptionLbl.MaximumSize = new System.Drawing.Size(500, 0);
            this.TamperDetectionDescriptionLbl.MinimumSize = new System.Drawing.Size(500, 13);
            this.TamperDetectionDescriptionLbl.Name = "TamperDetectionDescriptionLbl";
            this.TamperDetectionDescriptionLbl.Size = new System.Drawing.Size(500, 39);
            this.TamperDetectionDescriptionLbl.TabIndex = 6;
            this.TamperDetectionDescriptionLbl.Text = resources.GetString("TamperDetectionDescriptionLbl.Text");
            // 
            // CopyrightProtectionDescriptionLbl
            // 
            this.CopyrightProtectionDescriptionLbl.AutoSize = true;
            this.CopyrightProtectionDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightProtectionDescriptionLbl.Location = new System.Drawing.Point(39, 158);
            this.CopyrightProtectionDescriptionLbl.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.CopyrightProtectionDescriptionLbl.MaximumSize = new System.Drawing.Size(500, 0);
            this.CopyrightProtectionDescriptionLbl.MinimumSize = new System.Drawing.Size(500, 13);
            this.CopyrightProtectionDescriptionLbl.Name = "CopyrightProtectionDescriptionLbl";
            this.CopyrightProtectionDescriptionLbl.Size = new System.Drawing.Size(500, 39);
            this.CopyrightProtectionDescriptionLbl.TabIndex = 7;
            this.CopyrightProtectionDescriptionLbl.Text = resources.GetString("CopyrightProtectionDescriptionLbl.Text");
            // 
            // SourceTrackingDescriptionLbl
            // 
            this.SourceTrackingDescriptionLbl.AutoSize = true;
            this.SourceTrackingDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTrackingDescriptionLbl.Location = new System.Drawing.Point(39, 233);
            this.SourceTrackingDescriptionLbl.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.SourceTrackingDescriptionLbl.MaximumSize = new System.Drawing.Size(500, 0);
            this.SourceTrackingDescriptionLbl.MinimumSize = new System.Drawing.Size(500, 13);
            this.SourceTrackingDescriptionLbl.Name = "SourceTrackingDescriptionLbl";
            this.SourceTrackingDescriptionLbl.Size = new System.Drawing.Size(500, 52);
            this.SourceTrackingDescriptionLbl.TabIndex = 8;
            this.SourceTrackingDescriptionLbl.Text = resources.GetString("SourceTrackingDescriptionLbl.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 307);
            this.Controls.Add(this.SourceTrackingDescriptionLbl);
            this.Controls.Add(this.CopyrightProtectionDescriptionLbl);
            this.Controls.Add(this.TamperDetectionDescriptionLbl);
            this.Controls.Add(this.SourceTrackingBtn);
            this.Controls.Add(this.CopyrightProtectionBtn);
            this.Controls.Add(this.TamperDetectionBtn);
            this.Controls.Add(this.InitialInstructionsLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CSIT 555 Digital Watermarks Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label InitialInstructionsLbl;
        private System.Windows.Forms.Button TamperDetectionBtn;
        private System.Windows.Forms.Button CopyrightProtectionBtn;
        private System.Windows.Forms.Button SourceTrackingBtn;
        private System.Windows.Forms.Label TamperDetectionDescriptionLbl;
        private System.Windows.Forms.Label CopyrightProtectionDescriptionLbl;
        private System.Windows.Forms.Label SourceTrackingDescriptionLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

