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

namespace CSIT555_Class_Project
{
    public partial class TamperDetectionForm : Form
    {   
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes a new instance of the TamperDetectionForm class. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public TamperDetectionForm()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by BrowseForFileBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BrowseForFileBtn_Click(object sender, EventArgs e)
        {
            TamperOpenFileDialog.ShowDialog();
            FileLocationTxtBx.Text = TamperOpenFileDialog.FileName;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by EmbedWatermarkBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedWatermarkBtn_Click(object sender, EventArgs e)
        {
            EmbedWatermarkBtn.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DetectWatermarkBtn for click events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectWatermarkBtn_Click(object sender, EventArgs e)
        {
            DetectWatermarkBtn.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by EmbedBackgroundWorker for do work events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
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
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
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
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EmbedBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DetectBackgroundWorker for do work events. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
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
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
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
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Tamper detection settings. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private class TamperDetectionSettings {
            
            private static string FilePath = "";
            private static string KeyWord = "";

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// <summary>   Initializes a new instance of the TamperDetectionSettings class. </summary>
            ///
            /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            public TamperDetectionSettings() { }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// <summary>   Initializes a new instance of the TamperDetectionSettings class. </summary>
            ///
            /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
            ///
            /// <param name="newFilePath">  Full pathname of the new file. </param>
            /// <param name="newKeyWord">   The new key word. </param>
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            public TamperDetectionSettings(string newFilePath, string newKeyWord) {
                FilePath = newFilePath;
                KeyWord = newKeyWord;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// <summary>   Gets the file path. </summary>
            ///
            /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
            ///
            /// <returns>   The file path. </returns>
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            public static string getFilePath() {
                return FilePath;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// <summary>   Gets the key word. </summary>
            ///
            /// <remarks>   Laura Schanno, 4/11/2012. </remarks>
            ///
            /// <returns>   The key word. </returns>
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            public static string getKeyWord() {
                return KeyWord;
            }
        }

    }
}
