using System;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public partial class frmTelaLogin
    {
        public frmTelaLogin()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
            InitializeComponent();
            _txtLogin.Name = "txtLogin";
            _txtSenha.Name = "txtSenha";
            _btnLogin.Name = "btnLogin";
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        public UsuarioDAO usuario = new UsuarioDAO();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                Interaction.MsgBox("O campo de login não deve ficar em branco!");
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Interaction.MsgBox("O campo de senha não deve ficar em branco!");
                return;
            }

            if (Convert.ToBoolean(usuario.verificarUsuarioLogado(txtLogin.Text, txtSenha.Text))==false)
            {
                lblLoginErrado.Visible = true;
                return;
            }

            lblLoginErrado.Visible = false;
            usuario.setUsuario(txtLogin.Text);
            usuario.setUsuarioSenha(txtSenha.Text);
            usuario.setNomeUsuario(txtLogin.Text);

            var menu = new frmMenuPrincipal();
            menu.Show();
            Hide();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = Strings.LCase(txtLogin.Text);
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            //txtLogin.Text = "guilherme";
            //txtSenha.Text = "gui123";
            //btnLogin_Click(sender, e);
        }
    }
}