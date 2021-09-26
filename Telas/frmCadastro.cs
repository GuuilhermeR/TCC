using System;
using MaterialSkin;
using MaterialSkin.Controls;
using static Classes.HelperFuncoes;

namespace TCC2.Telas
{
    public partial class frmCadastro : MaterialForm
    {
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly Random _rng = new Random();

        public frmCadastro()
        {
            InitializeComponent();
            FormatView(this);
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
               nMensagemAlerta("É necessário informar se você é Nutricionista/Estudante");
                return;
            }

            if (mLblUsuario.Text == "")
            {
                nMensagemAlerta("É necessário informar o usuário");
                return;
            }
            
            if (mLblSenha.Text == "")
            {
                nMensagemAlerta("É necessário informar uma senha");
                return;
            }

            if (txtConfirmarSenha.Text.Equals(mLblSenha.Text))
            {
                nMensagemAlerta("As senhas não conferem.");
                return;
            }

            usuarioDAO.CriarUsuario(Convert.ToString(mLblUsuario.Text), 
                                                  Convert.ToString(mLblSenha.Text), 
                                                  Convert.ToString(mTxtNome.Text),
                                                  Convert.ToString(mLblEmail.Text),
                                                  "ATIVO",
                                                  tipoPerfil,
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

        private void mTxtNome_Leave(object sender, EventArgs e)
        {
            mLblUsuario.Text = "";
            if (mLblUsuario.Text == "")
                mLblUsuario.Text = RandomString();
        }
    }
}
