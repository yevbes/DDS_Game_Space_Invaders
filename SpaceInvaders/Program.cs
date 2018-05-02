using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
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
            Principal principal = new Principal();
            principal.FormBorderStyle = FormBorderStyle.FixedSingle;
            Application.Run(principal);
            // Comentario prueba
        }
    }
}
