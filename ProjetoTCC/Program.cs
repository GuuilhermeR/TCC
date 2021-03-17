using ProjetoTCC;
using System;
using System.Windows.Forms;

namespace TESTE
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
            //Application.Run(new frmTelaLogin());
            Application.Run(new frmMenu());
        }
    }
}
