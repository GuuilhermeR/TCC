using Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TCC2.Telas;
using static Classes.HelperFuncoes;

namespace TCC2
{
    public partial class frmTelaLogin : MaterialForm
    {
        public UsuarioDAO usuario = new UsuarioDAO();
        public Criptografador descriptografar = new Criptografador();

        public frmTelaLogin()
        {
            InitializeComponent();
            FormatView(this);
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        [Obsolete]
        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            lblAviso.Visible = false;   
            if(txtUsuario.Text == "")
            {
               lblAviso.Text = "Informe o usuário.";
               lblAviso.Visible = true;
               lblAviso.ForeColor = Color.Red;
               return;
            }
            if (txtSenha.Text == "")
            {
                lblAviso.Text = "Informe a senha.";
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                return;
            }

            if ((bool)usuario.validarLogin(txtUsuario.Text, txtSenha.Text))
            {
                usuario.setUsuario(txtUsuario.Text);
                usuario.setNomeUsuario(txtUsuario.Text);
                usuario.setUsuarioSenha(txtSenha.Text);
                var usuarioLogado = usuario.getUsuario();
                FrmMenuPrincipal menu = new FrmMenuPrincipal(usuarioLogado.ToString());
                menu.Show();
                this.Hide();
            }
            else
            {
                lblAviso.Text = "Usuário/Senha incorreto.";
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
            }                        
        }

        [Obsolete]
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
                if (txtSenha.Text != "")
                    btnLogar_Click(sender, e);
        }

        private void mLblCriarConta_Click(object sender, EventArgs e)
        {
            using (frmCadastro cadastrar = new frmCadastro())
            {
                cadastrar.ShowDialog();
            }
        }

        [Obsolete]
        private void txtSenha_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogar_Click(sender, e);
            }
        }

        private void mLblEsqueciSenha_Click(object sender, EventArgs e)
        {
            using (frmEsqueciSenha esqueciSenha = new frmEsqueciSenha())
            {
                esqueciSenha.ShowDialog();
            }
        }
    }
}
