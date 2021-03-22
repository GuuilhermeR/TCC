using MaterialSkin;
using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2
{
    public partial class frmTelaLogin : MaterialForm
    {
        public UsuarioDAO usuario = new UsuarioDAO();

        public frmTelaLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
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
                usuario.setUsuarioSenha(txtSenha.Text);
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
    }
}
