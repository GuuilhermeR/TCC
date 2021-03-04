using System;

namespace ProjetoTCC
{
    public partial class frmConfiguracoes
    {

        public UsuarioDAO usuario = new UsuarioDAO();
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            usuario.Buscar(txtUsuario.Text,dtgUsuarios);
        }
    }
}