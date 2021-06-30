using System;
using MaterialSkin;
using MaterialSkin.Controls;
using static Classes.ExibidorMensagem;

namespace TCC2.Telas
{
    public partial class frmCadastro : MaterialForm
    {
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly Random _rng = new Random();

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
                tipoPerfil = "Estudante";
            else if (mchkNutricionista.Checked)
                tipoPerfil = "Nutricionista";
            else
            {
               nMensagemAlerta("É necessário informar se você é Estudante/Nutricionista");
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

        private string RandomString()
        {
            string nomeUsuario = mTxtNome.Text.ToString();
            nomeUsuario = nomeUsuario.Replace(" ","");
            char[] buffer = new char[5];

            if(nomeUsuario.Length > 0)
            for (int i = 0; i < 5; i++)
            {
                buffer[i] = nomeUsuario[_rng.Next(nomeUsuario.Length)];
            }
            return new string(buffer).ToLower();
        }

        private void mchkNutricionista_CheckedChanged(object sender, EventArgs e)
        {
            if (mchkNutricionista.Checked)
                mtxtCRN.Visible = true;
            else
                mtxtCRN.Visible = false;
        }
    }
}
