using System;

namespace ProjetoTCC
{
    public partial class frmAdicionarRefeição
    {
        public frmAdicionarRefeição()
        {
            InitializeComponent();
            _btnAdicionarRefeição.Name = "btnAdicionarRefeição";
        }

        private void btnAdicionarRefeição_Click(object sender, EventArgs e)
        {
            // Pegar código paciente, descrição da refeição e as infos dessa tela pra salvar no banco
        }

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            var buscarAlimento = new frmBuscarAlimento();
            buscarAlimento.Show();
            Hide();
        }

        private void frmAdicionarRefeição_Load(object sender, EventArgs e)
        {

        }
    }
}