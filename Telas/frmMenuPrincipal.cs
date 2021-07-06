using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using LiveCharts;
using LiveCharts.Wpf;
using System.Transactions;
using TCC2.Banco_de_Dados;
using AdvancedDataGridView;
using System.Text.RegularExpressions;
using DAO;
using static Classes.ExibidorMensagem;
using System.Windows.Forms.Calendar;

namespace TCC2
{
    public partial class frmMenuPrincipal : MaterialForm
    {

        #region VariáveisGlobais
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        public AlimentoDAO alimentoDAO = new AlimentoDAO();
        public AgendaDAO agendaDAO = new AgendaDAO();
        public MedidaCaseiraDAO medidaCaseiraDAO = new MedidaCaseiraDAO();
        public PermissaoDAO permissaoDAO = new PermissaoDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();
        public BuscadorCEP buscaCEP = new BuscadorCEP();
        private DataTableCollection tables;
        List<string> deletar = new List<string>();
        List<string> deletarAlimento = new List<string>();
        private object tamanhoArquivoImagem;
        private byte[] vetorImagens;
        private decimal quantidadeSalva;
        private double quantidadeAntigaCardapio;
        //Image capturaImagem;
        public string caminhoImagemSalva = null;
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        #endregion

        #region Menu
        public frmMenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            usuarioDAO.setNomeUsuario(usuarioLogado);
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen400, TextShade.WHITE);

            this.MaximizeBox = false;

            if (usuarioDAO.getNomeUsuario() != null)
            {
                lblUsuario.Text = $"Seja bem vindo(a) ao sistema {usuarioDAO.getNomeUsuario()}";
                lblUsuario.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
            }
        }

        private void IsPermitido(string nome)
        {
            if (permissaoDAO.temPermissao(usuarioDAO.getUsuario().ToString(),""))
            {
                MessageBox.Show($"Você não tem acesso a essa aba: {nome}!","SEM PERMISSÃO",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                TabControlNutreasy.SelectedTab = tabMenu;
            }
        }

        private void PermitirApenasNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tabMenu_Enter(object sender, EventArgs e)
        {
            mCardAtendimentoAtual.BackColor = Color.Red;
            tabMenu_Click(sender, e);
        }

        public void ImporterWorksheet(string caminhoExcel, OpenFileDialog ofd)
        {
            if (ofd.FileName == "")
            {
                ofd.FileName = caminhoExcel;
                txtCaminhoArquivoExcel.Text = caminhoExcel;
            }
            else if (ofd.FileName != "")
            {
                txtCaminhoArquivoExcel.Text = ofd.FileName;
            }
            else
            {
                MessageBox.Show(this, "Não foi possível localizar o caminho do excel!", "ERRO CAMINHO", MessageBoxButtons.OK);
                return;
            }

            txtCaminhoArquivoExcel.Refresh();

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
                _cbxNomePlanilha.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, MsgBoxStyle.Critical, "ERRO AO SALVAR");
            }
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

        private void tabMenu_Click(object sender, EventArgs e)
        {
            var ConsultasMarcada = this.agendaDAO.CarregarConsultasMenu(DateAndTime.Now.ToString("dd/MM/yyyy"));

            if (ConsultasMarcada != null)
                ConsultasMarcada.ForEach(x =>
                {
                    if (x.data == DateTime.Now.ToString("dd/MM/yyyy") && x.Cancelado == 0)
                    {
                        if (Convert.ToDateTime(x.data + ' ' + x.hora) <= DateTime.Now && x.atendido != true)
                        {
                            mCardAtendimentoAtual.Visible = true;
                            mlblNome.Text = x.paciente;
                            mlblHorario.Text = x.data + ' ' + x.hora;
                            if ((bool)x.retorno)
                            {
                                mlblObservação.Text = "Retorno";
                            }
                            else
                            {
                                mlblObservação.Text = "";
                            }
                            if ((bool)x.atendido)
                            {
                                mCardAtendimentoAtual.BackColor = Color.LightGreen;
                            }
                        }
                        else if (Convert.ToDateTime(x.data + ' ' + x.hora) > DateTime.Now && x.Cancelado == 0)
                        {
                            if (Convert.ToDateTime(x.data + ' ' + x.hora) > DateTime.Now)
                            {
                                mCardAtendimentoFuturo.Visible = true;
                                mlblNomeFuturo.Text = x.paciente;
                                mlblHoraFutura.Text = x.data + ' ' + x.hora;
                                if ((bool)x.retorno)
                                {
                                    mlblObservacaoFuturo.Text = "Retorno";
                                }
                                else
                                {
                                    mlblObservacaoFuturo.Text = "";
                                }
                                if ((bool)x.atendido)
                                {
                                    mCardAtendimentoFuturo.BackColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                mCardAtendimentoFuturo.Visible = false;
                            }
                        }
                        else
                        {
                            mCardAtendimentoAtual.Visible = false;
                        }
                    }
                });
            //timer1.Enabled = true;
            //mCardConsultas.BackColor = mCardConsultas.BackColor == Color.Red ? Color.White : Color.Red;
        }
        #endregion

        #region Agenda
        private void tabAgenda_Enter(object sender, EventArgs e)
        {
            calAgendamento.Items.Clear();
            var agendados = agendaDAO.CarregarAgenda(DateTime.Now.ToString("dd/MM/yyyy"));
            if (agendados is null || agendados.Count == 0)
                return;

            agendados.ForEach(x =>
            {
                CalendarItem calAgendamentos = new CalendarItem(calAgendamento, Convert.ToDateTime(x.data + ' ' + x.hora), Convert.ToDateTime(x.data + ' ' + x.hora).AddHours(1), x.paciente);
                calAgendamento.Items.Add(calAgendamentos);
            });
        }

        private void calAgendamento_ItemCreated(object sender, System.Windows.Forms.Calendar.CalendarItemCancelEventArgs e)
        {
            if (nMensagemAlerta($"Você deseja agendar o paciente {e.Item.Text} para {e.Item.StartDate}") == DialogResult.Yes)
                agendaDAO.AdicionarPaciente(
                            (e.Item.StartDate.ToString()).Substring(0, 10),
                            (e.Item.StartDate.ToString()).Substring(11, 5),
                            e.Item.Text.ToString(),
                            false,
                            false,
                            0,
                            false);
        }

        private void calAgendamento_ItemDatesChanged(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            if (nMensagemAlerta($"Você deseja alterar o paciente {e.Item.Text.ToString()} para {e.Item.StartDate.ToString()}") == DialogResult.Yes)
                agendaDAO.AdicionarPaciente(
                            (e.Item.StartDate.ToString()).Substring(0, 10),
                            (e.Item.StartDate.ToString()).Substring(11, 5),
                            e.Item.Text.ToString(),
                            false,
                            false,
                            0,
                            true);
        }

        private void calAgendamento_ItemDeleted(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            if (nMensagemAlerta($"Você deseja excluir a consulta do paciente {e.Item.Text}") == DialogResult.Yes)
            {
                agendaDAO.DeletarPacienteAgenda(e.Item.Text);
            }
            else
            {
                tabAgenda_Enter(sender, e);
            }
        }

        private void mcbxCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxCancelar.Checked == false)
                return;

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != "")
                temRetorno = true;

            if (nMensagemAlerta("Deseja realmente cancelar esta consulta?") == DialogResult.Yes)
                CancelarAtendimento(Convert.ToString(mlblHorario.Text), mlblNome.Text, mcbxAtendido.Checked, temRetorno);
            else
                mcbxCancelar.Checked = false;

            tabMenu_Click(sender, e);
        }

        private void mcbxAtendido_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mcbxAtendido.Checked == false)
                return;

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != "")
                temRetorno = true;

            if (nMensagemAlerta("Deseja realmente finalizar esta consulta?") == DialogResult.Yes)
                FinalizarAtendimento(Convert.ToString(mlblHorario.Text), mlblNome.Text, mcbxAtendido.Checked, temRetorno);
            else
                mcbxAtendido.Checked = false;

            tabMenu_Click(sender, e);
        }

        private void mcbxAtendidoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxAtendidoFuturo.Checked == false)
                return;

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != "")
                temRetorno = true;

            if (nMensagemAlerta("Deseja realmente finalizar esta consulta?") == DialogResult.Yes)
                FinalizarAtendimento(Convert.ToString(mlblHoraFutura.Text), mlblNomeFuturo.Text, mcbxAtendidoFuturo.Checked, temRetorno);
            else
                mcbxAtendidoFuturo.Checked = false;

            tabMenu_Click(sender, e);
        }

        private void mcbxCancelarFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxCancelarFuturo.Checked == false)
                return;

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != "")
                temRetorno = true;

            if (nMensagemAlerta("Deseja realmente cancelar esta consulta?") == DialogResult.Yes)
                CancelarAtendimento(Convert.ToString(mlblHoraFutura.Text), mlblNomeFuturo.Text, mcbxAtendidoFuturo.Checked, temRetorno);
            else
                mcbxCancelarFuturo.Checked = false;

            tabMenu_Click(sender, e);
        }

        private void CancelarAtendimento(string data, string paciente, bool atendido, bool retorno)
        {
                agendaDAO.AdicionarPaciente(data.Substring(0, 10), data.Substring(11), paciente, atendido, retorno, 1,true);
        }

        private void FinalizarAtendimento(string data, string paciente, bool atendido, bool retorno)
        {
                agendaDAO.AdicionarPaciente(data.Substring(0, 10), data.Substring(11), paciente, atendido, retorno, 0,true);
        }
        #endregion

        #region Alimento
        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            if (quantidadeSalva != 0)
                if (dtgConAlimento.Rows.Count > 0)
                {
                    RecalcularMacroNutrientes(dtgConAlimento, quantidadeSalva);
                }
                else
                {
                    MessageBox.Show(this, "Não foram encontrados itens para recalcular.");
                }
            quantidadeSalva = 0;
        }

        void RecalcularMacroNutrientes(DataGridView dtg, decimal qtdSalva)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                decimal ProteinaKcal = 0;
                decimal CarboidratoKcal = 0;
                decimal LipidioKcal = 0;

                if (Conversions.ToDecimal(row.Cells["qtd"].Value) == qtdSalva)
                    continue;

                if (row.DefaultCellStyle.BackColor == Color.Red || row.DefaultCellStyle.BackColor == Color.LightSalmon)
                {
                    if (row.Cells["prot"].Value != null)
                    {
                        decimal ProteinaGramas = 0; //Refazer o cálculo, se for mudar a qtd, teria que ser, ex: 100g - 22g de prot, 50g - x g de prot
                        ProteinaGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["prot"].Value)) / Conversions.ToDecimal(qtdSalva));
                        ProteinaKcal = ProteinaGramas * 4;
                        row.Cells["prot"].Value = Conversions.ToDecimal(ProteinaKcal);
                    }

                    if (row.Cells["carbo"].Value != null)
                    {
                        decimal CarboidratoGramas = 0;
                        CarboidratoGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["carbo"].Value)) / Conversions.ToDecimal(qtdSalva));
                        CarboidratoKcal = CarboidratoGramas * 4;
                        row.Cells["carbo"].Value = Conversions.ToDecimal(CarboidratoKcal);
                    }

                    if (row.Cells["lipidio"].Value != null)
                    {
                        decimal LipidioGramas = 0;
                        LipidioGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["lipidio"].Value)) / Conversions.ToDecimal(qtdSalva));
                        LipidioKcal = LipidioGramas * 9;
                        row.Cells["lipidio"].Value = LipidioKcal;
                    }

                    decimal somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal;
                    row.Cells["kcal"].Value = Conversions.ToDecimal(somaTotalCaloria);
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dtgDadosImportados_DragDrop(object sender, DragEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
                string caminhoArquivo = fileList.GetValue(0).ToString();
                txtCaminhoArquivoExcel.Text = caminhoArquivo;
                ImporterWorksheet(caminhoArquivo, ofd);
            }
        }

        private void dtgDadosImportados_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
            {
                String[] strGetFormats = e.Data.GetFormats();
                e.Effect = DragDropEffects.None;
            }
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
            //pbCarregando.Visible = true;
            using (TransactionScope tscope = new TransactionScope(TransactionScopeOption.Suppress))
            {
                try
                {
                    foreach (DataGridViewRow row in dtgDadosImportados.Rows)
                    {
                        string alimento = "";
                        double qtd = 0;
                        double kcal = 0;
                        double Prot = 0;
                        double Carb = 0;
                        double Lipidios = 0;
                        string tabela = "";

                        try
                        {
                            alimento = Convert.ToString(row.Cells["Alimento"].Value);
                            qtd = Convert.ToDouble(row.Cells["qtd"].Value);
                            kcal = Convert.ToDouble(row.Cells["kcal"].Value);
                            Prot = Convert.ToDouble(row.Cells["prot"].Value);
                            Carb = Convert.ToDouble(row.Cells["carb"].Value);
                            Lipidios = Convert.ToDouble(row.Cells["lip"].Value);
                        }
                        catch
                        {
                            continue;
                        }

                        try
                        {
                            if (Convert.ToString(row.Cells["REF"].Value) != "")
                            {
                                tabela = Convert.ToString(row.Cells["REF"].Value);
                            }
                        }
                        catch
                        {
                            tabela = Convert.ToString(txtNomeTabela.Text);
                        }
                        if (!alimentoDAO.ExisteAlimento(alimento, tabela))
                        {
                            alimentoDAO.Salvar(alimento.Replace("'", ""), qtd, kcal, Prot, Carb, Lipidios, tabela);
                        }
                        else
                        {
                            alimentoDAO.Update(Convert.ToInt32(alimentoDAO.RetornaCodAlimentoExistente(alimento.Replace("'", ""), tabela)), alimento.Replace("'", ""), qtd, kcal, Prot, Carb, Lipidios, tabela);
                        }
                    };
                    //pbCarregando.Visible = false;
                    Interaction.MsgBox("Os dados foram Salvos", MsgBoxStyle.OkOnly, "SALVAR");
                }
                catch (Exception ex)
                {
                    //pbCarregando.Visible = false;
                    Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException + Environment.NewLine, MsgBoxStyle.Critical, "ERRO AO SALVAR");
                    return;
                }
                tscope.Complete();
            }

            dtgDadosImportados.Rows.Clear();
            dtgDadosImportados.Columns.Clear();
            txtCaminhoArquivoExcel.Text = "";
            _cbxNomePlanilha.Items.Clear();
            txtNomeTabela.Text = "";

        }

        private void _btnBuscarPlanilha_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImporterWorksheet(txtCaminhoArquivoExcel.Text, ofd);
                }
            }
        }

        private void tabAlimento_Enter(object sender, EventArgs e)
        {
            IsPermitido(tabAlimento.Text.ToString());
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
                    alimentoDAO.Salvar(row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDouble(row.Cells["qtd"].Value), Convert.ToDouble(row.Cells["kcal"].Value)
                                   , Convert.ToDouble(row.Cells["prot"].Value), Convert.ToDouble(row.Cells["carbo"].Value), Convert.ToDouble(row.Cells["lipidio"].Value), cbxTabela.Text.ToString());
                }
                else if (row.DefaultCellStyle.BackColor == Color.LightSalmon)
                {
                    alimentoDAO.Update(Convert.ToInt16(row.Cells["codAlimento"].Value), row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDouble(row.Cells["qtd"].Value),
                        Convert.ToDouble(row.Cells["kcal"].Value), Convert.ToDouble(row.Cells["prot"].Value), Convert.ToDouble(row.Cells["carbo"].Value), Convert.ToDouble(row.Cells["lipidio"].Value), cbxTabela.Text.ToString());
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

        private void _cbxNomePlanilha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<DataGridViewColumn> colunasDescartadas = new List<DataGridViewColumn>();
            var dt = tables[_cbxNomePlanilha.SelectedItem.ToString().Replace(",", ".")];
            dtgDadosImportados.DataSource = dt;
            foreach (DataGridViewColumn column in dtgDadosImportados.Columns)
            {
                Boolean existe = false;
                if ((column.HeaderText.ToUpper()).Contains("alimento".ToUpper()))
                {
                    column.HeaderText = "Alimento";
                    column.Name = "alimento";
                    existe = true;
                }
                if ((column.HeaderText.ToUpper()).Contains("prot".ToUpper()))
                {
                    column.HeaderText = "Proteína";
                    column.Name = "prot";
                    existe = true;
                }
                if ((column.HeaderText.ToUpper()).Contains("carb".ToUpper()))
                {
                    column.HeaderText = "Carboidrato";
                    column.Name = "carb";
                    existe = true;
                }
                if ((column.HeaderText.ToUpper()).Contains("lip".ToUpper()) || ((column.HeaderText.ToUpper()).Contains("total".ToUpper())))
                {
                    column.HeaderText = "Lipídio";
                    column.Name = "lip";
                    existe = true;
                }
                if ((column.HeaderText.ToUpper()).Contains("kcal".ToUpper()))
                {
                    column.HeaderText = "KCal";
                    column.Name = "kcal";
                    existe = true;
                }
                if ((column.HeaderText.ToUpper()).Contains("qtd".ToUpper()) || ((column.HeaderText.ToUpper()).Contains("pl".ToUpper())) || ((column.HeaderText.ToUpper()).Contains("Quantidade".ToUpper())))
                {
                    column.HeaderText = "Quantidade";
                    column.Name = "qtd";
                    existe = true;
                }
                if (!existe)
                {
                    colunasDescartadas.Add(column);
                }
            }

            colunasDescartadas.ForEach(x =>
            {
                dtgDadosImportados.Columns.Remove(x);
            });
        }

        private void dtgConAlimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
                if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString() != "")
                    deletarAlimento.Add(dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString());
        }

        private void tbCadMedCaseira_Enter(object sender, EventArgs e)
        {
            //dtgMedCaseiraAlimentos.DataSource = null;

            //var listaAlimentos = alimentoDAO.Buscar("", "");
            //if (listaAlimentos == null)
            //    return;
            //DataTable dt = ConvertToDataTable(listaAlimentos);
            //dtgMedCaseiraAlimentos.DataSource = dt;

            //dtgMedCaseiraAlimentos.Columns["codAlimento"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["MedidaCaseira"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["Cardapio"].Visible = false;
            //dtgMedCaseiraAlimentos.Columns["nomeTabela"].HeaderText = "Tabela";
            //dtgMedCaseiraAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";

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
                    medidaCaseiraDAO.Salvar(rows.Cells["desc"].Value.ToString(), Convert.ToDouble(rows.Cells["qtd"].Value), Convert.ToInt32(txtCodAlimentoMedCas.Text));
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
        private void _tbConsulta_Enter(object sender, EventArgs e)
        {
            tabAlimento_Enter(sender, e);
        }

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (cbxTabela.Text != "" && txtAlimentoFiltro.Text != "")
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
                dtgConAlimento.Columns["nomeTabela"].Visible = false;
                dtgConAlimento.Columns["MedidaCaseira"].Visible = false;
                dtgConAlimento.Columns["Cardapio"].Visible = false;
                return;
            }
        }

        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgConAlimento.DataSource = null;
            var listaAlimentos = alimentoDAO.Buscar("", cbxTabela.Text);
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
            dtgConAlimento.Columns["nomeTabela"].Visible = false;
            dtgConAlimento.Columns["MedidaCaseira"].Visible = false;
            dtgConAlimento.Columns["Cardapio"].Visible = false;
            return;
        }
        #endregion

        #region CadastroPaciente 

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
        private void _btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPaciente.Text))
            {
                pacienteDAO.Deletar(Convert.ToDouble(txtCodPaciente.Text));
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
                txtCodPaciente.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["codPaciente"].Value);
                txtNome.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["nome"].Value);
                txtCPF.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["CPF"].Value);
                txtDtNasc.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["dtNasc"].Value);
                txtEmail.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["email"].Value);
                txtCEP.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["CEP"].Value);
                txtNumero.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["numero"].Value);
                txtComplemento.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["complemento"].Value);
                txtTelefone.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["telefone"].Value);
                txtCelular.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["celular"].Value);
                txtBairro.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["bairro"].Value);
                txtMunicipio.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["municipio"].Value);
                txtEndereco.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["endereco"].Value);
                txtUF.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["UF"].Value);
                if (Convert.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["imagem"].Value) != "")
                {
                    pbImagem.Image = ByteToImage((byte[])_dtgConsultaPacientes.Rows[e.RowIndex].Cells["imagem"].Value);
                }
                tbPaciente.SelectedTab = tbCadastro;
                FormatarCampos();
            }
        }

        private void FormatarCampos()
        {
            try
            {
                txtCEP.Text = Convert.ToUInt64(txtCEP.Text).ToString(@"00000\-000");
                txtTelefone.Text = Regex.Replace(txtTelefone.Text, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
                txtCelular.Text = Regex.Replace(txtCelular.Text, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
                txtCPF.Text = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
            }
            catch { }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (txtCEP.Text != "")
            {
                buscaCEP.buscarEndCep(this, txtCEP.Text);
                try
                {
                    txtCEP.Text = Convert.ToUInt64(txtCEP.Text).ToString(@"00000\-000");
                }
                catch { }
            }           
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
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
            btnCapturarImagem.Visible = false;
            _dtgConsultaPacientes.DataSource = null;
            var listaPacientes = pacienteDAO.Buscar("");

            if (listaPacientes == null)
                return;
            DataTable dt = ConvertToDataTable(listaPacientes);
            _dtgConsultaPacientes.DataSource = dt;

            _dtgConsultaPacientes.Columns["codPaciente"].Visible = false;
            _dtgConsultaPacientes.Columns["imagem"].HeaderText = "Foto";
            _dtgConsultaPacientes.Columns["Cardapio"].Visible = false;
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
            //var resposta = MessageBox.Show("Deseja selecionar uma foto?", Text, MessageBoxButtons.YesNoCancel);

            //if (resposta == System.Windows.Forms.DialogResult.Yes)
            //{
            //    btnCapturarImagem.Visible = true;
            //    CamContainer = new DirectX.Capture.Filters();

            //    try
            //    {
            //        int no_of_cam = CamContainer.VideoInputDevices.Count;
            //        for (int i = 0; i < no_of_cam; i++)
            //        {
            //            try
            //            {
            //                // obtém o dispositivo de entrada do vídeo
            //                Camera = CamContainer.VideoInputDevices[i];

            //                // inicializa a Captura usando o dispositivo
            //                CaptureInfo = new DirectX.Capture.Capture(Camera, null);

            //                // Define a janela de visualização do vídeo
            //                CaptureInfo.PreviewWindow = this.pbImagem;

            //                // Capturando o tratamento de evento
            //                CaptureInfo.FrameCaptureComplete += AtualizaImagem;

            //                // Captura o frame do dispositivo
            //                CaptureInfo.CaptureFrame();

            //                // Se o dispositivo foi encontrado e inicializado então sai sem checar o resto
            //                break;
            //            }
            //            catch (Exception ex)
            //            {
            //                btnCapturarImagem.Visible = false;
            //                throw ex;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        btnCapturarImagem.Visible = false;
            //        MessageBox.Show(this, ex.Message);
            //    }

            //}
            //else if (resposta == System.Windows.Forms.DialogResult.No)
            //{

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
            catch
            {
                MessageBox.Show("Nenhuma imagem foi selecionada!");
            }

            //}
            //else
            //{
            //    return;
            //}
        }
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            pacienteDAO.Buscar(txtNome.Text);
        }

        //public void AtualizaImagem(PictureBox frame)
        //{
        //    try
        //    {
        //        capturaImagem = frame.Image;
        //        this.pbImagem.Image = capturaImagem;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro " + ex.Message);
        //    }
        //}

        //private void btnCapturarImagem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CaptureInfo.CaptureFrame();


        //        //btnCapturarImagem.Visible = false;
        //        //MessageBox.Show("Imagem salva com sucesso");
        //        //pbImagem.Image = null;

        //    }
        //    catch (Exception ex)
        //    {
        //        btnCapturarImagem.Visible = false;
        //        MessageBox.Show("Erro " + ex.Message);
        //    }
        //}
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumero(sender, e);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                txtCPF.Text = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
            }
            catch { }
        }

        private void txtCelular_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtCelular.Text = Regex.Replace(txtCelular.Text, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
            }
            catch { }
        }

        private void txtTelefone_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.Text = Regex.Replace(txtTelefone.Text, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
            }
            catch { }
        }

        private void txtCEP_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumero(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumero(sender, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumero(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumero(sender, e);
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

            double proteina = 0;
            double carboidrato = 0;
            double lipidio = 0;
            double kcal = 0;
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
                    kcal += (double)row.Cells[2].Value;
                    proteina += (double)row.Cells["prot"].Value;
                    carboidrato += (double)row.Cells["carbo"].Value;
                    lipidio += (double)row.Cells["lipidio"].Value;
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

        private void txtPacienteConsultaCardapio_TextChanged(object sender, EventArgs e)
        {
            if (CardapioDAO.codPacienteCard == "")
                return;
            var listaCardapio = cardapioDAO.Consultar(Convert.ToInt32(CardapioDAO.codPacienteCard));
            if (listaCardapio == null)
                return;
            else if (listaCardapio.Count == 0)
                return;
            trwDadosCard.Nodes.Clear();

            TreeGridColumn refeicaoColumn = new TreeGridColumn();

            refeicaoColumn.DefaultNodeImage = null;
            refeicaoColumn.FillWeight = 50F;
            refeicaoColumn.HeaderText = "Refeição";
            refeicaoColumn.Name = "refeicao";
            refeicaoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            trwDadosCard.Columns.Add(refeicaoColumn);

            TreeGridNode rootNode = trwDadosCard.Nodes.Add("Refeições");
            rootNode.ImageIndex = 0;

            // Cria os nós filhos para o raiz
            TreeGridNode cafe = rootNode.Nodes.Add("Café da manhã");
            cafe.ImageIndex = 1;
            TreeGridNode Lanche = rootNode.Nodes.Add("Lanche");
            Lanche.ImageIndex = 1;
            TreeGridNode Almoco = rootNode.Nodes.Add("Almoço");
            Almoco.ImageIndex = 1;
            TreeGridNode LancheTarde = rootNode.Nodes.Add("Lanche da tarde");
            LancheTarde.ImageIndex = 1;
            TreeGridNode Jantar = rootNode.Nodes.Add("Jantar");
            Jantar.ImageIndex = 1;
            TreeGridNode Ceia = rootNode.Nodes.Add("Ceia");
            Ceia.ImageIndex = 1;
            listaCardapio.ForEach(card =>
            {
                switch (card.Refeicao)
                {
                    case "Café da manhã":
                        TreeGridNode filhoCafe = cafe.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("");
                        return;

                    case "Lanche":
                        TreeGridNode filhoLanche = Lanche.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("");
                        return;

                    case "Almoço":
                        TreeGridNode filhoAlmoco = Almoco.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("");
                        return;

                    case "Lanche da tarde":
                        TreeGridNode filhoLancheTarde = LancheTarde.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("");
                        return;

                    case "Jantar":
                        TreeGridNode filhoJantar = Jantar.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("");
                        return;

                    case "Ceia":
                        TreeGridNode filhoCeia = Ceia.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Obs: " + card.Obs.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("");
                        return;
                }
            });
        }

        private void CarregarGrafico(double proteina, double carboidrato, double lipidio)
        {
            graficoMacroNutri.Series = null;
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Proteína",
                        Values = new ChartValues<double> {proteina},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Carboidrato",
                        Values = new ChartValues<double> {carboidrato},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Lipídios",
                        Values = new ChartValues<double> {lipidio},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                };
            graficoMacroNutri.Series = piechartData;
            graficoMacroNutri.LegendLocation = LegendLocation.Right;
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
            double Kcal = Convert.ToDouble(lblValorKcal.Text.Split(' ')[0]);

            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                cardapioDAO.Salvar(Convert.ToString(CardapioDAO.codPacienteCard),
                                                    Convert.ToInt32(row.Cells["codAlimento"].Value),
                                                    Convert.ToString(cbxRefeicao.Text),
                                                    Convert.ToInt32(row.Cells["qtd"].Value),
                                                    Convert.ToString(row.Cells["obs"].Value),
                                                    Convert.ToDouble(row.Cells["kcal"].Value));
            dtgRefeicoes.DataSource = null;
            graficoMacroNutri.Series = null;
            txtPaciente.Text = null;
            cbxRefeicao.Text = null;
            lblValorKcal.Text = null;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
            CardapioDAO.codPacienteCard = null;
            CardapioDAO.nomePacienteCard = null;
            btnApagar_Click(sender, e);
            btnCancelarCardapio_Click(sender, e);
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
                if (Convert.ToString(dtgConAlimento.CurrentRow.Cells["qtd"].Value) != "")
                    quantidadeSalva = Convert.ToDecimal(dtgConAlimento.CurrentRow.Cells["qtd"].Value);
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

        private void btnConfigGramasCard_Click(object sender, EventArgs e)
        {

        }
        private void dtgRefeicoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgRefeicoes.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
            if (Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value) != quantidadeAntigaCardapio)
            {
                RecalcularMacroNutrientes(dtgRefeicoes, Convert.ToDecimal(quantidadeAntigaCardapio));

                CarregarGrafico(Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["prot"].Value),
                                Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["carbo"].Value),
                                Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["lipidio"].Value));
            }
            quantidadeAntigaCardapio = 0;
        }
        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this);
            buscaPacientes.ShowDialog();
        }
        private void dtgRefeicoes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value) != 0)
                quantidadeAntigaCardapio = Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value);

        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPacienteConsultaCardapio.Clear();
            trwDadosCard.Nodes.Clear();
        }


        private void cbxTabelaAlimentoCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTabelaAlimentoCardapio.Text != "")
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
                dtgCardapioAlimentos.Columns["nomeAlimento"].ReadOnly = true;
            }
        }
        private void btnCancelarCardapio_Click(object sender, EventArgs e)
        {
            txtPaciente.Text = "";
            CardapioDAO.codPacienteCard = "";
            CardapioDAO.nomePacienteCard = "";
            txtPacienteConsultaCardapio.Text = "";
            dtgRefeicoes.DataSource = null;
            dtgRefeicoes.Rows.Clear();
            dtgRefeicoes.Columns.Clear();
            cbxTabelaAlimentoCardapio.Text = "";
            dtgCardapioAlimentos.DataSource = null;
            dtgCardapioAlimentos.Rows.Clear();
            dtgCardapioAlimentos.Columns.Clear();
            graficoMacroNutri.Series = null;
            trwDadosCard.Nodes.Clear();
            lblValorKcal.Text = "";
            cbxRefeicao.SelectedIndex = -1;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
        }

        private void tbConsultaCardapio_Click(object sender, EventArgs e)
        {

        }

        private void tbConsultaCardapio_Enter(object sender, EventArgs e)
        {
            //var consultaPaciente = cardapioDAO.Consultar(Convert.ToInt32(txtPacienteConsultaCardapio.Text));
            //if (consultaPaciente is null || consultaPaciente.Count == 0)
            //    return;

            //consultaPaciente.ForEach(pac =>
            //{
            //});

        }

        private void btnCancelarEditAlimentos_Click(object sender, EventArgs e)
        {
            cbxTabela.SelectedIndex = -1;
            txtAlimentoFiltro.Text = "";
            if (dtgConAlimento.Rows.Count > 0)
                dtgConAlimento.Rows.Clear();
            if (dtgConAlimento.Columns.Count > 0)
                dtgConAlimento.Columns.Clear();
        }
        #endregion

        #region Configurações
        [Obsolete]
        private void btnSalvarConfigUsuario_Click(object sender, EventArgs e)
        {
            bool alterarSenha = false;
            if (txtUsuarioConfig.Text == "")
            {
                Interaction.MsgBox("O usuário não foi informado");
                return;
            }
           
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Interaction.MsgBox("As senhas não conferem");
                return;
            }

            if (usuarioDAO.VerificarExisteUsuario(txtUsuarioConfig.Text))
            {
                if (Interaction.MsgBox("Você deseja alterar a senha do usuário?", MsgBoxStyle.YesNo, "ALTERAÇÃO DE SENHA") == MsgBoxResult.Yes)
                    alterarSenha = true;
                usuarioDAO.AlterarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha, txtCRN.Text);
                tbConfig_Enter(sender, e);
            }
            else
            {
                usuarioDAO.CriarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text,txtCRN.Text);
                tbConfig_Enter(sender, e);
            }
        }
        private void tbConfig_Enter(object sender, EventArgs e)
        {
            var listaUsuario = usuarioDAO.getUsuario("");
            if (listaUsuario == null)
                return;
            DataTable dt = ConvertToDataTable(listaUsuario);
            dtgUsuarios.DataSource = dt;
            dtgUsuarios.Columns["senha"].Visible = false;
            dtgUsuarios.Columns["usuario"].HeaderText = "Usuário";
            dtgUsuarios.Columns["nome"].HeaderText = "Nome";
            dtgUsuarios.Columns["situacao"].HeaderText = "Situação";
            dtgUsuarios.Columns["email"].HeaderText = "E-mail";
            dtgUsuarios.Columns["perfil"].HeaderText = "Perfil";
            dtgUsuarios.Columns["crn"].HeaderText = "CRN";
            dtgUsuarios.Columns["Permissao"].Visible = false;
            dtgUsuarios.AutoResizeColumns();
        }
        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtUsuarioConfig.Text = dtgUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
                txtNomeUsuarioConfig.Text = dtgUsuarios.CurrentRow.Cells["nome"].Value.ToString();
                txtEmailConfig.Text = dtgUsuarios.CurrentRow.Cells["email"].Value.ToString();
                cbxSituacao.Text = dtgUsuarios.CurrentRow.Cells["situacao"].Value.ToString();
                cbxTipoUsuario.Text = dtgUsuarios.CurrentRow.Cells["perfil"].Value.ToString();
                txtCRN.Text = dtgUsuarios.CurrentRow.Cells["crn"].Value.ToString();
            }
        }
        private void tbPermissao_Enter(object sender, EventArgs e)
        {
            var listaUsuarios = usuarioDAO.getAllUsuarios();

            if (listaUsuarios.Count <= 0)
                return;

            listaUsuarios.ForEach(x => cbxUsuarioPerm.Items.Add(x));
        }
        private void txtUsuarioConfig_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text != "")
                usuarioDAO.getUsuario(txtUsuarioConfig.Text);
        }

        private void btnSalvarPermissao_Click(object sender, EventArgs e)
        {
            permissaoDAO.AdicionarPermissao(Convert.ToString(cbxUsuarioPerm.Text), Convert.ToString(cbxTelaLiberarPerm.Text));
        }

        private void btnExcluirConfigUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text == "")
            {
                nMensagemAlerta("É necessário informar o usuário no campo para remover.");
                return;
            }
            usuarioDAO.Deletar(txtUsuarioConfig.Text);
        }

        private void dtgUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                usuarioDAO.Deletar(Convert.ToString(dtgUsuarios.CurrentRow.Cells["usuario"].Value));
            }
        }
        #endregion

        private void materialButton3_Click(object sender, EventArgs e)
        {
            calAgendamento.ViewEnd = DateTime.Now.AddDays(1);
        }

        private void cbxUsuarioPerm_SelectedIndexChanged(object sender, EventArgs e)
        {
           // permissaoDAO.
        }
    }
}