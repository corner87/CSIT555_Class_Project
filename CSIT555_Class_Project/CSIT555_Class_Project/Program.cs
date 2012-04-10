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
using System.Linq;
using System.Windows.Forms;

namespace CSIT555_Class_Project
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Program. </summary>
    ///
    /// <remarks>   Laura Schanno, 4/9/2012. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    static class Program
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Main entry-point for this application. </summary>
        ///
        /// <remarks>   Laura Schanno, 4/9/2012. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
