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
            if (txtNome.Text != "")
            usuario.Buscar(txtUsuario.Text,dtgUsuarios);
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            CriarColunas();
            usuario.Buscar("", dtgUsuarios);
        }

        private void CriarColunas()
        {
            if (dtgUsuarios.Columns.Count <= 0)
            {
                dtgUsuarios.Columns.Add("usuario", "Usuário");
                dtgUsuarios.Columns.Add("nome", "Nome");
                dtgUsuarios.Columns.Add("email", "E-mail");
                dtgUsuarios.Columns.Add("situacao", "Situação");
                dtgUsuarios.Columns.Add("tipoUsuario", "Perfil");
            }
        }

        private void dtgUsuarios_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0 && e.ColumnIndex >= 0)
            {
                txtUsuario.Text = dtgUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
                txtNome.Text = dtgUsuarios.CurrentRow.Cells["nome"].Value.ToString();
                txtEmail.Text = dtgUsuarios.CurrentRow.Cells["email"].Value.ToString();
                cbxSituacao.Text = dtgUsuarios.CurrentRow.Cells["situacao"].Value.ToString();
                cbxTipoUsuario.Text = dtgUsuarios.CurrentRow.Cells["tipoUsuario"].Value.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool alterarSenha = false;
            if (txtUsuario.Text == "")
            {
                Interaction.MsgBox("O usuário não foi informado");
                return;
            }
            if (txtSenha.Text == "")
            {
                Interaction.MsgBox("O campo senha não foi informado");
                return;
            }
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Interaction.MsgBox("As senhas não conferem");
                return;
            }
           

            if (usuario.VerificarExisteUsuario(txtUsuario.Text)==false)
            {
               // usuario.CriarUsuario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text);
            }
            else
            {
                if (Interaction.MsgBox("Você deseja alterar a senha do usuário?", MsgBoxStyle.YesNo, "ALTERAÇÃO DE SENHA") == MsgBoxResult.Yes)
                    alterarSenha = true;
                usuario.AlterarUsuario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha);

            }

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '*';
        }
    }
}