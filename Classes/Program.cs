using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC2.Telas;

namespace TCC2
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
           //Application.Run(new frmMenuPrincipal("guilherme"));
            Application.Run(new frmTelaLogin());
            //Application.Run(new frmCadastro());
        }
    }
}
