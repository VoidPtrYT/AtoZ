#region Includes
using System;
using System.Windows.Forms;
#endregion

namespace AtoZ.Core
{
    /// <summary>
    /// Main class of programm
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main entry to application
        /// </summary>
        /// <returns>0 if programm ends correct. 1 if error</returns>
        [STAThread]
        private static int Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Fatal error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 1;
            }
            return 0;
        }
    }
}
