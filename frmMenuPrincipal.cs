﻿using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using LiveCharts;
using LiveCharts.Wpf;

namespace TCC2
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        public AlimentoDAO alimentoDAO = new AlimentoDAO();
        public AgendaDAO agendaDAO = new AgendaDAO();
        public MedidaCaseiraDAO medidaCaseiraDAO = new MedidaCaseiraDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();
        private DataTableCollection tables;
        List<string> deletar = new List<string>();
        List<string> deletarAlimento = new List<string>();
        private object tamanhoArquivoImagem;
        private byte[] vetorImagens;
        private double quantidadeSalva;
        private decimal quantidadeAntigaCardapio;

        #region Menu
        public frmMenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            usuarioDAO.setNomeUsuario(usuarioLogado);

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);

            this.MaximizeBox = false;
            
            if (usuarioDAO.getNomeUsuario() != null)
            {
                lblUsuario.Text = $"Seja bem vindo(a) ao sistema {usuarioDAO.getNomeUsuario()}";
                lblUsuario.Visible = true;
            }
            else
            {
                lblUsuario.Text = $"Seja bem vindo(a) ao sistema Guilherme Rüdiger";
                lblUsuario.Visible = true;
            }
        }

        private void tabMenu_Enter(object sender, EventArgs e)
        {
            //var ConsultasMarcada = this.agendaDAO.CarregarAgenda(DateAndTime.Now.ToString("dd/MM/yyyy"), DateAndTime.Now.AddHours(1).ToString("HH:00"));

            // if( ConsultasMarcada != null)
            // ConsultasMarcada.ForEach(x =>
            //{
            //    MessageBox.Show($"Você tem hora marcada com {x.paciente} às {x.hora}");
            //});

        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
            //https://social.msdn.microsoft.com/Forums/vstudio/pt-BR/6ffcb247-77fb-40b4-bcba-08ba377ab9db/converting-a-list-to-datatable?forum=csharpgeneral
        }
        #endregion

        #region Agenda

        private void LoadAgenda()
        {
            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {
                var agenda = this.agendaDAO.CarregarAgenda(lblDataAtual.Text, row.Cells["horario"].Value.ToString());
                if (agenda == null)
                    continue;

                if (agenda != null || agenda.Count > 0)
                {
                    agenda.ForEach(x =>
                    {
                        row.Cells["ID"].Value = x.ID;
                        row.Cells["nomePaciente"].Value = x.paciente;
                        row.Cells["atendido"].Value = x.atendido;
                        row.Cells["retorno"].Value = x.retorno;
                    });
                }
            }
        }

        private void tabAgenda_Enter(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            lblDataAtual.Text = hoje.ToString("dd/MM/yyyy");
            CriarHorariosPadrao();
            dtgAgenda.AutoResizeColumns();
            dtgAgenda.AutoResizeRows();
            dtgAgenda.Refresh();
            LoadAgenda();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            dtgAgenda.Rows.Clear();
            CriarHorariosPadrao();
            var data = Convert.ToDateTime(lblDataAtual.Text);
            DateTime dataAvançada = data.AddDays(1);
            lblDataAtual.Text = dataAvançada.ToString("dd/MM/yyyy");
            LoadAgenda();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtgAgenda.Rows.Clear();
            CriarHorariosPadrao();
            var data = Convert.ToDateTime(lblDataAtual.Text);
            DateTime dataAvançada = data.AddDays(-1);
            lblDataAtual.Text = dataAvançada.ToString("dd/MM/yyyy");
            LoadAgenda();
        }

        private void CriarHorariosPadrao()
        {
            dtgAgenda.Rows.Clear();
            for (int i = 7; i <= 21; i++)
            {
                dtgAgenda.Rows.Add(i + ":00");
            }
        }

        private void dtgAgenda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgAgenda.AutoResizeColumns();

            if (dtgAgenda.Rows[e.RowIndex].Cells["nomePaciente"].Value.ToString() == "" || dtgAgenda.Rows[e.RowIndex].Cells["nomePaciente"].Value.ToString() != null)
                dtgAgenda.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

            dtgAgenda.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Tomato;
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {

                if (row.DefaultCellStyle.BackColor == Color.Tomato)
                {
                    int result = DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm")), Convert.ToDateTime(lblDataAtual.Text + ' ' + row.Cells["horario"].Value));

                    if (result == 1)
                    {
                        MessageBox.Show(this, $"Não é possível agendar consulta para: '{row.Cells["nomePaciente"].Value.ToString().ToUpper()}' em uma data/hora que passou!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabAgenda_Enter(sender, e);
                        return;
                    }

                    agendaDAO.AdicionarPaciente(
                        lblDataAtual.Text,
                        row.Cells["horario"].Value.ToString(),
                        row.Cells["nomePaciente"].Value.ToString(),
                        Convert.ToBoolean(row.Cells["atendido"].Value),
                        Convert.ToBoolean(row.Cells["retorno"].Value));
                }

            }
            if (deletar.Count > 0)
            {
                agendaDAO.DeletarPacienteAgenda(deletar);
            }
            dtgAgenda.Rows.Clear();
            tabAgenda_Enter(sender, e);
        }

        private void dtgAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                deletar.Add(dtgAgenda.CurrentRow.Cells["ID"].Value.ToString());
                dtgAgenda.CurrentRow.Cells["nomePaciente"].Value = "";
                dtgAgenda.CurrentRow.Cells["atendido"].Value = false;
                dtgAgenda.CurrentRow.Cells["retorno"].Value = false;
            }
        }
        #endregion

        #region Alimento

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            if(quantidadeSalva != 0)
            if (dtgConAlimento.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgConAlimento.Rows)
                {
                    double ProteinaKcal = 0;
                    double CarboidratoKcal = 0;
                    double LipidioKcal = 0;

                    if (row.Cells["prot"].Value != null)
                    {
                        double ProteinaGramas = 0;
                        ProteinaGramas = Conversions.ToDouble(((decimal)row.Cells["qtd"].Value * (decimal)row.Cells["prot"].Value)/ (decimal)quantidadeSalva);
                        ProteinaKcal = ProteinaGramas * 4d;
                        row.Cells["prot"].Value = ProteinaGramas.ToString("N2");
                    }

                    if (row.Cells["carbo"].Value != null)
                    {
                        double CarboidratoGramas = 0;
                        CarboidratoGramas = Conversions.ToDouble(((decimal)row.Cells["qtd"].Value * (decimal)row.Cells["carbo"].Value)/ (decimal)quantidadeSalva);
                        CarboidratoKcal = CarboidratoGramas * 4d;
                        row.Cells["carbo"].Value = CarboidratoGramas.ToString("N2");
                    }

                    if (row.Cells["lipidio"].Value != null)
                    {
                        double LipidioGramas = 0;
                        LipidioGramas = Conversions.ToDouble(((decimal)row.Cells["qtd"].Value * (decimal)row.Cells["lipidio"].Value)/ (decimal)quantidadeSalva);
                        LipidioKcal = LipidioGramas * 9d;
                        row.Cells["lipidio"].Value = LipidioGramas.ToString("N2");
                    }

                    double somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal;
                    row.Cells["kcal"].Value = somaTotalCaloria.ToString("N2");
                    
                    //double calcio;
                    //calcio = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["calcio"].Value, row.Cells["qtd"].Value));
                    //row.Cells["calcio"].Value = calcio.ToString("N2");

                    //double ferro;
                    //ferro = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["ferro"].Value, row.Cells["qtd"].Value));
                    //row.Cells["ferro"].Value = ferro.ToString("N2");

                    //double VitaminaC;
                    //VitaminaC = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["vitC"].Value, row.Cells["qtd"].Value));
                    //row.Cells["vitC"].Value = VitaminaC.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show(this, "Não foram encontrados itens para recalcular.");
            }
            quantidadeSalva = 0d;
        }

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (cbxTabela.Text != "")
            {
                dtgConAlimento.DataSource = null;
                var listaAlimentos = alimentoDAO.Buscar(txtAlimentoFiltro.Text, cbxTabela.Text);
                if (listaAlimentos == null)
                    return;
                DataTable dt = ConvertToDataTable(listaAlimentos);
                dtgConAlimento.DataSource = dt;
                dtgConAlimento.Columns["codAlimento"].Visible = false;
                dtgConAlimento.Columns["nomeAlimento"].HeaderText = "Alimento";
                dtgConAlimento.Columns["nomeAlimento"].Width = 450;
                dtgConAlimento.Columns["qtd"].HeaderText = "Qtde";
                dtgConAlimento.Columns["prot"].HeaderText = "Proteína";
                dtgConAlimento.Columns["carbo"].HeaderText = "Carboidrato";
                dtgConAlimento.Columns["lipidio"].HeaderText = "Lipídio";
                dtgConAlimento.Columns["nomeTabela"].HeaderText = "Tabela";
                dtgConAlimento.Columns["MedidaCaseira"].Visible = false;
                dtgConAlimento.Columns["Cardapio"].Visible = false;
                return;
            }
        }

        private void tbAlimento_Enter(object sender, EventArgs e)
        {
            //CarregarTabelas();
        }

        private void _btnImportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeTabela.Text))
            {
                Interaction.MsgBox("Favor informar o nome da tabela que está sendo salvo.");
                return;
            }
            if (string.IsNullOrEmpty(txtCaminhoArquivoExcel.Text))
            {
                Interaction.MsgBox("Favor informar o caminho do arquivo.");
                return;
            }
            if (string.IsNullOrEmpty(_cbxNomePlanilha.Text))
            {
                Interaction.MsgBox("Favor informar a planilha a ser salva.");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dtgDados.Rows)
                {
                    decimal qtd = Convert.ToDecimal(row.Cells["Qtd"].Value);
                    decimal kcal = Convert.ToDecimal(row.Cells["kcal"].Value);
                    decimal Prot = Convert.ToDecimal(row.Cells["Prot"].Value);
                    decimal Carb = Convert.ToDecimal(row.Cells["Carb"].Value);
                    decimal Lipidios = Convert.ToDecimal(row.Cells["Lipidios"].Value);

                    alimentoDAO.Salvar(Convert.ToString(row.Cells["Alimento"].Value), qtd, kcal, Prot, Carb, Lipidios, Convert.ToString(row.Cells["REF"].Value));
                };
                Interaction.MsgBox("Os dados foram Salvos", MsgBoxStyle.OkOnly, "SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, MsgBoxStyle.Critical, "ERRO AO SALVAR");
            }
        }

        private void _cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = tables[_cbxNomePlanilha.SelectedItem.ToString().Replace(",", ".")];
            dtgDados.DataSource = dt;
        }

        private void _btnBuscarPlanilha_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoArquivoExcel.Text = ofd.FileName;
                    try
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = new Func<IExcelDataReader, ExcelDataTableConfiguration>(__ => new ExcelDataTableConfiguration() { UseHeaderRow = true }) });
                                tables = result.Tables;
                                _cbxNomePlanilha.Items.Clear();
                                foreach (DataTable table in tables)
                                    _cbxNomePlanilha.Items.Add(table.TableName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, MsgBoxStyle.Critical, "ERRO AO SALVAR");
                    }
                }
            }
        }

        private void tabAlimento_Enter(object sender, EventArgs e)
        {
            List<Alimentos> tabela = new List<Alimentos>();
            tabela = (alimentoDAO.BuscarTabelas());
            if (tabela != null)
                tabela.ForEach(x =>
                {
                    if (!cbxTabela.Items.Contains(x.nomeTabela))
                        cbxTabela.Items.Add(x.nomeTabela);
                });
            return;
        }

        private void btnSalvarAlimento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgConAlimento.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Tomato)
                {
                    alimentoDAO.Salvar(row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDecimal(row.Cells["qtd"].Value), Convert.ToDecimal(row.Cells["kcal"].Value)
                                   , Convert.ToDecimal(row.Cells["prot"].Value), Convert.ToDecimal(row.Cells["carbo"].Value), Convert.ToDecimal(row.Cells["lipidio"].Value), cbxTabela.Text.ToString());
                }
                else if (row.DefaultCellStyle.BackColor == Color.LightSalmon)
                {
                    alimentoDAO.Update(Convert.ToInt16(row.Cells["codAlimento"].Value), row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDecimal(row.Cells["qtd"].Value),
                        Convert.ToDecimal(row.Cells["kcal"].Value), Convert.ToDecimal(row.Cells["prot"].Value), Convert.ToDecimal(row.Cells["carbo"].Value), Convert.ToDecimal(row.Cells["lipidio"].Value));
                }
            }

            if (deletarAlimento != null || deletarAlimento.Count > 0)
                deletarAlimento.ForEach(x =>
                {
                    alimentoDAO.Deletar(Convert.ToDouble(x));
                });
        }

        private void dtgConAlimento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString() != "")
                {
                    dtgConAlimento.CurrentRow.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dtgConAlimento.CurrentRow.DefaultCellStyle.BackColor = Color.Tomato;
                }
            }
        }

        private void dtgConAlimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
                if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString() != "")
                    deletarAlimento.Add(dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString());
        }

        private void tbCadMedCaseira_Enter(object sender, EventArgs e)
        {
            dtgMedCaseiraAlimentos.DataSource = null;

            var listaAlimentos = alimentoDAO.Buscar("", "");
            if (listaAlimentos == null)
                return;
            DataTable dt = ConvertToDataTable(listaAlimentos);
            dtgMedCaseiraAlimentos.DataSource = dt;

            dtgMedCaseiraAlimentos.Columns["codAlimento"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["MedidaCaseira"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["Cardapio"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["nomeTabela"].HeaderText = "Tabela";
            dtgMedCaseiraAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";

        }
        private void dtgMedCaseiraAlimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                txtAlimentoMedCaseira.Text = dtgMedCaseiraAlimentos.CurrentRow.Cells["nomeAlimento"].Value.ToString();
                txtCodAlimentoMedCas.Text = dtgMedCaseiraAlimentos.CurrentRow.Cells["codAlimento"].Value.ToString();
            }

            dtgSalvarMedCaseira.DataSource = null;

            var listaMedCaseira = medidaCaseiraDAO.Buscar(Convert.ToInt32(txtCodAlimentoMedCas.Text));

            if (listaMedCaseira == null)
                return;

            DataTable dt = ConvertToDataTable(listaMedCaseira);

            dtgSalvarMedCaseira.DataSource = dt;
            dtgSalvarMedCaseira.Columns["ID"].Visible = false;
            dtgSalvarMedCaseira.Columns["codAlimento"].Visible = false;
            dtgSalvarMedCaseira.Columns["Alimentos"].Visible = false;
            dtgSalvarMedCaseira.Columns["descricao"].HeaderText = "Descricao";
            dtgSalvarMedCaseira.Columns["qtd"].HeaderText = "Quantidade";

            foreach (DataGridViewRow rows in dtgSalvarMedCaseira.Rows)
            {
                rows.Cells["salvo"].Value = 1;
            }
        }
        private void btnAddMedCaseira_Click(object sender, EventArgs e)
        {
            dtgSalvarMedCaseira.Rows.Add(txtAlimentoMedCaseira.Text, txtDescMedCaseira.Text, txtQtdMedCas.Text);
            txtAlimentoMedCaseira.Text = "";
            txtDescMedCaseira.Text = "";
            txtQtdMedCas.Text = "";
        }
        private void btnSalvarMedCas_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dtgSalvarMedCaseira.Rows)
            {
                if (Convert.ToInt32(rows.Cells["salvo"].Value) != 1)
                    medidaCaseiraDAO.Salvar(rows.Cells["desc"].Value.ToString(), Convert.ToDecimal(rows.Cells["qtd"].Value), Convert.ToInt32(txtCodAlimentoMedCas.Text));
            }
            dtgSalvarMedCaseira.DataSource = null;
            txtAlimentoMedCaseira.Text = "";
            txtDescMedCaseira.Text = "";
            txtQtdMedCas.Text = "";
            txtCodAlimentoMedCas.Text = "";
        }
        private void txtAlimentoMedCaseira_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region CadastroPaciente 

        private void buscarEndCep(string CEP)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($@"https://viacep.com.br/ws/{CEP}/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor;

            try
            {
                ChecaServidor = (HttpWebResponse)request.GetResponse();
            }
            catch
            {
                MessageBox.Show("Você não tem uma conexão com a internet, não foi possível buscar os dados.");
                return;
            }

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Você não tem uma conexão com a internet.");
                return;
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    txtCEP.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtEndereco.Text = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtComplemento.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtBairro.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtMunicipio.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtUF.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }
        }

        private void limparCamposCadPaciente()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDtNasc.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            txtUF.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            buscarEndCep(txtCEP.Text);
        }
        private void _btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCPF.Text))
            {
                pacienteDAO.Deletar(Convert.ToDouble(txtCPF.Text));
                limparCamposCadPaciente();
            }
            else
            {
                Interaction.MsgBox("Não é possível excluir sem antes informar o código.");
            }
        }
        private void _dtgConsultaPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                txtNome.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCPF.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtDtNasc.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtEmail.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCEP.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtNumero.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtComplemento.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtTelefone.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCelular.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                buscarEndCep(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value.ToString());
                tbPaciente.SelectedTab = tbCadastro;
            }
        }

        private void _btnSalvar_Click(object sender, EventArgs e)
        {
            pacienteDAO.Salvar(txtNome.Text, Convert.ToDouble(txtCPF.Text), txtDtNasc.Text, txtEmail.Text, Convert.ToDouble(txtCEP.Text),
                            Convert.ToDouble(txtNumero.Text), txtTelefone.Text, txtCelular.Text, txtEndereco.Text, txtBairro.Text, txtMunicipio.Text, txtUF.Text, txtComplemento.Text, this.vetorImagens);
            tbCadastro_Enter(sender, e);
        }
        private void txtNome_Leave(object sender, EventArgs e)
        {
            var listaPacientes = pacienteDAO.Buscar(txtNome.Text);
            if (listaPacientes == null)
                return;
            DataTable dt = ConvertToDataTable(listaPacientes);
            dtgConAlimento.DataSource = dt;
        }

        private void tbCadastro_Enter(object sender, EventArgs e)
        {
            _dtgConsultaPacientes.DataSource = null;
            var listaPacientes = pacienteDAO.Buscar("");

            if (listaPacientes == null)
                return;
            DataTable dt = ConvertToDataTable(listaPacientes);
            _dtgConsultaPacientes.DataSource = dt;

            _dtgConsultaPacientes.Columns["codPaciente"].Visible = false;
            _dtgConsultaPacientes.Columns["imagem"].Visible = false;
            _dtgConsultaPacientes.Columns["nome"].HeaderText = "Nome";
            _dtgConsultaPacientes.Columns["dtNasc"].HeaderText = "Data Nascimento";
            _dtgConsultaPacientes.Columns["email"].HeaderText = "E-mail";
            _dtgConsultaPacientes.Columns["endereco"].HeaderText = "Endereço";
            _dtgConsultaPacientes.Columns["numero"].HeaderText = "Nº";
            _dtgConsultaPacientes.Columns["bairro"].HeaderText = "Bairro";
            _dtgConsultaPacientes.Columns["municipio"].HeaderText = "Munícipio";
            _dtgConsultaPacientes.Columns["UF"].HeaderText = "UF";
            _dtgConsultaPacientes.Columns["complemento"].HeaderText = "Complemento";
            _dtgConsultaPacientes.Columns["telefone"].HeaderText = "Telefone";
            _dtgConsultaPacientes.Columns["celular"].HeaderText = "Celular";

        }

        private void pbImagem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.pbImagem.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(this.vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            pacienteDAO.Buscar(txtNome.Text);
        }
        #endregion

        #region Cardápio
        //Ao invés de colocar medida caseira, para finalizar o básico do projeto, será possível apenas colocar quantidade em gramas. O gráfico irá carregar após 
        //informar a quantidade em gramas (evento sair da célula) apenas. Posteriormente, como ajustes será implementado medidas caseiras.
        private void tabCardapio_Enter(object sender, EventArgs e)
        {
            List<Alimentos> tabela = new List<Alimentos>();
            tabela = (alimentoDAO.BuscarTabelas());
            if (tabela != null)
                tabela.ForEach(x =>
                {
                    if (!cbxTabelaAlimentoCardapio.Items.Contains(x.nomeTabela))
                        cbxTabelaAlimentoCardapio.Items.Add(x.nomeTabela);
                });
        }

        private void btnAddAliCard_Click(object sender, EventArgs e)
        {
            if (cbxRefeicao.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição do cardápio.");
                return;
            }

            decimal proteina = 0;
            decimal carboidrato = 0;
            decimal lipidio = 0;
            decimal kcal = 0;
            DataGridViewRow linhaAdicionada = null;

            if (dtgCardapioAlimentos.SelectedRows.Count >= 1 || dtgCardapioAlimentos.SelectedCells.Count >= 1)
            {
                foreach (DataGridViewRow row in dtgCardapioAlimentos.Rows)
                    if (row.Selected == true || row.Cells["nomeAlimento"].Selected)
                    {
                        linhaAdicionada = adicionar(row);
                        dtgRefeicoes.Rows.Add(linhaAdicionada);
                    }

                foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                {
                    kcal += (decimal)row.Cells[2].Value;
                    proteina += (decimal)row.Cells["prot"].Value;
                    carboidrato += (decimal)row.Cells["carbo"].Value;
                    lipidio += (decimal)row.Cells["lipidio"].Value;
                }
                dtgRefeicoes.AutoResizeColumns();
            }

            //if(proteina >= 1)
            //{
            //    MessageBox.Show("A proteína atingiu o limite configurado");
            //    dtgRefeicoes.Rows.Remove(linhaAdicionada);
            //    return;
            //} else if(carboidrato >= 1)
            //{
            //    MessageBox.Show("A carboidrato atingiu o limite configurado");
            //    dtgRefeicoes.Rows.Remove(linhaAdicionada);
            //    return;
            //}
            //else if(lipidio >= 1)
            //{
            //    MessageBox.Show("A lipídio atingiu o limite configurado");
            //    dtgRefeicoes.Rows.Remove(linhaAdicionada);
            //    return;
            //}

            if (proteina != 0 || carboidrato != 0 || lipidio != 0)
            {
                lblValorKcal.Text = kcal.ToString("N2") + " Kcal";

                CarregarGrafico(proteina, carboidrato, lipidio);
            }
        }

        private void CarregarGrafico(decimal proteina, decimal carboidrato, decimal lipidio)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Proteína",
                        Values = new ChartValues<decimal> {proteina},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Carboidrato",
                        Values = new ChartValues<decimal> {carboidrato},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Lipídios",
                        Values = new ChartValues<decimal> {lipidio},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                };
            graficoMacroNutri.Series = piechartData;
            graficoMacroNutri.LegendLocation = LegendLocation.Right;
        }

        private void cbxTabelaAlimentoCardapio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var listaAlimentos = alimentoDAO.Buscar("", cbxTabelaAlimentoCardapio.Text);
            if (listaAlimentos == null)
                return;
            DataTable dt = ConvertToDataTable(listaAlimentos);
            dtgCardapioAlimentos.DataSource = dt;

            dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
            dtgCardapioAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";
            dtgCardapioAlimentos.Columns["kcal"].Visible = false;
            dtgCardapioAlimentos.Columns["qtd"].Visible = false;
            dtgCardapioAlimentos.Columns["prot"].Visible = false;
            dtgCardapioAlimentos.Columns["carbo"].Visible = false;
            dtgCardapioAlimentos.Columns["lipidio"].Visible = false;
            dtgCardapioAlimentos.Columns["nomeTabela"].Visible = false;
            dtgCardapioAlimentos.Columns["MedidaCaseira"].Visible = false;
            dtgCardapioAlimentos.Columns["Cardapio"].Visible = false;
            dtgCardapioAlimentos.AutoResizeColumns();
        }

        private DataGridViewRow adicionar(DataGridViewRow row)
        {
            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
            //var colunaMedidaCaseira = new DataGridViewComboBoxColumn();

            if (dtgRefeicoes.Columns.Count == 0)
            {
                dtgRefeicoes.Columns.Add("codAlimento", "codAlimento");
                dtgRefeicoes.Columns.Add("nomeAlimento", "Alimento");
                dtgRefeicoes.Columns.Add("kcal", "KCal");
                dtgRefeicoes.Columns.Add("qtd", "Qtd");
                dtgRefeicoes.Columns.Add("prot", "Prot");
                dtgRefeicoes.Columns.Add("carbo", "Carbo");
                dtgRefeicoes.Columns.Add("lipidio", "Lipidio");
                dtgRefeicoes.Columns.Add("nomeTabela", "nomeTabela");
                dtgRefeicoes.Columns.Add("MedidaCaseira", "MedidaCaseira");
                dtgRefeicoes.Columns.Add("obs", "Observação");
                dtgRefeicoes.Columns["codAlimento"].Visible = false;
                dtgRefeicoes.Columns["nomeAlimento"].HeaderText = "Alimento";
                dtgRefeicoes.Columns["kcal"].Visible = false;
                dtgRefeicoes.Columns["qtd"].Visible = true;
                dtgRefeicoes.Columns["prot"].Visible = false;
                dtgRefeicoes.Columns["carbo"].Visible = false;
                dtgRefeicoes.Columns["lipidio"].Visible = false;
                dtgRefeicoes.Columns["nomeTabela"].Visible = false;
                dtgRefeicoes.Columns["MedidaCaseira"].Visible = false;
            }

            newRow.Cells[0].Value = row.Cells["codAlimento"].Value;
            newRow.Cells[1].Value = row.Cells["nomeAlimento"].Value;
            newRow.Cells[2].Value = row.Cells["kcal"].Value;
            newRow.Cells[3].Value = row.Cells["qtd"].Value;
            newRow.Cells[4].Value = row.Cells["prot"].Value;
            newRow.Cells[5].Value = row.Cells["carbo"].Value;
            newRow.Cells[6].Value = row.Cells["lipidio"].Value;

            //var medCaseiraItens = medidaCaseiraDAO.Buscar(Convert.ToInt32(row.Cells["codAlimento"].Value));

            //if (medCaseiraItens == null)
                //return newRow;

            //colunaMedidaCaseira.HeaderText = "Medida Caseira";
            //colunaMedidaCaseira.Name = "medCaseira";
            //medCaseiraItens.ForEach(x =>
            //{
            //    if (x.codAlimento == x.Alimentos.codAlimento)
            //        colunaMedidaCaseira.Items.Add(x.descricao);
            //});

            return newRow;
        }

        private void btnSalvarCardapio_Click(object sender, EventArgs e)
        {
            decimal Kcal;
            Kcal = Convert.ToDecimal(lblValorKcal.Text.Split(' ')[0]);
            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
            cardapioDAO.Salvar(Convert.ToString(CardapioDAO.codPacienteCard), 
                                                Convert.ToInt32(row.Cells["codAlimento"].Value),
                                                Convert.ToString(cbxRefeicao.Text),
                                                Convert.ToInt32(row.Cells["qtd"].Value), 
                                                Convert.ToString(row.Cells["obs"].Value), 
                                                Kcal);
            dtgRefeicoes.DataSource = null;
            graficoMacroNutri.Series = null;
            txtPaciente.Text = null;
            cbxRefeicao.Text = null;
            lblValorKcal.Text = null;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
            CardapioDAO.codPacienteCard = null;
            CardapioDAO.nomePacienteCard = null;
            btnApagar_Click(sender, e);
        }

        private void btnPacienteCardapio_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this);
            buscaPacientes.ShowDialog();
        }
        private void dtgConAlimento_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if(dtgConAlimento.CurrentRow.Cells["qtd"].Value != null)
                quantidadeSalva = Convert.ToDouble(dtgConAlimento.CurrentRow.Cells["qtd"].Value);
            }
        }

        private void txtFiltroAlimento_Leave(object sender, EventArgs e)
        {
            if (txtFiltroAlimento.Text != "")
            {
                var listaAlimentos = alimentoDAO.Buscar(txtFiltroAlimento.Text, cbxTabelaAlimentoCardapio.Text);
                if (listaAlimentos == null)
                    return;
                else if (listaAlimentos.Count == 0)
                    return;
                dtgCardapioAlimentos.DataSource = null;
                DataTable dt = ConvertToDataTable(listaAlimentos);
                dtgCardapioAlimentos.DataSource = dt;
                dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
                dtgCardapioAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";
                dtgCardapioAlimentos.Columns["kcal"].HeaderText = "KCal";
                dtgCardapioAlimentos.Columns["qtd"].HeaderText = "Qtd";
                dtgCardapioAlimentos.Columns["prot"].HeaderText = "Prot";
                dtgCardapioAlimentos.Columns["carbo"].HeaderText = "Carbo";
                dtgCardapioAlimentos.Columns["lipidio"].HeaderText = "Lipídio";
                dtgCardapioAlimentos.Columns["nomeTabela"].Visible = false;
                dtgCardapioAlimentos.Columns["MedidaCaseira"].Visible = false;
                dtgCardapioAlimentos.Columns["Cardapio"].Visible = false;
                dtgCardapioAlimentos.AutoResizeColumns();
            }
        }
        private void cbxRefeicao_Leave(object sender, EventArgs e)
        {
            if (cbxRefeicao.Text == "" || cbxRefeicao.Text == null)
            {

            }
        }

        private void btnConfigGramasCard_Click(object sender, EventArgs e)
        {

        }
        private void dtgRefeicoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((decimal)dtgRefeicoes.CurrentRow.Cells["qtd"].Value != quantidadeAntigaCardapio)
            {
                CarregarGrafico((decimal)dtgRefeicoes.CurrentRow.Cells["prot"].Value, 
                                (decimal)dtgRefeicoes.CurrentRow.Cells["carbo"].Value, 
                                (decimal)dtgRefeicoes.CurrentRow.Cells["lipidio"].Value);
            }
        }
        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this);
            buscaPacientes.ShowDialog();
        }
        private void dtgRefeicoes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if((decimal)dtgRefeicoes.CurrentRow.Cells["qtd"].Value != null)
            quantidadeAntigaCardapio = (decimal)dtgRefeicoes.CurrentRow.Cells["qtd"].Value;
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPacienteConsultaCardapio.Text = null;
            trwConsultarCardPaciente.Nodes.Clear();
        }
        #endregion

        #region Configurações

        private void CriarColunas()
        {
            if (dtgUsuarios.Columns.Count <= 0)
            {
                dtgUsuarios.Columns.Add("usuario", "Usuário");
                dtgUsuarios.Columns.Add("nome", "Nome");
                dtgUsuarios.Columns.Add("email", "E-mail");
                dtgUsuarios.Columns.Add("situacao", "Situação");
                dtgUsuarios.Columns.Add("tipoUsuario", "Perfil");
            }
        }
        private void btnSalvarConfigUsuario_Click(object sender, EventArgs e)
        {
            bool alterarSenha = false;
            if (txtUsuarioConfig.Text == "")
            {
                Interaction.MsgBox("O usuário não foi informado");
                return;
            }
            if (txtSenha.Text == "")
            {
                Interaction.MsgBox("O campo senha não foi informado");
                return;
            }
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Interaction.MsgBox("As senhas não conferem");
                return;
            }


            if (usuarioDAO.VerificarExisteUsuario(txtUsuarioConfig.Text) == false)
            {
                // usuario.CriarUsuario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text);
            }
            else
            {
                if (Interaction.MsgBox("Você deseja alterar a senha do usuário?", MsgBoxStyle.YesNo, "ALTERAÇÃO DE SENHA") == MsgBoxResult.Yes)
                    alterarSenha = true;
                usuarioDAO.AlterarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha);
            }
        }
        private void txtUsuarioConfig_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text != "")
                usuarioDAO.Buscar(txtUsuarioConfig.Text);
        }
        private void tbConfig_Enter(object sender, EventArgs e)
        {
            CriarColunas();
            usuarioDAO.Buscar("");
        }
        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtUsuarioConfig.Text = dtgUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
                txtNomeUsuarioConfig.Text = dtgUsuarios.CurrentRow.Cells["nome"].Value.ToString();
                txtEmailConfig.Text = dtgUsuarios.CurrentRow.Cells["email"].Value.ToString();
                cbxSituacao.Text = dtgUsuarios.CurrentRow.Cells["situacao"].Value.ToString();
                cbxTipoUsuario.Text = dtgUsuarios.CurrentRow.Cells["tipoUsuario"].Value.ToString();
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '*';
        }




        #endregion

        private void txtPacienteConsultaCardapio_TextChanged(object sender, EventArgs e)
        {
            var listaCardapio = cardapioDAO.Consultar(Convert.ToInt32(CardapioDAO.codPacienteCard));
            if (listaCardapio == null)
                return;
            else if (listaCardapio.Count == 0)
                return;
            trwConsultarCardPaciente.Nodes.Clear();

            TreeNode rootNode = trwConsultarCardPaciente.Nodes.Add("Refeição");
            rootNode.ImageIndex = 0;

            // Cria os nós filhos para o raiz
            TreeNode cafe = rootNode.Nodes.Add("Café da manhã");
            cafe.ImageIndex = 1;
            TreeNode Lanche = rootNode.Nodes.Add("Lanche");
            Lanche.ImageIndex = 1;
            TreeNode Almoco = rootNode.Nodes.Add("Almoço");
            Almoco.ImageIndex = 1;
            TreeNode LancheTarde = rootNode.Nodes.Add("Lanche da tarde");
            LancheTarde.ImageIndex = 1;
            TreeNode Jantar = rootNode.Nodes.Add("Jantar");
            Jantar.ImageIndex = 1;
            TreeNode Ceia = rootNode.Nodes.Add("Ceia");
            Ceia.ImageIndex = 1;
            listaCardapio.ForEach(card =>
            {
                switch (card.Refeicao)
                {
                    case "Café da manhã":
                        TreeNode filhoCafe = cafe.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoCafe.ImageIndex = 2;
                        return;

                    case "Lanche":
                        TreeNode filhoLanche = Lanche.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoLanche.ImageIndex = 2;
                        return;

                    case "Almoço":
                        TreeNode filhoAlmoco = Almoco.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        return;

                    case "Lanche da tarde":
                        TreeNode filhoLancheTarde = LancheTarde.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        return;

                    case "Jantar":
                        TreeNode filhoJantar = Jantar.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoJantar.ImageIndex = 2;
                        return;

                    case "Ceia":
                        TreeNode filhoCeia = Ceia.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoCeia.ImageIndex = 2;
                        return;
                }
            });
        }
    }
}
