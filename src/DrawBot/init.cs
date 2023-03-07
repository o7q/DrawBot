using System;
using System.Windows.Forms;

namespace DrawBot
{
    internal static class init
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new program());
        }
    }
}