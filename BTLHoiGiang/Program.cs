using System;
using System.Windows.Forms;

namespace BTLHoiGiang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.FrmMain());
        }
    }
}
