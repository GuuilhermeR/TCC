using System;
using System.Data.SQLite;

namespace ProjetoTCC
{
    public partial class frmPlanilhaCardapio
    {
        public frmPlanilhaCardapio()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
            InitializeComponent();
            _btnAdicionar.Name = "btnAdicionar";
            _btnProcurarPaciente.Name = "btnProcurarPaciente";
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            var frmBuscaPaciente = new frmBuscarPaciente();
            My.MyProject.Forms.frmBuscarPaciente.Show();
        }

        private void frmPlanilhaCardapio_Load(object sender, EventArgs e)
        {
            CarregarColunas();
        }

        private void CarregarColunas()
        {
            if (dtgRefeicoes.ColumnCount <= 0)
            {
                dtgRefeicoes.Columns.Add("refeicao", "Refeição"); // Vai buscar a descrição salva na tela PlanilhaCardapio
                dtgRefeicoes.Columns.Add("alimento", "Alimento");
                dtgRefeicoes.Columns.Add("qtde", "Quantidade");
                dtgRefeicoes.Columns.Add("hora", "Horário");
            }
        }

        private void CalcularTotalizador()
        {

            // Total Kcal -> De proteína, carboidrato e lipídio.
            // Kcal total na refeição -> Soma dos 3 ^
            // Kcal estipulado e índice de adequação
            // % de Prot,carb e lip.

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frmAddRefeicao = new frmAdicionarRefeição();
            frmAddRefeicao.Show();
        }
    }
}