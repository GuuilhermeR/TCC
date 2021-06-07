using Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TCC2
{
    public partial class frmTelaLogin : MaterialForm
    {
        public UsuarioDAO usuario = new UsuarioDAO();
        public Criptografor descriptografar = new Criptografor();

        public frmTelaLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

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

            if ((bool)usuario.loginUsuario(txtUsuario.Text, txtSenha.Text))
            {
                usuario.setUsuario(txtUsuario.Text);
                usuario.setNomeUsuario(txtUsuario.Text);
                usuario.setUsuarioSenha(descriptografar.DescriptPassword(txtSenha.Text));
                var usuarioLogado = usuario.getUsuario();
                frmMenuPrincipal menu = new frmMenuPrincipal(usuarioLogado.ToString());
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

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
                if (txtSenha.Text != "")
                    btnLogar_Click(sender, e);
        }

      

        

    }
}
