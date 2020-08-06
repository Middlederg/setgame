using System;
using System.Drawing;
using System.Windows.Forms;

namespace SetGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Set.Forms.Views.MenuView());
            //Application.Run(new Set.Forms.Views.FrmPrincipal(Dificultad.Normal, 15));
        }
    }
}
