﻿using MaterialSkin;
using MaterialSkin.Controls;
using Model;
using ProjetoTCC;
using System;
using System.Data;
using System.Windows.Forms;
using static Classes.HelperFuncoes;

namespace TCC2
{
    public partial class frmBuscarPaciente : MaterialForm
    {
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();

        FrmMenuPrincipal instanciaMenuPrincipal;

        public frmBuscarPaciente(FrmMenuPrincipal menu)
        {
            InitializeComponent();
            instanciaMenuPrincipal = menu;
        }        

        private void frmBuscarPaciente_Load(object sender, EventArgs e)
        {
            FormatView(this);

            var menu = new FrmMenuPrincipal(string.Empty,true);
            var listaPaciente = pacienteDAO.Buscar(string.Empty);
            if (listaPaciente == null)
                return;
            DataTable dt = menu.ConvertToDataTable(listaPaciente);
            dtgPacientes.DataSource = dt;
            dtgPacientes.Columns["codPaciente"].Visible = false;
            dtgPacientes.Columns["imagem"].Visible = false;
            dtgPacientes.Columns["nome"].HeaderText = "Nome";
            dtgPacientes.Columns["sexo"].HeaderText = "Sexo";
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
            dtgPacientes.Columns["AnamnesePaciente"].Visible = false;
            dtgPacientes.Columns["Antropometria"].Visible = false;
            dtgPacientes.Columns.Add("idade", "Idade");
            foreach (DataGridViewRow row in dtgPacientes.Rows)
            {
                row.Cells["idade"].Value = calcularIdade((row.Cells["dtNasc"].Value.ToString()));
            }
            dtgPacientes.AutoResizeColumns();
        }

        private void dtgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex >= 0)
                {
                    PacienteModel.codPacienteModel = dtgPacientes.Rows[e.RowIndex].Cells["codPaciente"].Value.ToString();
                    PacienteModel.nomePacienteModel = dtgPacientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                    frmBuscarPaciente.ActiveForm.Close();
                }
        }
    }
}
