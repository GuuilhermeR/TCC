using Microsoft.VisualBasic;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class frmConfiguracoes
    {

        public UsuarioDAO usuario = new UsuarioDAO();
        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
           
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            
        }


        private void dtgUsuarios_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            
        }


        private void txtSenha_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}