using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class frmMenuPrincipal
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            _BtnPacientes.Name = "BtnPacientes";
            _btnDeslogar.Name = "btnDeslogar";
            _btnAgenda.Name = "btnAgenda";
            _btnOcultar.Name = "btnOcultar";
            _btnConfig.Name = "btnConfig";
            _btnCadAlimento.Name = "btnCadAlimento";
            _btnCadCardapio.Name = "btnCadCardapio";
            _btnMostrar.Name = "btnMostrar";
        }

        private void btnCadastrarAlimento_Click(object sender, EventArgs e)
        {
            var frmCadastroAlimento = new frmAlimento();
            frmCadastroAlimento.Show();
        }

        private void btnConsultarAlimentos_Click(object sender, EventArgs e)
        {
            var frmConfiguracoes = new frmConfiguracoes();
            frmConfiguracoes.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Seja bem vindo(a) ao sistema {My.MyProject.Forms.frmTelaLogin.usuario.getNomeUsuario()}";
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pnlBotoes.Hide();
            btnMostrar.Show();
            btnOcultar.Hide();
            pbxLogoGrande.Location = new Point(295, 120);
            lblNomeApp.Location = new Point(375, 470);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pnlBotoes.Show();
            btnMostrar.Hide();
            btnOcultar.Show();
            pbxLogoGrande.Location = new Point(385, 120);
            lblNomeApp.Location = new Point(462, 470);
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            var frmCadPaciente = new frmPaciente();
            frmCadPaciente.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            var frmPaciente = new frmPaciente();
            frmPaciente.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var frmConfiguracoes = new frmConfiguracoes();
            frmConfiguracoes.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            var frmAgenda = new frmAgenda();
            frmAgenda.Show();
        }

        private void btnCadCardapio_Click(object sender, EventArgs e)
        {
            var frmPlanilhaCardapio = new frmPlanilhaCardapio();
            frmPlanilhaCardapio.Show();
        }
    }
}