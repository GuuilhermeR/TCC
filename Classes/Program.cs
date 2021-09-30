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
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FrmMenuPrincipal("guilherme"));
            //Application.Run(new frmTelaLogin());
            //Application.Run(new frmCadastro());
            //Application.Run(new frmEsqueciSenha());
            //Application.Run(new frmWait());
            //Application.Run(new frmTemplatesAnamnese());
        }
    }
}
