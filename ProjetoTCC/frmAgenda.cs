using System;
using System.Data.SQLite;
using System.Windows.Forms;
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
            CriarHorariosPadrao();
            dtgAgenda.AutoResizeColumns();
            dtgAgenda.AutoResizeRows();
            dtgAgenda.Refresh();
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

        private void CriarHorariosPadrao()
        {
            for (int i = 7; i <= 19; i++)
            {
                dtgAgenda.Rows.Add(i+":00");
            }
        }

    }
}