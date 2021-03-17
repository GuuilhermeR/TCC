//using MaterialSkin;
//using System;
//using System.Windows.Forms;

//namespace ProjetoTCC
//{
//    public partial class frmMenuPrincipal
//    {
//        public frmMenuPrincipal()
//        {
//            InitializeComponent();
//            _BtnPacientes.Name = "BtnPacientes";
//            _btnDeslogar.Name = "btnDeslogar";
//            _btnAgenda.Name = "btnAgenda";
//            _btnConfig.Name = "btnConfig";
//            _btnCadAlimento.Name = "btnCadAlimento";
//            _btnCadCardapio.Name = "btnCadCardapio";
//        }


//        private void btnCadastrarAlimento_Click(object sender, EventArgs e)
//        {
//            var frmCadastroAlimento = new frmAlimento();
//            frmCadastroAlimento.Show();
//        }

//        private void btnConsultarAlimentos_Click(object sender, EventArgs e)
//        {
//            var frmConfiguracoes = new frmConfiguracoes();
//            frmConfiguracoes.Show();
//        }

//        private void frmMenuPrincipal_Load(object sender, EventArgs e)
//        {
//            

//        }

//        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
//        {
//            var frmCadPaciente = new frmPaciente();
//            frmCadPaciente.Show();
//        }

//        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            Application.Exit();
//        }

//        private void btnDeslogar_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void BtnPacientes_Click(object sender, EventArgs e)
//        {
//            var frmPaciente = new frmPaciente();
//            frmPaciente.Show();
//        }

//        private void btnConfig_Click(object sender, EventArgs e)
//        {
//            var frmConfiguracoes = new frmConfiguracoes();
//            frmConfiguracoes.Show();
//        }

//        private void btnAgenda_Click(object sender, EventArgs e)
//        {
//            var frmAgenda = new frmAgenda();
//            frmAgenda.Show();
//        }

//        private void btnCadCardapio_Click(object sender, EventArgs e)
//        {
//            var frmPlanilhaCardapio = new frmPlanilhaCardapio();
//            frmPlanilhaCardapio.Show();
//        }

//        private void tabMenu_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}