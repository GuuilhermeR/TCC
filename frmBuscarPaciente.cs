using MaterialSkin;
using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2
{
    public partial class frmBuscarPaciente : MaterialForm
    {
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();

        frmMenuPrincipal instanciaMenuPrincipal;

        public frmBuscarPaciente(frmMenuPrincipal menu)
        {
            InitializeComponent();
            instanciaMenuPrincipal = menu;
        }

        public static int calcularIdade (string dataNas)
        {
            DateTime dataNascimento = Convert.ToDateTime(dataNas);
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade -= 1;
            }
            return idade;
        }
        private void frmBuscarPaciente_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);

            var menu = new frmMenuPrincipal("");
            var listaPaciente = pacienteDAO.Buscar("");
            if (listaPaciente == null)
                return;
            DataTable dt = menu.ConvertToDataTable(listaPaciente);
            dtgPacientes.DataSource = dt;
            dtgPacientes.Columns["codPaciente"].Visible = false;
            dtgPacientes.Columns["imagem"].Visible = false;
            dtgPacientes.Columns["nome"].HeaderText = "Nome";
            dtgPacientes.Columns["dtNasc"].Visible = false;
            dtgPacientes.Columns["email"].Visible = false;
            dtgPacientes.Columns["endereco"].Visible = false;
            dtgPacientes.Columns["numero"].Visible = false;
            dtgPacientes.Columns["bairro"].Visible = false;
            dtgPacientes.Columns["municipio"].Visible = false;
            dtgPacientes.Columns["UF"].Visible = false;
            dtgPacientes.Columns["complemento"].Visible = false;
            dtgPacientes.Columns["telefone"].Visible = false;
            dtgPacientes.Columns["celular"].Visible = false;
            dtgPacientes.Columns["cpf"].Visible = false;
            dtgPacientes.Columns["cep"].Visible = false;
            dtgPacientes.Columns["Cardapio"].Visible = false;
            dtgPacientes.Columns.Add("idade", "Idade");
            foreach (DataGridViewRow row in dtgPacientes.Rows)
            {
                int idade = calcularIdade(row.Cells["dtNasc"].Value.ToString());
                row.Cells["idade"].Value = idade;
            }
            dtgPacientes.AutoResizeColumns();
        }

        private void dtgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex >= 0)
                {
                    CardapioDAO.codPacienteCard = dtgPacientes.Rows[e.RowIndex].Cells["codPaciente"].Value.ToString();
                    instanciaMenuPrincipal.txtPaciente.Text = dtgPacientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                    instanciaMenuPrincipal.txtPaciente.Refresh();
                    frmBuscarPaciente.ActiveForm.Close();
                }
        }
    }
}
