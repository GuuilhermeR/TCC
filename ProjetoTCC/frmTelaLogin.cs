using System;
using System.Data.SQLite;
using MaterialSkin;
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
            _btnLogin.Name = "btnLogin";
            _txtLogin.Name = "_txtLogin";
            _txtSenha.Name = "_txtSenha";
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        public UsuarioDAO usuario = new UsuarioDAO();


        private void _txtLogin_Leave(object sender, EventArgs e)
        {
            _txtLogin.Text = Strings.LCase(_txtLogin.Text);
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void frmTelaLogin_Resize(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtLogin.Text))
            {
                Interaction.MsgBox("O campo de login não deve ficar em branco!");
                return;
            }

            if (string.IsNullOrEmpty(_txtSenha.Text))
            {
                Interaction.MsgBox("O campo de senha não deve ficar em branco!");
                return;
            }

            if (Convert.ToBoolean(usuario.verificarUsuarioLogado(_txtLogin.Text, _txtSenha.Text)) == false)
            {
                lblLoginErrado.Visible = true;
                return;
            }

            lblLoginErrado.Visible = false;
            usuario.setUsuario(_txtLogin.Text);
            usuario.setUsuarioSenha(_txtSenha.Text);
            usuario.setNomeUsuario(_txtLogin.Text);

            var menu = new frmMenuPrincipal();
            menu.Show();
            Hide();
        }

        private void _txtSenha_Enter(object sender, EventArgs e)
        {
            _txtSenha.Text = "";
            _txtSenha.PasswordChar = '*';
        }
    }
}