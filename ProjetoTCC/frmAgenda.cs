using System;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ProjetoTCC.DAO;

namespace ProjetoTCC
{
    public partial class frmAgenda
    {

        public AgendaDAO agenda = new AgendaDAO();

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            lblData.Text = hoje.ToString("dd/MM/yyyy");

            
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(lblData.Text);
            DateTime dataAvançada = data.AddDays(1);
            lblData.Text = dataAvançada.ToString("dd/MM/yyyy");

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(lblData.Text);
            DateTime dataAvançada = data.AddDays(-1);
            lblData.Text = dataAvançada.ToString("dd/MM/yyyy");

        }
    }
}