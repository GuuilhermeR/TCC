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

        [Obsolete]
        private void mBtnCadastrar_Click(object sender, EventArgs e)
        {

            string tipoPerfil = "";

            if (mchkEstudante.Checked)
            {
                tipoPerfil = "Estudante";
            }
            else if (mchkNutricionista.Checked)
            {
                tipoPerfil = "Nutricionista";
            }
            else
            {
                MessageBox.Show("É necessário informar se você é Estudante/Nutricionista");
                return;
            }

            //if (mLblNome.Text == "")
            
            //if (mLblSenha.Text == "")

            //if (mchkNutricionista.Checked)
            //            if (mtxtCRN.Text =="")

                usuarioDAO.CriarUsuario(Convert.ToString(mLblUsuario.Text), 
                                                  Convert.ToString(mLblSenha.Text), 
                                                  Convert.ToString(mTxtNome.Text),
                                                  Convert.ToString(mLblEmail.Text),
                                                  tipoPerfil,
                                                  "ATIVO", 
                                                  false, 
                                                  Convert.ToString(mtxtCRN.Text));
            this.Close();
        }

        private void mchkEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (mchkEstudante.Checked)
                mtxtCRN.Visible = false;
            else
                mtxtCRN.Visible = true;
        }

        private void mLblUsuario_Leave(object sender, EventArgs e)
        {
            if (mLblUsuario.Text == "")
                mLblUsuario.Text = RandomString();
        }

        private readonly Random _rng = new Random();

        private string RandomString()
        {
            string nomeUsuario = mTxtNome.Text.ToString();
            nomeUsuario = nomeUsuario.Trim();
            char[] buffer = new char[5];

            for (int i = 0; i < 5; i++)
            {
                buffer[i] = nomeUsuario[_rng.Next(nomeUsuario.Length)];
            }
            return new string(buffer).ToLower();
        }

    }
}
