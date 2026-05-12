using System;
using System.Windows.Forms;

namespace WAVPlayer
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmWAVPlayer());
        }
    }
}
