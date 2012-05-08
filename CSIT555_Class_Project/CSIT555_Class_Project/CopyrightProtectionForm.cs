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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CSIT555_Class_Project
{
    public partial class CopyrightProtectionForm : Form
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes a new instance of the CopyrightProtectionForm class. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public CopyrightProtectionForm()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by BrowseForFileBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BrowseForFileBtn_Click(object sender, EventArgs e)
        {
            CopyrightOpenFileDialog.ShowDialog();
            FileLocationTxtBx.Text = CopyrightOpenFileDialog.FileName;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by EmbedBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedBtn_Click(object sender, EventArgs e)
        {
            string watermark = OwnerTxtBx.Text + " " + CorporationTxtBx.Text + " " + DateTxtBx.Text;
            System.Drawing.Bitmap bmp = WaterMarkerImage(FileLocationTxtBx.Text, watermark);
           bmp.Save("c:/Users/Ken/Documents/output.jpg"); 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DetectBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectBtn_Click(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DetectBackgroundWorker for do work events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Event handler. Called by DetectBackgroundWorker for progress changed events.
        /// </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Event handler. Called by DetectBackgroundWorker for run worker completed events.
        /// </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by EmbedBackgroundWorker for do work events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Event handler. Called by EmbedBackgroundWorker for progress changed events.
        /// </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Event handler. Called by EmbedBackgroundWorker for run worker completed events.
        /// </summary>
        ///
        /// <remarks>   Laura Schanno, 4/18/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Method to watermark image
        /// </summary>
        ///
        /// <remarks>   Ken Hofgesang, 5/7/2012 </remarks>
        ///
        /// <param name="ImgPath">   Path for Source Image. </param>
        /// <param name="watermark">        String for watermark information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
    
        public static Bitmap WaterMarkerImage(string ImgPath, string watermark)
        {
            Bitmap bmp;
            bmp = new Bitmap(ImgPath);
            Graphics graphicsObject;
            int x, y;
            try
            {
                //Create graphics object from bitmap            
                graphicsObject = Graphics.FromImage(bmp);
            }
            catch (Exception e)
            {
                //Initilize new Bitmap for watermark info
                Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
                graphicsObject = Graphics.FromImage(bmpNew);
                graphicsObject.DrawImage(bmp, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
                bmp = bmpNew;
            }
            //Adjust font size based on original image size and the length of watermark text
            int startsize = (bmp.Width / watermark.Length);
            //x and y cordinates to draw watermark string      
            x = 0;
            y = bmp.Height / 4;

            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.NoWrap);
            //Draw watermark on Image        
            graphicsObject.DrawString(watermark, new Font("Times New Roman", startsize, FontStyle.Bold), new SolidBrush(Color.FromArgb(60, 255, 255, 255)), x, y, drawFormat);
            //return Image
            return (bmp);
        }

        private void FileLocationTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnerTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
