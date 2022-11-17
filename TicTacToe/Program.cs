using System;
using System.Windows.Forms;

namespace TicTacToe
{
    internal static class Program
    {
        public static MainFrame MainApplicationFrame;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainApplicationFrame = new MainFrame());
        }
    }
}
