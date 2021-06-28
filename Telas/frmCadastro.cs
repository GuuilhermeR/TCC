using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TCC2.Telas
{
    public partial class frmCadastro : MaterialForm
    {

        public UsuarioDAO usuarioDAO = new UsuarioDAO();

        public frmCadastro()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);

            this.MaximizeBox = false;

        }

        private void mBtnCadastrar_Click(object sender, EventArgs e)
        {

            string tipoPerfil = "";

            if (mchkEstudante.Checked)
                tipoPerfil = "Estudante";
            else
                tipoPerfil = "Nutricionista";

            usuarioDAO.CriarUsuario(Convert.ToString(mLblUsuario.Text), 
                                                  Convert.ToString(mLblSenha.Text), 
                                                  Convert.ToString(mLblNome.Text),
                                                  Convert.ToString(mLblEmail.Text),
                                                  tipoPerfil,
                                                  "ATIVO", 
                                                  false, 
                                                  Convert.ToString(mLblCRN.Text));
        }
    }
}
