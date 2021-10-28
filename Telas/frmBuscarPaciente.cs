using MaterialSkin;
using MaterialSkin.Controls;
using Model;
using ProjetoTCC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TCC2.Banco_de_Dados;
using static Classes.HelperFuncoes;

namespace TCC2
{
    public partial class frmBuscarPaciente : MaterialForm
    {
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();
        public List<Paciente> listaPacientes = new List<Paciente>();
        FrmMenuPrincipal instanciaMenuPrincipal;


        public frmBuscarPaciente(FrmMenuPrincipal menu, List<Paciente> listPaciente)
        {
            InitializeComponent();
            instanciaMenuPrincipal = menu;
            listaPacientes = listPaciente;
        }

        private void frmBuscarPaciente_Load(object sender, EventArgs e)
        {
            FormatView(this);

            var menu = new FrmMenuPrincipal(string.Empty, true);
            if (listaPacientes == null)
                return;

            foreach (Paciente paciente in listaPacientes)
            {
                dtgPacientes.Rows.Add(paciente.codPaciente, paciente.nome, calcularIdade(paciente.dtNasc));
            }
            dtgPacientes.AutoResizeColumns();
        }

        private void dtgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex >= 0)
                {
                    PacienteModel.codPacienteModel = dtgPacientes.Rows[e.RowIndex].Cells[colCodPaciente.Index].Value.ToString();
                    PacienteModel.nomePacienteModel = dtgPacientes.Rows[e.RowIndex].Cells[colNome.Index].Value.ToString();
                    frmBuscarPaciente.ActiveForm.Close();
                }
        }
    }
}
