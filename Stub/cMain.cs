using System;
using System.Windows.Forms;

namespace Stub
{
    static class cMain
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show(Properties.Resources.msg);
        }
    }
}
