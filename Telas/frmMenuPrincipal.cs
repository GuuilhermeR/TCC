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
using NutriEz.Banco_de_Dados;
using AdvancedDataGridView;
using System.Text.RegularExpressions;
using DAO;
using static Classes.HelperFuncoes;
using System.Windows.Forms.Calendar;
using NutriEz.Telas;
using NutriEz.DAO;
using System.Globalization;
using Aspose.Cells;
using NutriEz.Properties;
using System.Threading;
using Model;
using System.Diagnostics;

namespace NutriEz
{
    public partial class FrmMenuPrincipal : MaterialForm
    {

        #region Variáveis Globais
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        public AlimentoDAO alimentoDAO = new AlimentoDAO();
        public AgendaDAO agendaDAO = new AgendaDAO();
        public MedidaCaseiraDAO medidaCaseiraDAO = new MedidaCaseiraDAO();
        public PermissaoDAO permissaoDAO = new PermissaoDAO();
        public CardapioDAO cardapioDAO = new CardapioDAO();
        public ConfiguracoesDAO configDAO = new ConfiguracoesDAO();
        public BuscadorCEP buscaCEP = new BuscadorCEP();
        public AnamneseDAO anamneseDAO = new AnamneseDAO();
        public AntropometriaDAO antropometriaDAO = new AntropometriaDAO();
        private DataTableCollection tables;
        List<string> deletarAlimento = new List<string>();
        private object tamanhoArquivoImagem;
        private byte[] vetorImagens;
        private decimal quantidadeSalva;
        private decimal kCalAntiga;
        private double quantidadeAntigaCardapio;
        //Image capturaImagem;
        public string caminhoImagemSalva = null;
        public DateTime dataAgendadoAnterior = Convert.ToDateTime("01/01/1001");
        public bool jaIniciou = false;
        private bool primeiraVez = true;
        private DateTime dataHoraNotif = DateTime.Now;
        private bool usuarioViaLogin = false;
        static Thread tLoad;
        #endregion

        #region Listas Pré Carregadas
        List<Alimentos> listaAlimentosCardapio = new List<Alimentos>();
        List<Alimentos> listaAlimentos = new List<Alimentos>();
        List<Paciente> listaPacientes = new List<Paciente>();
        #endregion

        #region Menu
        public FrmMenuPrincipal(string usuarioLogado, bool utilizouLogin)
        {
            InitializeComponent();
            usuarioViaLogin = utilizouLogin;
            usuarioDAO.setNomeUsuario(usuarioLogado);
            var OpcoesMenu = new ContextMenu();
            OpcoesMenu.MenuItems.Add(new MenuItem("Deslogar", Deslogar));
            OpcoesMenu.MenuItems.Add(new MenuItem("Fechar", FecharAplicacao));
            NutriEzIconNotify.ContextMenu = OpcoesMenu;
        }

        private void PreCarregarPacientes()
        {
            var pacientes = pacienteDAO.Buscar(string.Empty);

            if (pacientes is null || pacientes.Count == 0)
                return;

            pacientes.ForEach(x =>
            {
                listaPacientes.Add(x);
            });
            tLoad.Abort();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            FormatView(this);
            BancoDadosSingleton.Instance.Configuration.AutoDetectChangesEnabled = true;
            BancoDadosSingleton.Instance.Configuration.ValidateOnSaveEnabled = true;
            BancoDadosSingleton.Instance.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
            if (!usuarioViaLogin)
            {
                FecharAplicacao(sender, e);
            }
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://forms.office.com/r/EzCikDHZee");
            calAgendamento.MaximumViewDays = 70000;

            tLoad = new Thread(PreCarregarPacientes);
            tLoad.Start();

            if (usuarioDAO.getNomeUsuario() != null)
            {
                lblUsuario.Text = $"Seja bem vindo(a) ao sistema {usuarioDAO.getNomeUsuario()}, clique aqui caso deseja deslogar do sistema.";
                lblUsuario.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
            }

        }
        private bool VerificarPermissao(string telaPermissao)
        {
            if (!permissaoDAO.VerificarPermissao(Convert.ToString(usuarioDAO.getUsuario()), telaPermissao))
            {
                nMensagemAviso("Você não possui permissão nessa tela!");
                TabControlNutreasy.SelectedTab = tabMenu;
                return false;
            }
            return true;
        }
        private void FecharAplicacao(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deslogar(object sender, EventArgs e)
        {
            new frmTelaLogin().Show();
            this.Hide();
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
            if (!VerificarPermissao(tabMenu.Text))
            {
                return;
            };

            mCardAtendimentoAtual.BackColor = Color.Red;
            CarregarCardConsultas();
        }

        public void ImporterWorksheet(string caminhoExcel, OpenFileDialog ofd)
        {
            if (ofd.FileName == string.Empty)
            {
                ofd.FileName = caminhoExcel;
                txtCaminhoArquivoExcel.Text = caminhoExcel;
            }
            else if (ofd.FileName != string.Empty)
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
            dtgDadosImportados.AutoResizeColumns();
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

        private void CarregarCardConsultas()
        {

            var dataAgenda = DateTime.Now.ToString("dd/MM/yyyy");
            var dataInicio = dataAgenda + " 00:00:00";
            var dataFim = dataAgenda + " 23:59:59";
            DateTime dataMarcadasIni = Convert.ToDateTime(dataInicio);
            DateTime dataMarcadasFim = Convert.ToDateTime(dataFim);
            FecharAbrirConexao();
            

            using (var db = new NutreasyEntities())
            {
                var selectAgendamento = db.Database.Connection.CreateCommand();

                selectAgendamento.CommandText = $"SELECT * FROM Agenda " +
                    $"WHERE data>='{dataMarcadasIni.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                    $"AND data<='{dataMarcadasFim.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                    $"AND cancelado=0 " +
                    $"AND atendido=0 " +
                    $"ORDER BY data DESC";

                db.Database.Connection.Open();
                IDataReader dr = selectAgendamento.ExecuteReader();

                mCardAtendimentoAtual.Visible = false;
                mCardAtendimentoFuturo.Visible = false;
                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["data"]) <= DateTime.Now.AddHours(-2) && Convert.ToDateTime(dr["data"]) <= DateTime.Now.AddHours(2))
                    {
                        return;
                    }

                    var horaAtualArredonda = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    horaAtualArredonda = Strings.Left(horaAtualArredonda, 13) + ":00";
                    DateTime dataHoraArredondada = Convert.ToDateTime(horaAtualArredonda);

                    if (Convert.ToDateTime(dr["data"]) <= dataHoraArredondada && (DateTime)dr["data"] <= dataHoraArredondada.AddHours(1))
                    {
                        mCardAtendimentoAtual.Visible = true;
                        mlblNome.Text = (string)dr["paciente"];
                        mlblHorario.Text = Convert.ToDateTime(dr["data"]).ToString("dd/MM/yyyy HH:mm");
                        if ((bool)dr["retorno"])
                        {
                            mlblObservação.Text = "Retorno";
                        }
                        else
                        {
                            mlblObservação.Text = string.Empty;
                        }
                        if ((bool)dr["atendido"])
                        {
                            mCardAtendimentoAtual.BackColor = Color.LightGreen;
                        }
                    }

                    if ((DateTime)dr["data"] >= dataHoraArredondada.AddHours(1))
                    {
                        mCardAtendimentoFuturo.Visible = true;
                        mlblNomeFuturo.Text = (string)dr["paciente"];
                        mlblHoraFutura.Text = Convert.ToDateTime(dr["data"]).ToString("dd/MM/yyyy HH:mm");
                        if ((bool)dr["retorno"])
                        {
                            mlblObservacaoFuturo.Text = "Retorno";
                        }
                        else
                        {
                            mlblObservacaoFuturo.Text = string.Empty;
                        }
                        if ((bool)dr["atendido"])
                        {
                            mCardAtendimentoFuturo.BackColor = Color.LightGreen;
                        }
                    }

                    if (mlblNomeFuturo.Text.Equals(mlblNome.Text))
                    {
                        mCardAtendimentoFuturo.Visible = false;
                    }
                }
                db.Database.Connection.Close();
                if (primeiraVez)
                {
                    if (Convert.ToDateTime(mlblHorario.Text).AddMinutes(-10) >= DateTime.Now && Convert.ToDateTime(mlblHorario.Text).AddMinutes(10) <= DateTime.Now && mCardAtendimentoAtual.Visible)
                    {
                        NutriEzIconNotify.ShowBalloonTip(10, "Atendimento agora", $"Você possui horário agora com: {Convert.ToString(mlblNome.Text)}", ToolTipIcon.Info);
                    }
                    else if (Convert.ToDateTime(mlblHorario.Text) < DateTime.Now && mCardAtendimentoFuturo.Visible)
                    {
                        NutriEzIconNotify.ShowBalloonTip(10, $"Atendimento às {Convert.ToDateTime(mlblHoraFutura.Text).ToString("HH:mm")}", $"Você possui horário marcado com: {Convert.ToString(mlblNomeFuturo.Text)} às {mlblHoraFutura.Text}", ToolTipIcon.Info);
                        dataHoraNotif = DateTime.Now;
                        primeiraVez = false;
                    }
                }
                if (!primeiraVez && dataHoraNotif.AddMinutes(30) >= DateTime.Now && dataHoraNotif.AddMinutes(30) <= DateTime.Now && mCardAtendimentoFuturo.Visible)
                {
                    NutriEzIconNotify.ShowBalloonTip(10, $"Atendimento às {Convert.ToDateTime(mlblHoraFutura.Text).ToString("HH:mm")}", $"Você possui horário marcado com: {Convert.ToString(mlblNomeFuturo.Text)} às {mlblHoraFutura.Text}", ToolTipIcon.Info);
                }
            }
            FecharAbrirConexao();
        }

        #endregion

        #region Agenda

        private void tabAgenda_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabAgenda.Text))
            {
                return;
            };
            txtDataAgendamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            loadStart(this);

            if (!jaIniciou)
            {
                calAgendamento.Items.Clear();
                GetConfigAtendimento();
                if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Saturday) || DateTime.Today.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    calAgendamento.ViewEnd = DateTime.Today.AddDays(5);
                    calAgendamento.ViewStart = DateTime.Today;
                }
                else
                {
                    calAgendamento.ViewEnd = RetornaFimSemana(DateTime.Today);
                    calAgendamento.ViewStart = RetornaInicioSemana(DateTime.Today);
                }
                BuscarConsultasAgendadas();
                calAgendamento.Refresh();
            }
            loadStop(this);

        }
        private void calAgendamento_ItemSelected(object sender, CalendarItemEventArgs e)
        {
            dataAgendadoAnterior = e.Item.StartDate;
        }
        private DateTime RetornaInicioSemana(DateTime data)
        {
            DateTime monday = DateTime.Today.AddDays(-(int)data.DayOfWeek + (int)DayOfWeek.Monday);
            return monday;
        }

        private DateTime RetornaFimSemana(DateTime data)
        {
            DateTime friday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Friday);
            return friday;
        }

        private void GetConfigAtendimento()
        {
            var listaConfigs = configDAO.Consultar();
            if (listaConfigs == null)
                return;

            foreach (var config in listaConfigs)
            {
                TimeSpan horaIni = TimeSpan.Parse(config.horaInicio);
                TimeSpan horaFim = TimeSpan.Parse(config.horaFim);
                var configCalendar = calAgendamento.HighlightRanges;
                switch (config.diaSemana)
                {
                    case "Segunda":
                        configCalendar[0].EndTime = horaFim;
                        configCalendar[0].StartTime = horaIni;
                        configCalendar[0].DayOfWeek = DayOfWeek.Monday;
                        break;
                    case "Terça":
                        configCalendar[1].EndTime = horaFim;
                        configCalendar[1].StartTime = horaIni;
                        configCalendar[1].DayOfWeek = DayOfWeek.Tuesday;
                        break;
                    case "Quarta":
                        configCalendar[2].EndTime = horaFim;
                        configCalendar[2].StartTime = horaIni;
                        configCalendar[2].DayOfWeek = DayOfWeek.Wednesday;
                        break;
                    case "Quinta":
                        configCalendar[3].EndTime = horaFim;
                        configCalendar[3].StartTime = horaIni;
                        configCalendar[3].DayOfWeek = DayOfWeek.Thursday;
                        break;
                    case "Sexta":
                        configCalendar[4].EndTime = horaFim;
                        configCalendar[4].StartTime = horaIni;
                        configCalendar[4].DayOfWeek = DayOfWeek.Friday;
                        break;
                    case "Sábado":
                        configCalendar[5].EndTime = horaFim;
                        configCalendar[5].StartTime = horaIni;
                        configCalendar[5].DayOfWeek = DayOfWeek.Saturday;
                        break;
                    case "Domingo":
                        configCalendar[6].EndTime = horaFim;
                        configCalendar[6].StartTime = horaIni;
                        configCalendar[6].DayOfWeek = DayOfWeek.Sunday;
                        break;
                    default:
                        return;
                }
            }
        }
        private void txtDataAgendamento_Leave(object sender, EventArgs e)
        {
            if (txtDataAgendamento.Text != string.Empty)
            {
                DateTime dt;
                DateTime.TryParseExact(txtDataAgendamento.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

                txtDataAgendamento.Text = FormatDate(txtDataAgendamento.Text);
            }
        }
        private void txtHoraAgenda_Validated(object sender, EventArgs e)
        {
            txtHoraAgenda.Text = formatarHora(txtHoraAgenda.Text);
        }

        private void chkPacNew_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPacNew.Checked)
            {
                txtPacienteAgenda.Enabled = true;
                btnBuscarPacienteAgendamento.Enabled = false;
                cbxRetorno.Enabled = false;
            }
            else
            {
                txtPacienteAgenda.Enabled = false;
                btnBuscarPacienteAgendamento.Enabled = true;
                cbxRetorno.Enabled = true;
            }
        }
        private bool ValidarAgendamento(DateTime data, string hora)
        {
            var configCalendar = calAgendamento.HighlightRanges;
            TimeSpan horario;
            horario = TimeSpan.Parse(hora);
            switch (data.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Tuesday:
                    if (TimeSpan.Compare(horario, configCalendar[1].StartTime) >= 0 && TimeSpan.Compare(configCalendar[1].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Wednesday:
                    if (TimeSpan.Compare(horario, configCalendar[2].StartTime) >= 0 && TimeSpan.Compare(configCalendar[2].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Thursday:
                    if (TimeSpan.Compare(horario, configCalendar[3].StartTime) >= 0 && TimeSpan.Compare(configCalendar[3].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Friday:
                    if (TimeSpan.Compare(horario, configCalendar[4].StartTime) >= 0 && TimeSpan.Compare(configCalendar[4].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Saturday:
                    if (TimeSpan.Compare(horario, configCalendar[5].StartTime) >= 0 && TimeSpan.Compare(configCalendar[5].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Sunday:
                    if (TimeSpan.Compare(horario, configCalendar[6].StartTime) >= 0 && TimeSpan.Compare(configCalendar[6].EndTime, horario) > 0)
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPacienteAgenda.Text))
            {
                nMensagemAviso("Necessário informar o paciente");
                return;
            }
            if (string.IsNullOrEmpty(txtDataAgendamento.Text))
            {
                nMensagemAviso("Necessário informar a data da consulta");
                return;
            }
            if (string.IsNullOrEmpty(txtHoraAgenda.Text))
            {
                nMensagemAviso("Necessário informar a hora da consulta");
                return;
            }

            if (!ValidarAgendamento(Convert.ToDateTime(txtDataAgendamento.Text), Convert.ToString(txtHoraAgenda.Text)))
            {
                nMensagemAviso("Não é possível agendar uma consulta em um horário não disponível do nutricionista!");
                return;
            }
            FecharAbrirConexao();
            if (!agendaDAO.VerificarPacienteAgendado(txtPacienteAgenda.Text, Convert.ToDateTime(txtDataAgendamento.Text)))
            {
                agendaDAO.AtualizarPaciente(
                       Convert.ToString(txtDataAgendamento.Text),
                       txtHoraAgenda.Text,
                       txtPacienteAgenda.Text,
                       false,
                       false,
                       0,
                       true,
                       Convert.ToString(usuarioDAO.getUsuario()));
            }
            else
            {
                agendaDAO.AdicionarPaciente(
                       Convert.ToDateTime(txtDataAgendamento.Text),
                       txtHoraAgenda.Text,
                       txtPacienteAgenda.Text,
                       false,
                       cbxRetorno.Checked,
                       0,
                       true,
                       Convert.ToString(usuarioDAO.getUsuario()));
            }
            LimparCamposAgenda();
            calAgendamento.Items.Clear();
            txtDataAgendamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            BuscarConsultasAgendadas();
        }

        private void LimparCamposAgenda()
        {
            txtPacienteAgenda.Text = string.Empty;
            txtDataAgendamento.Text = string.Empty;
            txtHoraAgenda.Text = string.Empty;
            cbxRetorno.Checked = false;
        }

        private void calAgendamento_ItemCreated(object sender, System.Windows.Forms.Calendar.CalendarItemCancelEventArgs e)
        {
            //if (nMensagemAlerta($"Você deseja agendar o paciente {e.Item.Text} para {e.Item.StartDate}") == DialogResult.Yes)
            //    agendaDAO.AdicionarPaciente(
            //                (e.Item.StartDate.ToString()).Substring(0, 10),
            //                (e.Item.StartDate.ToString()).Substring(11, 5),
            //                e.Item.Text.ToString(),
            //                false,
            //                false,
            //                0,
            //                false);
        }

        private void calAgendamento_ItemDatesChanged(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            if (!ValidarAgendamento(Convert.ToDateTime((e.Item.StartDate.ToString()).Substring(0, 10)), Convert.ToString(e.Item.StartDate.ToString()).Substring(11, 5)))
            {
                nMensagemAviso("Não é possível agendar uma consulta em um horário não disponível do nutricionista!");
                tabAgenda_Enter(sender, e);
                return;
            }
            if (nMensagemAceita($"Você deseja alterar o paciente {e.Item.Text} para {e.Item.StartDate}") == DialogResult.Yes)
            {
                if (agendaDAO.VerificarPacienteAgendado(e.Item.Text.ToString(), Convert.ToDateTime(dataAgendadoAnterior)))
                {
                    agendaDAO.AtualizarPaciente(
                           Convert.ToString(e.Item.StartDate.ToString()),
                           Convert.ToString(dataAgendadoAnterior),
                           e.Item.Text.ToString(),
                           false,
                           false,
                           0,
                           true,
                           Convert.ToString(usuarioDAO.getUsuario()));
                    dataAgendadoAnterior = Convert.ToDateTime("01/01/1001");
                }
                else
                {
                    agendaDAO.DeletarPacienteAgenda(e.Item.Text.ToString(), (e.Item.StartDate.ToString()).Substring(0, 10), (e.Item.StartDate.ToString()).Substring(11, 5));
                    agendaDAO.AdicionarPaciente(
                           Convert.ToDateTime(e.Item.StartDate.ToString().Substring(0, 10)),
                           (e.Item.StartDate.ToString()).Substring(11, 5),
                           e.Item.Text.ToString(),
                           false,
                           false,
                           0,
                           true,
                           Convert.ToString(usuarioDAO.getUsuario()));
                }
            }
            else
            {
                tabAgenda_Enter(sender, e);
            }

        }

        private void calAgendamento_ItemDeleted(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            if (nMensagemAceita($"Você deseja excluir a consulta do paciente {e.Item.Text}") == DialogResult.Yes)
            {
                agendaDAO.DeletarPacienteAgenda(e.Item.Text.ToString()
                    , (e.Item.StartDate.ToString()).Substring(0, 10)
                    , (e.Item.StartDate.ToString()).Substring(11, 5));
            }
            else
            {
                calAgendamento.Items.Clear();
                GetConfigAtendimento();
                txtDataAgendamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
                calAgendamento.ViewStart = RetornaInicioSemana(DateTime.Today);
                calAgendamento.ViewEnd = RetornaFimSemana(DateTime.Today);
                calAgendamento.Refresh();
                BuscarConsultasAgendadas();
            }
        }

        private void mcbxCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxCancelar.Checked == false)
                return;
            FecharAbrirConexao();

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != string.Empty)
                temRetorno = true;

            if (nMensagemAceita("Deseja realmente cancelar esta consulta?") == DialogResult.Yes)
                CancelarAtendimento(Convert.ToString(mlblHorario.Text), mlblNome.Text, mcbxAtendido.Checked, temRetorno);
            else
                mcbxCancelar.Checked = false;

            CarregarCardConsultas();
        }

        private void mcbxAtendido_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mcbxAtendido.Checked == false)
                return;

            FecharAbrirConexao();

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != string.Empty)
                temRetorno = true;

            if (nMensagemAceita("Deseja realmente finalizar esta consulta?") == DialogResult.Yes)
                FinalizarAtendimento(Convert.ToString(mlblHorario.Text), mlblNome.Text, mcbxAtendido.Checked, temRetorno);
            else
                mcbxAtendido.Checked = false;

            CarregarCardConsultas();
            mCardAtendimentoAtual.Visible = false;
        }

        private void mcbxAtendidoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxAtendidoFuturo.Checked == false)
                return;
            FecharAbrirConexao();

            bool temRetorno = false;
            if (Convert.ToString(mlblObservacaoFuturo.Text) != string.Empty)
                temRetorno = true;

            if (nMensagemAceita("Deseja realmente finalizar esta consulta?") == DialogResult.Yes)
                FinalizarAtendimento(Convert.ToString(mlblHoraFutura.Text), mlblNomeFuturo.Text, mcbxAtendidoFuturo.Checked, temRetorno);
            else
                mcbxAtendidoFuturo.Checked = false;

            mCardAtendimentoFuturo.Visible = false;
            CarregarCardConsultas();
        }

        private void mcbxCancelarFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbxCancelarFuturo.Checked == false)
                return;
            FecharAbrirConexao();

            bool temRetorno = false;
            if (Convert.ToString(mlblObservação.Text) != string.Empty)
                temRetorno = true;

            if (nMensagemAceita("Deseja realmente cancelar esta consulta?") == DialogResult.Yes)
                CancelarAtendimento(Convert.ToString(mlblHoraFutura.Text), mlblNomeFuturo.Text, mcbxAtendidoFuturo.Checked, temRetorno);
            else
                mcbxCancelarFuturo.Checked = false;

            mCardAtendimentoFuturo.Visible = false;
            CarregarCardConsultas();
        }

        private void CancelarAtendimento(string data, string paciente, bool atendido, bool retorno)
        {
            FecharAbrirConexao();
            agendaDAO.AtualizarSituacaoAtendimento(Convert.ToString(data.Substring(0, 10)), data.Substring(11), paciente, atendido, retorno, 1, Convert.ToString(usuarioDAO.getUsuario()));
        }

        private void FinalizarAtendimento(string data, string paciente, bool atendido, bool retorno)
        {
            FecharAbrirConexao();
            agendaDAO.AtualizarSituacaoAtendimento(Convert.ToString(data.Substring(0, 10)), data.Substring(11), paciente, atendido, retorno, 0, Convert.ToString(usuarioDAO.getUsuario()));
        }

        private void calAgendamento_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void BuscarConsultasAgendadas()
        {
            var agendados = agendaDAO.CarregarAgenda();
            if (agendados is null || agendados.Count == 0)
                return;

            agendados.ForEach(x =>
            {
                CalendarItem calAgendamentos = new CalendarItem(calAgendamento, Convert.ToDateTime(x.data.ToString()), Convert.ToDateTime(x.data.ToString()).AddHours(1), x.paciente);
                calAgendamento.Items.Add(calAgendamentos);

                if (Convert.ToBoolean(x.retorno) && !Convert.ToBoolean(x.atendido) && !Convert.ToBoolean(x.Cancelado))
                    calAgendamentos.ApplyColor(Color.Cyan);

                if (!Convert.ToBoolean(x.retorno) && !Convert.ToBoolean(x.atendido) && Convert.ToBoolean(x.Cancelado))
                    calAgendamentos.ApplyColor(Color.Tomato);

                if (Convert.ToBoolean(x.atendido) && !Convert.ToBoolean(x.retorno))
                    calAgendamentos.ApplyColor(Color.LightGreen);

                if (!Convert.ToBoolean(x.atendido) && !Convert.ToBoolean(x.retorno) && !Convert.ToBoolean(x.Cancelado))
                    calAgendamentos.ApplyColor(Color.Yellow);

                jaIniciou = true;
            });
        }

        private void btnBuscarPacienteAgendamento_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAgenda.Text = PacienteModel.nomePacienteModel;
        }

        private void btnExcluirHoraAtend_Click(object sender, EventArgs e)
        {
            if (dtgConfigHorario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgConfigHorario.Rows)
                {
                    if (row.Selected)
                    {
                        FecharAbrirConexao();
                        configDAO.RemoverConfig(row.Cells["usuario"].Value.ToString(), row.Cells["diaSemana"].Value.ToString());
                        dtgConfigHorario.Rows.Remove(row);
                    }
                }
            }
        }

        private void mCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDataAgendamento.Text = mCalendar.SelectionStart.ToString("dd/MM/yyyy");
            try
            {
                calAgendamento.ViewEnd = Convert.ToDateTime(txtDataAgendamento.Text).AddDays(5);
                calAgendamento.ViewStart = mCalendar.SelectionStart;
            }
            catch (Exception ex)
            {
                calAgendamento.ViewStart = mCalendar.SelectionStart;
                calAgendamento.ViewEnd = Convert.ToDateTime(txtDataAgendamento.Text).AddDays(5);
            }

            BuscarConsultasAgendadas();
            GetConfigAtendimento();
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
                    nMensagemAlerta("Não foram encontrados itens para recalcular.");
                }
            quantidadeSalva = 0;
        }
        private void tbAlimento_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao("Alimento"))
            {
                return;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearCamposAntro();
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
                        //Refazer o cálculo, se for mudar a qtd, teria que ser, ex: 100g - 22g de prot, 50g - x g de prot
                        decimal ProteinaGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["prot"].Value)) / Conversions.ToDecimal(qtdSalva));
                        ProteinaKcal = ProteinaGramas * 4;
                        row.Cells["prot"].Value = Conversions.ToDecimal(ProteinaGramas);
                    }

                    if (row.Cells["carbo"].Value != null)
                    {
                        decimal CarboidratoGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["carbo"].Value)) / Conversions.ToDecimal(qtdSalva));
                        CarboidratoKcal = CarboidratoGramas * 4;
                        row.Cells["carbo"].Value = Conversions.ToDecimal(CarboidratoGramas);
                    }

                    if (row.Cells["lipidio"].Value != null)
                    {
                        decimal LipidioGramas = Conversions.ToDecimal((Conversions.ToDecimal(row.Cells["qtd"].Value) * Conversions.ToDecimal(row.Cells["lipidio"].Value)) / Conversions.ToDecimal(qtdSalva));
                        LipidioKcal = LipidioGramas * 9;
                        row.Cells["lipidio"].Value = LipidioGramas;
                    }

                    decimal somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal;
                    row.Cells["kcal"].Value = Conversions.ToDecimal(somaTotalCaloria);
                    if (dtg.Name != dtgConAlimento.Name)
                    lblValorKcal.Text = somaTotalCaloria.ToString("N2");
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
                nMensagemAlerta("Favor informar o nome da tabela que está sendo salvo.");
                return;
            }
            if (string.IsNullOrEmpty(txtCaminhoArquivoExcel.Text))
            {
                nMensagemAlerta("Favor informar o caminho do arquivo.");
                return;
            }
            if (string.IsNullOrEmpty(_cbxNomePlanilha.Text))
            {
                nMensagemAlerta("Favor informar a planilha a ser salva.");
                return;
            }
            var alimentoFail = string.Empty;
            bool salvou = false;

            loadStart(this);
            FecharAbrirConexao();

            using (TransactionScope tscope = new TransactionScope(TransactionScopeOption.Suppress))
            {
                try
                {
                    foreach (DataGridViewRow row in dtgDadosImportados.Rows)
                    {
                        string alimento = string.Empty;
                        double qtd = 0;
                        double kcal = 0;
                        double Prot = 0;
                        double Carb = 0;
                        double Lipidios = 0;
                        string tabela = string.Empty;

                        try
                        {
                            alimento = Convert.ToString(row.Cells["Alimento"].Value).Replace("\"", string.Empty);
                            qtd = Convert.ToDouble(row.Cells["qtd"].Value);
                            kcal = Math.Round(Convert.ToDouble(row.Cells["kcal"].Value), 2);
                            Prot = Math.Round(Convert.ToDouble(row.Cells["prot"].Value), 2);
                            Carb = Math.Round(Convert.ToDouble(row.Cells["carb"].Value), 2);
                            Lipidios = Math.Round(Convert.ToDouble(row.Cells["lip"].Value), 2);
                        }
                        catch
                        {
                            continue;
                        }

                        try
                        {
                            if (Convert.ToString(row.Cells["REF"].Value) != string.Empty)
                            {
                                tabela = Convert.ToString(row.Cells["REF"].Value);
                            }
                        }
                        catch
                        {
                            tabela = Convert.ToString(txtNomeTabela.Text);
                        }
                        try
                        {
                            if (!alimentoDAO.ExisteAlimento(alimento, tabela))
                            {
                                salvou = alimentoDAO.Salvar(alimento.Replace("'", string.Empty).Replace("\"", string.Empty), qtd, kcal, Prot, Carb, Lipidios, tabela);
                                alimentoFail = alimento;
                            }
                            else
                            {
                                salvou = alimentoDAO.Update(Convert.ToInt64(alimentoDAO.RetornaCodAlimentoExistente(alimento.Replace("'", string.Empty), tabela).ToString().Replace("\"", string.Empty)), alimento.Replace("'", string.Empty).Replace("\"", string.Empty), qtd, kcal, Prot, Carb, Lipidios, tabela);
                                alimentoFail = alimento;
                            }
                        }
                        catch
                        {
                            continue;
                        }

                    };
                }
                catch (Exception ex)
                {
                    loadStop(this);
                    nMensagemErro($"Ocorreu um erro, no alimento {alimentoFail}, favor verificar nomenclatura da mesma para não possuir caracteres especiais. Erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException + Environment.NewLine);
                    alimentoDAO.DeletarTableImportError(txtNomeTabela.Text);
                    return;
                }
                tscope.Complete();
            }
            dtgDadosImportados.DataSource = null;
            txtCaminhoArquivoExcel.Text = string.Empty;
            _cbxNomePlanilha.Items.Clear();
            txtNomeTabela.Text = string.Empty;
            loadStop(this);
            if (salvou)
                nMensagemAviso("Os dados foram Salvos");
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
            if (!VerificarPermissao(tabAlimento.Text))
            {
                return;
            };
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
            bool salvou = false;
            if (dtgConAlimento.Rows.Count == 0)
                return;
            FecharAbrirConexao();
            foreach (DataGridViewRow row in dtgConAlimento.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Tomato)
                {
                    salvou = alimentoDAO.Salvar(row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDouble(row.Cells["qtd"].Value), Convert.ToDouble(row.Cells["kcal"].Value)
                                   , Convert.ToDouble(row.Cells["prot"].Value), Convert.ToDouble(row.Cells["carbo"].Value), Convert.ToDouble(row.Cells["lipidio"].Value), cbxTabela.Text.ToString());
                }
                else if (row.DefaultCellStyle.BackColor == Color.LightSalmon)
                {
                    salvou = alimentoDAO.Update(Convert.ToInt64(row.Cells["codAlimento"].Value), row.Cells["nomeAlimento"].Value.ToString(), Convert.ToDouble(row.Cells["qtd"].Value, CultureInfo.InvariantCulture),
                        Convert.ToDouble(row.Cells["kcal"].Value, CultureInfo.InvariantCulture), Convert.ToDouble(row.Cells["prot"].Value, CultureInfo.InvariantCulture), Convert.ToDouble(row.Cells["carbo"].Value, CultureInfo.InvariantCulture)
                        , Convert.ToDouble(row.Cells["lipidio"].Value, CultureInfo.InvariantCulture), cbxTabela.Text.ToString());
                }
            }

            if (deletarAlimento != null || deletarAlimento.Count > 0)
                deletarAlimento.ForEach(x =>
                {
                    alimentoDAO.Deletar(Convert.ToDouble(x));
                });

            if (salvou)
            {
                nMensagemAviso("Seus dados foram salvos");
                foreach (DataGridViewRow row in dtgConAlimento.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        string nomeAlimentoAntigo = string.Empty;
        private void dtgConAlimento_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (Convert.ToString(dtgConAlimento.CurrentRow.Cells["qtd"].Value) != string.Empty)
                    quantidadeSalva = Convert.ToDecimal(dtgConAlimento.CurrentRow.Cells["qtd"].Value);

                if (Convert.ToString(dtgConAlimento.CurrentRow.Cells["kCal"].Value) != string.Empty)
                    kCalAntiga = Convert.ToDecimal(dtgConAlimento.CurrentRow.Cells["kCal"].Value);

                if (Convert.ToString(dtgConAlimento.CurrentRow.Cells["nomeAlimento"].Value) != string.Empty)
                    nomeAlimentoAntigo = Convert.ToString(dtgConAlimento.CurrentRow.Cells["nomeAlimento"].Value);
            }
        }
        private void dtgConAlimento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value != null)
                {
                    dtgConAlimento.CurrentRow.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value == null)
                {
                    dtgConAlimento.CurrentRow.DefaultCellStyle.BackColor = Color.Tomato;
                }
                nomeAlimentoAntigo = string.Empty;
                kCalAntiga = 0;
            }
        }

        private void _cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DataGridViewColumn> colunasDescartadas = new List<DataGridViewColumn>();
            var dt = tables[_cbxNomePlanilha.SelectedItem.ToString().Replace(",", ".")];
            dtgDadosImportados.DataSource = dt;
            foreach (DataGridViewColumn column in dtgDadosImportados.Columns)
            {
                bool existe = false;
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
                if (dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString() != string.Empty)
                    deletarAlimento.Add(dtgConAlimento.CurrentRow.Cells["codAlimento"].Value.ToString());
        }

        private void tbCadMedCaseira_Enter(object sender, EventArgs e)
        {
            mCbxTabelasMedCas.Items.Clear();
            dtgSalvarMedCaseira.Rows.Clear();
            List<Alimentos> tabela = new List<Alimentos>();
            tabela = (alimentoDAO.BuscarTabelas());
            if (tabela != null)
                tabela.ForEach(x =>
                {
                    if (!mCbxTabelasMedCas.Items.Contains(x.nomeTabela))
                        mCbxTabelasMedCas.Items.Add(x.nomeTabela);
                });

            var listaMedCaseira = medidaCaseiraDAO.Buscar(0, string.Empty);

            if (listaMedCaseira == null)
                return;

            foreach (MedidaCaseira medCaseira in listaMedCaseira)
                dtgSalvarMedCaseira.Rows.Add(medCaseira.codAlimento, medCaseira.Alimentos.nomeAlimento, medCaseira.descricao, medCaseira.qtd, medCaseira.Alimentos.nomeTabela);
        }

        private void dtgMedCaseiraAlimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            dtgSalvarMedCaseira.Rows.Add(dtgMedCaseiraAlimentos.CurrentRow.Cells["codAlimento"].Value, dtgMedCaseiraAlimentos.CurrentRow.Cells["nomeAlimento"].Value, string.Empty, string.Empty, dtgMedCaseiraAlimentos.CurrentRow.Cells["nomeTabela"].Value);

        }

        //private void btnAddMedCaseira_Click(object sender, EventArgs e)
        //{
        //    dtgSalvarMedCaseira.Rows.Add(txtCodAlimentoMedCas.Text,txtAlimentoMedCaseira.Text, txtDescMedCaseira.Text, txtQtdMedCas.Text);
        //    txtCodAlimentoMedCas.Text = string.Empty;
        //    txtAlimentoMedCaseira.Text = string.Empty;
        //    txtDescMedCaseira.Text = string.Empty;
        //    txtQtdMedCas.Text = string.Empty;
        //}

        private void btnSalvarMedCas_Click(object sender, EventArgs e)
        {
            string erro = string.Empty;

            if (dtgSalvarMedCaseira.Rows.Count == 0)
                return;

            medidaCaseiraDAO.Deletar();
            loadStart(this);
            FecharAbrirConexao();

            foreach (DataGridViewRow rows in dtgSalvarMedCaseira.Rows)
            {
                erro = medidaCaseiraDAO.Salvar(rows.Cells["colDescricao"].Value.ToString(), Convert.ToDouble(rows.Cells["colQtd"].Value), Convert.ToInt32(rows.Cells["colCodAlimento"].Value));
            }
            loadStop(this);
            if (!string.IsNullOrEmpty(erro))
            {
                nMensagemAviso("Seus dados foram Salvos!");
            }
            else
            {
                nMensagemErro(erro);
            }
        }

        private void _tbConsulta_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabAlimento.Text))
            {
                return;
            };
            tabAlimento_Enter(sender, e);
        }


        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmWait wait = new frmWait();
            //wait.Show();
            //dtgConAlimento.DataSource = null;
            //var listaAlimentos = alimentoDAO.Buscar(string.Empty, cbxTabela.Text);
            //if (listaAlimentos == null)
            //    return;
            //DataTable dt = ConvertToDataTable(listaAlimentos);
            //dtgConAlimento.DataSource = dt;
            //dtgConAlimento.Columns["codAlimento"].Visible = false;
            //dtgConAlimento.Columns["nomeAlimento"].HeaderText = "Alimento";
            //dtgConAlimento.Columns["nomeAlimento"].Width = 450;
            //dtgConAlimento.Columns["qtd"].HeaderText = "Qtde";
            //dtgConAlimento.Columns["prot"].HeaderText = "Proteína";
            //dtgConAlimento.Columns["carbo"].HeaderText = "Carboidrato";
            //dtgConAlimento.Columns["lipidio"].HeaderText = "Lipídio";
            //dtgConAlimento.Columns["nomeTabela"].Visible = false;
            //dtgConAlimento.Columns["MedidaCaseira"].Visible = false;
            //dtgConAlimento.Columns["Cardapio"].Visible = false;
            //wait.Hide();
            //return;

        }
        private void mCbxTabelasMedCas_SelectedValueChanged(object sender, EventArgs e)
        {
            dtgMedCaseiraAlimentos.DataSource = null;
            CarregarAlimentos(string.Empty, string.Empty, dtgMedCaseiraAlimentos);
            dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
        }
        private void CarregarAlimentos(string nomeAlimento, string nomeTabela, DataGridView dtg)
        {
            loadStart(this);
            listaAlimentos.Clear();
            listaAlimentos = alimentoDAO.Buscar(nomeAlimento, nomeTabela);
            if (listaAlimentos == null)
            {
                loadStop(this);
                return;
            }
            //DataTable dt = ConvertToDataTable(listaAlimentos);
            //dtg.DataSource = dt;

            if (dtg.Columns.Count == 0)
            {
                dtg.Columns.Add("codAlimento", "Código");
                dtg.Columns.Add("nomeAlimento", "Alimento");
                dtg.Columns.Add("qtd", "Quantidade");
                dtg.Columns.Add("kcal", "KCal");
                dtg.Columns.Add("prot", "Proteína");
                dtg.Columns.Add("carbo", "Carboidrato");
                dtg.Columns.Add("lipidio", "Lipídio");
                dtg.Columns.Add("nomeTabela", "Tabela");
                dtg.Columns["codAlimento"].Visible = false;
            }

            listaAlimentos.ForEach(x =>
            {
                dtg.Rows.Add(x.codAlimento, x.nomeAlimento, x.qtd, x.kcal, x.prot, x.carbo, x.lipidio, x.nomeTabela);
            });

            //dtg.Columns["codAlimento"].Visible = false;
            //dtg.Columns["qtd"].HeaderText = "Quantidade";
            //dtg.Columns["kcal"].HeaderText = "KCal";
            //dtg.Columns["prot"].HeaderText = "Proteína";
            //dtg.Columns["carbo"].HeaderText = "Carboidrato";
            //dtg.Columns["lipidio"].HeaderText = "Lipídio";
            //dtg.Columns["MedidaCaseira"].Visible = false;
            //dtg.Columns["Cardapio"].Visible = false;
            //dtg.Columns["nomeTabela"].HeaderText = "Tabela";
            //dtg.Columns["nomeAlimento"].HeaderText = "Alimento";

            dtg.AutoResizeColumns();
            loadStop(this);
        }

        private void mTxtFiltroAlimentoMedCas_Leave(object sender, EventArgs e)
        {
            if (mTxtFiltroAlimentoMedCas.Text != string.Empty)
            {
                dtgMedCaseiraAlimentos.Rows.Clear();
                FiltrarAlimentoTabela(mTxtFiltroAlimentoMedCas.Text, mCbxTabelasMedCas.Text, listaAlimentos, dtgMedCaseiraAlimentos);
                dtgMedCaseiraAlimentos.AutoResizeColumns();
                dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["tabela"].Visible = false;
                return;
            }
            else
            {
                mCbxTabelasMedCas_SelectedValueChanged(null, null);
            }
        }
        #endregion

        #region Paciente 
        private void tbPaciente_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabPaciente.Text))
            {
                return;
            };
        }
        private void limparCamposCadPaciente(string codPaciente)
        {
            if (!string.IsNullOrEmpty(codPaciente))
                foreach (DataGridViewRow row in _dtgConsultaPacientes.Rows)
                    if (Convert.ToInt64(row.Cells["codPaciente"].Value) == Convert.ToInt64(codPaciente))
                        _dtgConsultaPacientes.Rows.Remove(row);

            txtCodPaciente.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtDtNasc.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }
        private void _btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodPaciente.Text != "CodPaciente" || !string.IsNullOrEmpty(txtCodPaciente.Text))
            {
                FecharAbrirConexao();
                pacienteDAO.Deletar(Convert.ToDouble(txtCodPaciente.Text));
                limparCamposCadPaciente(txtCodPaciente.Text);
            }
            else
            {
                nMensagemAlerta("Não é possível excluir sem antes selecionar o usuário.");
            }
        }
        private void _dtgConsultaPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                loadStart(this);
                txtCodPaciente.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["codPaciente"].Value);
                txtNome.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["nome"].Value);
                txtCPF.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["CPF"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["CPF"].Value);
                txtDtNasc.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["dtNasc"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["dtNasc"].Value);
                txtEmail.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["email"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["email"].Value);
                txtCEP.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["CEP"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["CEP"].Value);
                txtNumero.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["numero"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["numero"].Value);
                txtComplemento.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["complemento"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["complemento"].Value);
                txtTelefone.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["telefone"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["telefone"].Value);
                txtCelular.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["celular"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["celular"].Value);
                txtBairro.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["bairro"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["bairro"].Value);
                txtMunicipio.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["municipio"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["municipio"].Value);
                txtEndereco.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["endereco"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["endereco"].Value);
                txtUF.Text = _dtgConsultaPacientes.Rows[e.RowIndex].Cells["UF"].Value == DBNull.Value ? string.Empty : Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["UF"].Value);
                if (Convert.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["imagem"].Value) != string.Empty)
                {
                    pbImagem.Image = ByteToImage((byte[])_dtgConsultaPacientes.Rows[e.RowIndex].Cells["imagem"].Value);
                }
                if (Convert.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["sexo"].Value).Contains("M"))
                {
                    rbMasculino.Checked = true;
                }
                else if (Convert.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells["sexo"].Value).Contains("F"))
                {
                    rbFeminino.Checked = true;
                }
                tbPaciente.SelectedTab = tbCadastro;
                FormatarCampos();
                loadStop(this);
            }
        }

        private void cbxDataExisteAntro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDataExisteAntro.Checked)
            {
                cbxDataAntrop.Visible = false;
                txtDataAntro.Visible = true;
            }
            else
            {
                if (cbxDataAntrop.Items.Count > 0)
                {
                    cbxDataAntrop.Visible = true;
                }
                else
                {
                    cbxDataAntrop.Visible = false;
                }
                txtDataAntro.Visible = false;
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
            if (txtCEP.Text != string.Empty)
            {
                buscaCEP.buscarEndCep(this, txtCEP.Text);
                try
                {
                    txtCEP.Text = Convert.ToUInt64(txtCEP.Text).ToString(@"00000\-000");
                }
                catch { }
            }
        }
        private void tbAnamnese_Enter(object sender, EventArgs e)
        {
            var templates = anamneseDAO.CarregarAnamneseConfig();

            if (templates is null || templates.Count == 0)
            {
                return;
            }
            cbxCarregarTemplate.Items.Clear();
            templates.ForEach(x =>
            {
                cbxCarregarTemplate.Items.Add(x.Template);
            });
        }

        private void cbxCarregarTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var templates = anamneseDAO.CarregarAnamneseTemplate(cbxCarregarTemplate.Text);

            if (templates is null || templates.Count == 0)
            {
                return;
            }

            templates.ForEach(x =>
            {
                rtxtAnamnese.Text = x.Texto;
            });
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbxCarregarTemplate.Text = string.Empty;
        }
        private void txtPacienteAnamnese_TextChanged(object sender, EventArgs e)
        {
            loadStart(this);
            var listaCardapio = anamneseDAO.CarregarDataAnamnese(Convert.ToInt32(PacienteModel.codPacienteModel));

            if (listaCardapio == null || listaCardapio.Count == 0)
            {
                cbxDataAnamnese.Visible = false;
                loadStop(this);
                return;
            }

            cbxDataAnamnese.Visible = true;

            listaCardapio.ForEach(x =>
            {
                cbxDataAnamnese.Items.Add(x);
            });
            loadStop(this);
        }

        private void cbxDataAnamnese_SelectedIndexChanged(object sender, EventArgs e)
        {
            var anamnese = anamneseDAO.CarregarAnamnese(cbxDataAnamnese.Text);

            if (anamnese == null || anamnese.Count <= 0)
            {
                return;
            }

            anamnese.ForEach(x =>
            {

                rtxtAnamnese.Text = x.descAnamnese;

            });
        }

        private void _btnSalvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                nMensagemAviso("Necessário informar um nome!");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                nMensagemAviso("Necessário informar o sexo!");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                nMensagemAviso("Necessário informar a data de nascimento!");
                return;
            }

            loadStart(this);
            FecharAbrirConexao();

            string CPF = txtCPF.Text.Replace("-", string.Empty).Replace(".", string.Empty);
            string CEP = txtCEP.Text.Replace("-", string.Empty);
            string sexo = string.Empty;


            if (txtCodPaciente.Text != "CodPaciente")
                paciente.codPaciente = Convert.ToInt64(txtCodPaciente.Text);
            if (txtNome.Text != "")
                paciente.nome = txtNome.Text;
            if (CPF != "")
                paciente.CPF = Convert.ToInt64(CPF);
            if (txtDtNasc.Text != "")
                paciente.dtNasc = txtDtNasc.Text;
            if (txtEmail.Text != "")
                paciente.email = txtEmail.Text;
            if (CEP != "")
                paciente.CEP = Convert.ToDouble(CEP);
            if (txtNumero.Text != "")
                paciente.numero = Convert.ToInt64(txtNumero.Text);
            if (txtTelefone.Text != "")
                paciente.telefone = txtTelefone.Text;
            if (txtCelular.Text != "")
                paciente.celular = txtCelular.Text;
            if (txtEndereco.Text != "")
                paciente.endereco = txtEndereco.Text;
            if (txtBairro.Text != "")
                paciente.bairro = txtBairro.Text;
            if (txtMunicipio.Text != "")
                paciente.municipio = txtMunicipio.Text;
            if (txtUF.Text != "")
                paciente.UF = txtUF.Text;
            if (txtComplemento.Text != "")
                paciente.complemento = txtComplemento.Text;

            if (rbMasculino.Checked)
            {
                sexo = "M";
            }
            else if (rbFeminino.Checked)
            {
                sexo = "F";
            }

            if (!string.IsNullOrEmpty(sexo))
                paciente.sexo = sexo;
            else
            {
                loadStop(this);
                nMensagemAviso("É necessário informar o sexo do paciente!");
                return;
            }

            listaPacientes.Clear();

            pacienteDAO.Salvar(paciente, this.vetorImagens);

            tLoad = new Thread(PreCarregarPacientes);
            tLoad.Start();

            limparCamposCadPaciente(txtCodPaciente.Text);
            loadStop(this);
            tbCadastro_Enter(sender, e);
        }

        private void tbCadastro_Enter(object sender, EventArgs e)
        {
            loadStart(this);

            btnCapturarImagem.Visible = false;
            _dtgConsultaPacientes.DataSource = null;
            var listaPacientes = pacienteDAO.Buscar(string.Empty);

            if (listaPacientes == null)
            {
                loadStop(this);
                return;
            }

            DataTable dt = ConvertToDataTable(listaPacientes);
            _dtgConsultaPacientes.DataSource = dt;

            _dtgConsultaPacientes.Columns["codPaciente"].Visible = false;
            _dtgConsultaPacientes.Columns["imagem"].Visible = false;
            _dtgConsultaPacientes.Columns["Cardapio"].Visible = false;
            _dtgConsultaPacientes.Columns["AnamnesePaciente"].Visible = false;
            _dtgConsultaPacientes.Columns["Antropometria"].Visible = false;
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
            _dtgConsultaPacientes.AutoResizeColumns();

            loadStop(this);
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

        private void btnConfigAnamnese_Click(object sender, EventArgs e)
        {
            using (frmTemplatesAnamnese frm = new frmTemplatesAnamnese())
            {
                frm.ShowDialog();
            }
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

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            double altura = 0;
            if (!txtAltura.Text.Contains(",") && !txtAltura.Text.Contains("."))
            {
                altura = Convert.ToDouble(txtAltura.Text.Substring(0, 1) + ',' + txtAltura.Text.Substring(1, txtAltura.Text.Length - 1));
                txtAltura.Text = altura.ToString();
            }
            if (!String.IsNullOrEmpty(txtPeso.Text) && altura != 0 || !String.IsNullOrEmpty(txtPeso.Text) && !String.IsNullOrEmpty(txtAltura.Text))
            {
                lblIMC.Text = CalcularIMC(Convert.ToDouble(txtPeso.Text.Replace(".", ",")), Convert.ToDouble(txtAltura.Text.Replace(".", ",")));
            }
        }


        private double CalcularHarrisBenedict(Antropometria antropometria)
        {
            if (antropometria is null)
                return 0;

            if (antropometria.Paciente.sexo.Equals("M"))
            {
                return Math.Round(Convert.ToDouble(66 + (13.8 * antropometria.peso) + (5 * antropometria.peso) + (6.8 * calcularIdade(antropometria.Paciente.dtNasc))), 2);
            }
            else if (antropometria.Paciente.sexo.Equals("F"))
            {
                return Math.Round(Convert.ToDouble(655 + (9.6 * antropometria.peso) + (1.9 * antropometria.peso) + (4.7 * calcularIdade(antropometria.Paciente.dtNasc))), 2);
            }
            return 0;
        }

        private double CalcularHarrisPraVET(Antropometria antropometria)
        {
            if (antropometria is null)
                return 0;

            double fatorAtividade = 0;

            if (!Convert.ToBoolean(antropometria.temGrauAtividade))
            {
                return 0;
            }

            if (antropometria.grauAtividade.ToLower().Contains("sedent"))
            {
                fatorAtividade = 1.2;
            }
            else if (antropometria.grauAtividade.ToLower().Contains("leve"))
            {
                fatorAtividade = 1.375;
            }
            else if (antropometria.grauAtividade.ToLower().Contains("moderado"))
            {
                fatorAtividade = 1.55;
            }
            else if (antropometria.grauAtividade.ToString().ToLower() == "pesado")
            {
                fatorAtividade = 1.725;
            }
            else if (antropometria.grauAtividade.ToLower().Contains("muito pesado"))
            {
                fatorAtividade = 1.9;
            }

            return CalcularHarrisBenedict(antropometria) * fatorAtividade;
        }
        private double CalculaFAOOMS(Antropometria antropometria)
        {
            if (antropometria is null)
                return 0;

            // FAO/OMS - Já retorna o VET direto
            int idade = calcularIdade(antropometria.Paciente.dtNasc);

            if (antropometria.Paciente.sexo.Equals("M"))
            {
                if (idade >= 10 && idade < 18)
                {
                    return Math.Round((double)((17.686 * antropometria.peso) + 658.2), 2);
                }
                else if (idade >= 18 && idade < 30)
                {
                    return Math.Round((double)((15.057 * antropometria.peso) + 692.2), 2);
                }
                else if (idade >= 30 && idade < 60)
                {
                    return Math.Round((double)((11.472 * antropometria.peso) + 873.1), 2);
                }
                else if (idade >= 60)
                {
                    return Math.Round((double)((11.711 * antropometria.peso) + 587.7), 2);
                }
            }
            else if (antropometria.Paciente.sexo.Equals("F"))
            {
                if (idade >= 10 && idade < 18)
                {
                    return Math.Round((double)((13.384 * antropometria.peso) + 692.6), 2);
                }
                else if (idade >= 18 && idade < 30)
                {
                    return Math.Round((double)((14.818 * antropometria.peso) + 486.6), 2);
                }
                else if (idade >= 30 && idade < 60)
                {
                    return Math.Round((double)((8.126 * antropometria.peso) + 845.6), 2);
                }
                else if (idade >= 60)
                {
                    return Math.Round((double)((9.082 * antropometria.peso) + 658.5), 2);
                }
            }
            return 0;
        }
        private double CalcularDRI(Antropometria antropometria)
        {
            if (antropometria is null)
                return 0;

            // Retorna VET
            int idade = calcularIdade(antropometria.Paciente.dtNasc);
            double CAF = 0;
            string IMC = CalcularIMC(Convert.ToDouble(antropometria.peso), Convert.ToDouble(antropometria.altura));

            if (!Convert.ToBoolean(antropometria.temCoefAtividade))
            {
                return 0;
            }

            if (antropometria.coefAtividade.ToLower().Contains("sedentário"))
            {
                CAF = 1;
            }
            else if (antropometria.coefAtividade.ToLower().Contains("pouco ativo"))
            {
                CAF = 1.1;
            }
            else if (antropometria.coefAtividade.ToLower().Contains("ativo"))
            {
                CAF = 1.25;
            }
            else if (antropometria.coefAtividade.ToLower().Contains("muito ativo"))
            {
                CAF = 1.48;
            }

            if (IMC.Contains("Sobrepeso") || IMC.Contains("Obesidade"))
            {
                if (antropometria.Paciente.sexo.Equals("M"))
                {
                    return Math.Round((double)(1086 - (10.4 * idade) + CAF * (13.7 * antropometria.peso + 416 * (antropometria.altura / 100))), 2);
                }
                else if (antropometria.Paciente.sexo.Equals("F"))
                {
                    return Math.Round((double)(448 - (7.95 * idade) + CAF * (11.4 * antropometria.peso + 619 * (antropometria.altura / 100))), 2);
                }
            }
            else
            {
                if (antropometria.Paciente.sexo.Equals("M"))
                {
                    return Math.Round((double)(662 - (9.53 * idade) + CAF * (15.91 * antropometria.peso + 539.6 * (antropometria.altura / 100))), 2);
                }
                else if (antropometria.Paciente.sexo.Equals("F"))
                {
                    return Math.Round((double)(354 - (6.91 * idade) + CAF * (9.36 * antropometria.peso + 416 * (antropometria.altura / 100))), 2);
                }
            }


            return 0;
        }
        private void btnClearAntro_Click(object sender, EventArgs e)
        {
            ClearCamposAntro();
        }
        private void txtPacienteAntro_TextChanged(object sender, EventArgs e)
        {
            var listDates = antropometriaDAO.BuscarData(Convert.ToInt32(PacienteModel.codPacienteModel));

            if (listDates is null)
            {
                if (cbxDataAntrop.Visible)
                {
                    cbxDataAntrop.Visible = false;
                }
                return;
            }

            cbxDataAntrop.Items.Clear();

            listDates.ForEach(x =>
            {
                cbxDataAntrop.Items.Add(x.ToString("dd/MM/yyyy"));
            });

            cbxDataAntrop.Visible = true;
            cbxDataExisteAntro.Checked = false;
        }

        private void cbxDataAntrop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDataAntrop.Text))
                return;

            var listAntro = antropometriaDAO.CarregarInfos(Convert.ToInt32(PacienteModel.codPacienteModel), Convert.ToDateTime(cbxDataAntrop.Text));

            if (listAntro is null || listAntro.Count == 0)
                return;

            listAntro.ForEach(x =>
            {
                txtPeso.Text = x.peso.ToString();
                txtAltura.Text = x.altura.ToString();
                txtAntebraco.Text = x.antebraco.ToString();
                txtBraco.Text = x.braco.ToString();
                txtCintura.Text = x.cintura.ToString();
                txtCoxa.Text = x.coxa.ToString();
                txtPanturrilha.Text = x.panturrilha.ToString();
                txtPeso.Text = x.peso.ToString();
                txtQuadril.Text = x.quadril.ToString();
                txtTorax.Text = x.torax.ToString();
                txtPunho.Text = x.punho.ToString();
                txtPescoco.Text = x.pescoco.ToString();
                txtAbdome.Text = x.abdome.ToString();
                if (Convert.ToBoolean(x.temGrauAtividade))
                {
                    if (x.grauAtividade == rbCAFSedentario.Text)
                    {
                        rbCAFSedentario.Checked = true;
                    }
                    else if (x.grauAtividade == rbCAFLeve.Text)
                    {
                        rbCAFLeve.Checked = true;
                    }
                    else if (x.grauAtividade == rbCAFModerado.Text)
                    {
                        rbCAFModerado.Checked = true;
                    }
                    else if (x.grauAtividade == rbCAFPesado.Text)
                    {
                        rbCAFPesado.Checked = true;
                    }
                    else if (x.grauAtividade == rbCAFMuitoPesado.Text)
                    {
                        rbCAFMuitoPesado.Checked = true;
                    }
                }
                if (Convert.ToBoolean(x.temCoefAtividade))
                {
                    if (x.grauAtividade == rbDRISedentario.Text)
                    {
                        rbDRISedentario.Checked = true;
                    }
                    else if (x.grauAtividade == rbDRIPoucoAtivo.Text)
                    {
                        rbDRIPoucoAtivo.Checked = true;
                    }
                    else if (x.grauAtividade == rbDRIAtivo.Text)
                    {
                        rbDRIAtivo.Checked = true;
                    }
                    else if (x.grauAtividade == rbDRIMuitoAtivo.Text)
                    {
                        rbDRIMuitoAtivo.Checked = true;
                    }
                }
                lblIMC.Text = CalcularIMC(Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtAltura.Text));
            });

        }

        private void txtDataAntro_Leave(object sender, EventArgs e)
        {
            if (txtDataAntro.Text == string.Empty)
            {
                txtDataAntro.Text = FormatDate(DateTime.Now.ToString("dd/MM/yyyy"));
            }
            else
            {
                txtDataAntro.Text = FormatDate(txtDataAntro.Text);
            }
        }
        private void btnFindPacienteAnamnese_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAnamnese.Text = PacienteModel.nomePacienteModel;
        }
        private void txtUF_Leave(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void btnPacAnt_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAntro.Text = PacienteModel.nomePacienteModel;
        }

        private void btnSalvarAnamnese_Click(object sender, EventArgs e)
        {
            loadStart(this);
            FecharAbrirConexao();
            string erro = anamneseDAO.Salvar(Convert.ToInt32(PacienteModel.codPacienteModel), Convert.ToString(rtxtAnamnese.Text));
            loadStop(this);
            if (string.IsNullOrEmpty(erro))
            {
                nMensagemAlerta(erro);
                return;
            }
            txtPaciente.Text = string.Empty;
            cbxDataAnamnese.Items.Clear();
            cbxCarregarTemplate.Items.Clear();
        }

        private void txtDtNasc_Leave(object sender, EventArgs e)
        {
            txtDtNasc.Text = FormatDate(txtDtNasc.Text);
        }

        private void btnSalvarAntro_Click(object sender, EventArgs e)
        {

            bool existeGaDRI = false;
            string grauAtividadeDRI = string.Empty;
            bool existeCAF = false;
            string coeficienteAtividade = string.Empty;

            Antropometria antro = new Antropometria();

            if (rbDRISedentario.Checked)
            {
                grauAtividadeDRI = rbDRISedentario.Text;
                existeGaDRI = true;
            }
            else if (rbDRIPoucoAtivo.Checked)
            {
                grauAtividadeDRI = rbDRIPoucoAtivo.Text;
                existeGaDRI = true;
            }
            else if (rbDRIAtivo.Checked)
            {
                grauAtividadeDRI = rbDRIAtivo.Text;
                existeGaDRI = true;
            }
            else if (rbDRIMuitoAtivo.Checked)
            {
                grauAtividadeDRI = rbDRIMuitoAtivo.Text;
                existeGaDRI = true;
            }

            if (rbCAFSedentario.Checked)
            {
                coeficienteAtividade = rbCAFSedentario.Text;
                existeCAF = true;
            }
            else if (rbCAFLeve.Checked)
            {
                coeficienteAtividade = rbCAFLeve.Text;
                existeCAF = true;
            }
            else if (rbCAFModerado.Checked)
            {
                coeficienteAtividade = rbCAFModerado.Text;
                existeCAF = true;
            }
            else if (rbCAFPesado.Checked)
            {
                coeficienteAtividade = rbCAFPesado.Text;
                existeCAF = true;
            }
            else if (rbCAFMuitoPesado.Checked)
            {
                coeficienteAtividade = rbCAFMuitoPesado.Text;
                existeCAF = true;
            }

            if (Convert.ToInt32(PacienteModel.codPacienteModel) == 0)
            {
                nMensagemAlerta("É necessário informar o paciente!");
                return;
            }

            if (string.IsNullOrEmpty(grauAtividadeDRI))
            {
                nMensagemAlerta("É necessário informar o grau de atividade!");
                return;
            }

            string data = string.Empty;
            if (!string.IsNullOrWhiteSpace(PacienteModel.codPacienteModel))
                antro.codPaciente = Convert.ToInt32(PacienteModel.codPacienteModel);
            if (!string.IsNullOrWhiteSpace(txtAltura.Text))
                antro.altura = Convert.ToDouble(txtAltura.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtAntebraco.Text))
                antro.antebraco = Convert.ToDouble(txtAntebraco.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtBraco.Text))
                antro.braco = Convert.ToDouble(txtBraco.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtCintura.Text))
                antro.cintura = Convert.ToDouble(txtCintura.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtCoxa.Text))
                antro.coxa = Convert.ToDouble(txtCoxa.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtPanturrilha.Text))
                antro.panturrilha = Convert.ToDouble(txtPanturrilha.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtPeso.Text))
                antro.peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtPunho.Text))
                antro.punho = Convert.ToDouble(txtPunho.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtQuadril.Text))
                antro.quadril = Convert.ToDouble(txtQuadril.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtPescoco.Text))
                antro.pescoco = Convert.ToDouble(txtPescoco.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtAbdome.Text))
                antro.abdome = Convert.ToDouble(txtAbdome.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(txtTorax.Text))
                antro.torax = Convert.ToDouble(txtTorax.Text.Replace(".", ","));
            if (!string.IsNullOrWhiteSpace(grauAtividadeDRI))
                antro.grauAtividade = grauAtividadeDRI;
            if (existeGaDRI)
                antro.temGrauAtividade = Convert.ToInt32(existeGaDRI);
            if (existeCAF)
                antro.temCoefAtividade = Convert.ToInt32(existeCAF);
            if (!string.IsNullOrEmpty(coeficienteAtividade))
                antro.coefAtividade = coeficienteAtividade;

            if (cbxDataAntrop.Visible && !string.IsNullOrEmpty(cbxDataAntrop.Text))
            {
                antro.Data = Convert.ToDateTime(cbxDataAntrop.Text);
            }
            else if (!string.IsNullOrEmpty(txtDataAntro.Text))
            {
                antro.Data = Convert.ToDateTime(txtDataAntro.Text);
            }
            else
            {
                antro.Data = DateTime.Now;
            }
            loadStart(this);
            FecharAbrirConexao();
            antropometriaDAO.Salvar(antro);
            ClearCamposAntro();
            loadStop(this);
        }

        private void ClearCamposAntro()
        {
            txtPacienteAntro.Text = string.Empty;
            txtDataAntro.Text = string.Empty;
            cbxDataAntrop.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;
            lblIMC.Text = string.Empty;
            txtBraco.Text = string.Empty;
            txtPunho.Text = string.Empty;
            txtCintura.Text = string.Empty;
            txtTorax.Text = string.Empty;
            txtCintura.Text = string.Empty;
            txtTorax.Text = string.Empty;
            txtQuadril.Text = string.Empty;
            txtPanturrilha.Text = string.Empty;
            txtAntebraco.Text = string.Empty;
            txtCoxa.Text = string.Empty;
            txtPescoco.Text = string.Empty;
            txtAbdome.Text = string.Empty;
            cbxDataExisteAntro.Checked = false;
            lblIMC.Text = string.Empty;
        }

        private void BuscadorPaciente()
        {

            if (listaPacientes.Count == 0)
            {
                PreCarregarPacientes();
            }

            using (frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this, listaPacientes))
            {
                buscaPacientes.ShowDialog();
            }
            if (!string.IsNullOrEmpty(PacienteModel.codPacienteModel))
                SetarNome(PacienteModel.nomePacienteModel);
        }

        private void SetarNome(string nome)
        {
            txtPaciente.Text = nome;
            txtPacienteAgenda.Text = nome;
            txtPacienteAnamnese.Text = nome;
            txtPacienteAnamnese_TextChanged(null, null);
            txtPacienteAntro.Text = nome;
            txtPacienteAntro_TextChanged(null, null);
            txtPacienteConsultaCardapio.Text = nome;
            txtPacienteConsultaCardapio_TextChanged(null, null);
            txtNome.Text = nome;
        }

        private void dtgRefeicoes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            double kcalTotal = 0;
            if (dtgRefeicoes.Rows[e.Row.Index + 1].DefaultCellStyle.BackColor == Color.LightSalmon)
            {
                foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                {
                    kcalTotal += Convert.ToDouble(row.Cells[kcal.Index].Value);
                    CarregarGrafico(Convert.ToDouble(row.Cells[prot.Index].Value)
                        , Convert.ToDouble(row.Cells[carbo.Index].Value)
                        , Convert.ToDouble(row.Cells[lipidio.Index].Value));
                }
                lblValorKcal.Text = kcalTotal.ToString("N2");
                return;
            }
            string data = string.Empty;

            if (!string.IsNullOrEmpty(txtDataCardapio.Text))
            {
                data = txtDataCardapio.Text;
            }
            else if (!string.IsNullOrEmpty(cbxDataCardSalvo.Text))
            {
                data = cbxDataCardSalvo.Text;
            }

            cardapioDAO.RemoverComidaCardapio(cbxRefeicao.Text, data, Convert.ToInt32(dtgRefeicoes.Rows[e.Row.Index + 1].Cells["codAlimento"].Value));
            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
            {
                kcalTotal += Convert.ToDouble(row.Cells[kcal.Index].Value);
                CarregarGrafico(Convert.ToDouble(row.Cells[prot.Index].Value)
                    , Convert.ToDouble(row.Cells[carbo.Index].Value)
                    , Convert.ToDouble(row.Cells[lipidio.Index].Value));
            }
            lblValorKcal.Text = kcalTotal.ToString("N2");
        }
        #endregion

        #region Cardápio
        private void tbCardapio_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabCardapio.Text))
            {
                return;
            };
        }
        private void btnConsultarCardapio_Click(object sender, EventArgs e)
        {
            CarregaCardapio();
        }


        private void chkDataExisteCardapio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDataExisteCardapio.Checked)
            {
                cbxDataCardSalvo.Visible = false;
                txtDataCardapio.Visible = true;
            }
            else
            {
                if (cbxDataCardSalvo.Items.Count > 0)
                {
                    cbxDataCardSalvo.Visible = true;
                }
                else
                {
                    cbxDataCardSalvo.Visible = false;
                }
                txtDataCardapio.Visible = false;
            }
        }

        private void dtgRefeicoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cbxDataCardSalvo_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarAlimentosCardapioConfig();
        }
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
        private void btnApagarCardapio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDataConsulta.Text))
            {
                nMensagemAviso("Informar a data do cardápio a ser deletado", this);
                return;
            }
            if (!String.IsNullOrEmpty(txtPacienteConsultaCardapio.Text))
            {
                cardapioDAO.Deletar(cbxDataConsulta.Text);
                trwDadosCard.Nodes.Clear();
                trwDadosCard.Columns.Clear();
                trwDadosCard.Refresh();
                txtPacienteConsultaCardapio_TextChanged(sender, e);
            }
        }
        private void btnAddAliCard_Click(object sender, EventArgs e)
        {
            if (cbxRefeicao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar a refeição.");
                return;
            }

            double kcalTotal = 0;
            double proteina = 0;
            double carboidrato = 0;
            double lipidio = 0;
            List<DataGridViewRow> linhaAdicionada = new List<DataGridViewRow>();

            if (dtgCardapioAlimentos.SelectedRows.Count >= 1 || dtgCardapioAlimentos.SelectedCells.Count >= 1)
            {
                foreach (DataGridViewRow row in dtgCardapioAlimentos.Rows)
                {
                    int linha = 0;
                    if (row.Selected == true || row.Cells["nomeAlimento"].Selected)
                    {
                        linha = dtgRefeicoes.Rows.Add(row.Cells["codAlimento"].Value
                             , row.Cells["nomeAlimento"].Value
                             , 100
                             , row.Cells["kcal"].Value
                             , row.Cells["prot"].Value
                             , row.Cells["carbo"].Value
                             , row.Cells["lipidio"].Value
                             , string.Empty
                             , cbxRefeicao.Text);
                        linhaAdicionada.Add(dtgRefeicoes.Rows[linha]);
                        dtgRefeicoes.Rows[linha].Visible = false;
                        dtgRefeicoes.Rows[linha].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }      
                }

                foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                {
                    kcalTotal += Math.Round(Convert.ToDouble(row.Cells[kcal.Index].Value), 2);
                    proteina += Math.Round(Convert.ToDouble(row.Cells["prot"].Value), 2);
                    carboidrato += Math.Round(Convert.ToDouble(row.Cells["carbo"].Value), 2);
                    lipidio += Math.Round(Convert.ToDouble(row.Cells["lipidio"].Value), 2);
                }

                    if (linhaAdicionada != null || linhaAdicionada.Count > 0)
                    foreach (var linhaIndex in linhaAdicionada)
                    {
                        if (!string.IsNullOrEmpty(txtProteina.Text) && Convert.ToDouble(proteina) > Convert.ToDouble(txtProteina.Text))
                        {
                            nMensagemAlerta("A proteína atingiu o limite configurado!");
                            dtgRefeicoes.Rows.Remove(linhaIndex);
                            return;
                        }
                        else if (!string.IsNullOrEmpty(txtCarboidrato.Text) && Convert.ToDouble(carboidrato) > Convert.ToDouble(txtCarboidrato.Text))
                        {
                            nMensagemAlerta("O carboidrato atingiu o limite configurado!");
                            dtgRefeicoes.Rows.Remove(linhaIndex);
                            return;
                        }
                        else if (!string.IsNullOrEmpty(txtLipidio.Text) && Convert.ToDouble(lipidio) > Convert.ToDouble(txtLipidio.Text))
                        {
                            nMensagemAlerta("O lipídio atingiu o limite configurado!");
                            dtgRefeicoes.Rows.Remove(linhaIndex);
                            return;
                        }
                        dtgRefeicoes.Rows[linhaIndex.Index].Visible = true;
                    }
                dtgRefeicoes.Visible = true;

                foreach (DataGridViewRow row in linhaAdicionada)
                {
                    var medCaseiraItens = medidaCaseiraDAO.Buscar(Convert.ToInt32(row.Cells["codAlimento"].Value), string.Empty);

                    if (medCaseiraItens is null)
                        continue;

                    foreach (var medidaCaseira in medCaseiraItens)
                    {
                        if (Convert.ToDouble(row.Cells["codAlimento"].Value) == Convert.ToDouble(medidaCaseira.codAlimento))
                        {
                            DataGridViewComboBoxCell comboCell = dtgRefeicoes.Rows[row.Index].Cells[cbxMedCaseira.Index] as DataGridViewComboBoxCell;

                            comboCell.Items.Add(medidaCaseira.descricao);
                            row.Cells["cbxMedCaseira"].Value = medidaCaseira.descricao;
                            row.Cells["qtd"].Value = medidaCaseira.qtd;
                        }
                    }

                }
            }
            lblVlrKcal.Visible = true;
            lblValorKcal.Text = kcalTotal.ToString("N2");
            if (dtgRefeicoes.Rows.Count > 0)
            {
                CarregarGrafico(proteina, carboidrato, lipidio);
            }
            dtgRefeicoes.AutoResizeColumns();
        }

        private void btnEnviarCardEmail_Click(object sender, EventArgs e)
        {
            loadStart(this);
            var emailPaciente = pacienteDAO.GetEmail(Convert.ToInt32(PacienteModel.codPacienteModel));
            string para = string.Empty;

            emailPaciente.ForEach(x =>
            {
                para = x.email;
            });

            if (string.IsNullOrEmpty(para))
            {
                nMensagemAviso("Não é possível enviar o e-mail, pois o paciente não possuí e-mail cadastrado.");
                return;
            }

            string dataConsultaCardapio = string.Empty;
            string corpoEmail = string.Empty;
            string refeAnte = string.Empty;

            corpoEmail = $@"<h1>Cardápio referente à consulta data {dataConsultaCardapio}</h1>" + Environment.NewLine;

            corpoEmail += $@"<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>" + Environment.NewLine;
            corpoEmail += $@"<th style='background-color: #33FFAC;border: 1px solid #ccc;width: 200px'> Refeição </th>" + Environment.NewLine;
            corpoEmail += $@"<th style='background-color: #33FFAC;border: 1px solid #ccc;width: 200px'> Alimento </th>" + Environment.NewLine;
            corpoEmail += $@"<th style='background-color: #33FFAC;border: 1px solid #ccc;width: 200px'> Quantidade </th>" + Environment.NewLine;
            corpoEmail += $@"<th style='background-color: #33FFAC;border: 1px solid #ccc;width: 200px'> Observação </th>" + Environment.NewLine;

            foreach (DataGridViewRow row in dtgCardGrid.Rows)
            {
                corpoEmail += $@"<tr>" + Environment.NewLine;
                if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Café da manhã")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                        Convert.ToString(row.Cells[alimento.Index].Value),
                        Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                        Convert.ToString(row.Cells[observ.Index].Value),
                        refeAnte);
                }
                else if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Lanche")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                       Convert.ToString(row.Cells[alimento.Index].Value),
                       Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                       Convert.ToString(row.Cells[observ.Index].Value),
                       refeAnte);
                }
                else if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Almoço")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                        Convert.ToString(row.Cells[alimento.Index].Value),
                        Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                        Convert.ToString(row.Cells[observ.Index].Value),
                        refeAnte);
                }
                else if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Lanche da tarde")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                        Convert.ToString(row.Cells[alimento.Index].Value),
                        Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                        Convert.ToString(row.Cells[observ.Index].Value),
                        refeAnte);
                }
                else if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Jantar")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                        Convert.ToString(row.Cells[alimento.Index].Value),
                        Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                        Convert.ToString(row.Cells[observ.Index].Value),
                        refeAnte);
                }
                else if (Convert.ToString(row.Cells[refeicao.Index].Value) == "Ceia")
                {
                    corpoEmail = PreencherCorpoEmail(corpoEmail, Convert.ToString(row.Cells[refeicao.Index].Value),
                        Convert.ToString(row.Cells[alimento.Index].Value),
                        Convert.ToString(row.Cells[medidacaseiraqtd.Index].Value),
                        Convert.ToString(row.Cells[observ.Index].Value),
                        refeAnte);
                }
                refeAnte = Convert.ToString(row.Cells[refeicao.Index].Value);
                corpoEmail += $@"</tr>" + Environment.NewLine;
            }
            corpoEmail += $@"</table>" + Environment.NewLine;

            string erro = SenderMail(para, "nutriez.suporte@gmail.com", "Cardápio", corpoEmail.Replace("'", "\""));

            if (!string.IsNullOrEmpty(erro))
            {
                loadStop(this);
                nMensagemErro(erro);
            }

            loadStop(this);
        }
        private void txtPacienteConsultaCardapio_TextChanged(object sender, EventArgs e)
        {
            if (PacienteModel.codPacienteModel == string.Empty)
                return;
            CarregarDatasCardapio(cbxDataConsulta);

        }

        private void CarregarDatasCardapio(ComboBox cbx)
        {
            var listaCardapio = cardapioDAO.ConsultarDataConsultas(Convert.ToInt32(PacienteModel.codPacienteModel));

            if (listaCardapio == null)
            {
                cbx.Visible = false;
                return;
            }
            else if (listaCardapio.Count == 0)
            {
                cbx.Visible = false;
                return;
            }
            cbx.Visible = true;
            cbx.Items.Clear();

            listaCardapio.ForEach(x =>
            {
                cbx.Items.Add(x);
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

        private void btnSalvarCardapio_Click(object sender, EventArgs e)
        {
            //double Kcal = Convert.ToDouble(lblValorKcal.Text.Split(' ')[0]);
            if (Convert.ToInt32(PacienteModel.codPacienteModel) == 0)
            {
                nMensagemAlerta("Selecione um paciente para atrelar o cardápio");
                return;
            }
            string erro = string.Empty;
            loadStart(this);
            FecharAbrirConexao();
            string data = string.Empty;

            if (cbxDataCardSalvo.Visible)
            {
                data = cbxDataCardSalvo.Text;
            }
            else
            {
                data = txtDataCardapio.Text;
            }

            if (string.IsNullOrEmpty(data))
                data = DateTime.Today.ToString("dd/MM/yyyy");

            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                erro = cardapioDAO.Salvar(Convert.ToInt32(PacienteModel.codPacienteModel),
                                                 Convert.ToInt32(row.Cells["codAlimento"].Value),
                                                 Convert.ToString(row.Cells["colRefeicaoCard"].Value),
                                                 Convert.ToInt32(row.Cells["qtd"].Value),
                                                 Convert.ToDouble(row.Cells["kcal"].Value),
                                                 Convert.ToString(usuarioDAO.getUsuario()),
                                                 data,
                                                 Convert.ToString(row.Cells["obs"].Value));

            if (string.IsNullOrEmpty(erro))
            {
                btnApagar_Click(sender, e);
                btnCancelarCardapio_Click(sender, e);
                loadStop(this);
                nMensagemAviso("Seus dados foram salvos!");
            }
            else
            {
                loadStop(this);
                nMensagemErro(erro);
            }
        }

        private void btnPacienteCardapio_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPaciente.Text = PacienteModel.nomePacienteModel;
        }

        private void txtFiltroAlimento_Leave(object sender, EventArgs e)
        {
            loadStart(this);
            if (dtgCardapioAlimentos.Columns.Count == 0)
            {
                dtgCardapioAlimentos.Columns.Add("codAlimento", "Código");
                dtgCardapioAlimentos.Columns.Add("nomeAlimento", "Alimento");
                dtgCardapioAlimentos.Columns.Add("kcal", "KCal");
                dtgCardapioAlimentos.Columns.Add("qtd", "Qtd");
                dtgCardapioAlimentos.Columns.Add("prot", "Prot");
                dtgCardapioAlimentos.Columns.Add("carbo", "Carbo");
                dtgCardapioAlimentos.Columns.Add("lipidio", "Lipídio");
                dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
                dtgCardapioAlimentos.Columns["kcal"].Visible = false;
                dtgCardapioAlimentos.Columns["qtd"].Visible = false;
                dtgCardapioAlimentos.Columns["prot"].Visible = false;
                dtgCardapioAlimentos.Columns["carbo"].Visible = false;
                dtgCardapioAlimentos.Columns["lipidio"].Visible = false;
            }
            dtgCardapioAlimentos.Rows.Clear();
            FiltrarAlimentoTabela(txtFiltroAlimento.Text, cbxTabelaAlimentoCardapio.Text, listaAlimentosCardapio, dtgCardapioAlimentos);
            dtgCardapioAlimentos.AutoResizeColumns();
            loadStop(this);
        }

        private void FiltrarAlimentoTabela(string filtroAlimento, string nomeTabela, List<Alimentos> listaCarregada, DataGridView dtg)
        {
            if (filtroAlimento != string.Empty)
            {
                string filtro = filtroAlimento.Trim();

                listaCarregada.ForEach(x =>
                {
                    if (x.nomeAlimento.ToUpper().Contains(filtroAlimento.ToUpper().Trim()) && x.nomeTabela.ToUpper().Equals(nomeTabela.ToUpper()))
                    {
                        dtg.Rows.Add(x.codAlimento, x.nomeAlimento, x.kcal, x.qtd, x.prot, x.carbo, x.lipidio);
                    }
                });
            }
            else
            {
                listaAlimentosCardapio.ForEach(x =>
                {
                    dtg.Rows.Add(x.codAlimento, x.nomeAlimento, x.kcal, x.qtd, x.prot, x.carbo, x.lipidio);
                });
            }
        }

        private void dtgRefeicoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double kcalTotal = 0;
            //dtgRefeicoes.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == cbxMedCaseira.Index)
            {
                var medCaseira = medidaCaseiraDAO.Buscar(Convert.ToInt32(dtgRefeicoes.Rows[e.RowIndex].Cells[codAlimento.Index].Value)
                                                        , Convert.ToString(dtgRefeicoes.Rows[e.RowIndex].Cells[cbxMedCaseira.Index].Value));
                if (medCaseira is null || medCaseira.Count == 0)
                    return;
                //Verificar o por quê está dando erro ao selecionar a medida caseira do alimento. Ver para colocar no leave do campo.
                medCaseira.ForEach(x =>
                {
                    if (x.codAlimento == x.codAlimento)
                        dtgRefeicoes.Rows[e.RowIndex].Cells[qtd.Index].Value = Math.Round(Convert.ToDouble(x.qtd), 2);
                });
            }
            CarregarGrafico(Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["prot"].Value),
                                 Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["carbo"].Value),
                                 Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["lipidio"].Value));
            RecalcularMacroNutrientes(dtgRefeicoes, Convert.ToDecimal(quantidadeAntigaCardapio));
            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
            {
                kcalTotal += Convert.ToDouble(row.Cells[kcal.Index].Value);
            }
            quantidadeAntigaCardapio = 0;
            lblValorKcal.Text = string.Empty;
            lblValorKcal.Text = kcalTotal.ToString("N2");
            quantidadeAntigaCardapio = 0;
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteConsultaCardapio.Text = PacienteModel.nomePacienteModel;
        }

        private void dtgRefeicoes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value) != 0)
                quantidadeAntigaCardapio = Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            dtgRefeicoes.Rows.Clear();
            cbxDataCardSalvo.Items.Clear();
            graficoMacroNutri.Series = null;
            cbxRefeicao.Text = null;
            lblValorKcal.Text = null;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
            PacienteModel.codPacienteModel = null;
            PacienteModel.nomePacienteModel = null;
            txtPacienteConsultaCardapio.Clear();
            trwDadosCard.Nodes.Clear();
            chkDataExisteCardapio.Checked = false;
        }

        private void cbxTabelaAlimentoCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTabelaAlimentoCardapio.Text != string.Empty)
            {
                loadStart(this);
                dtgCardapioAlimentos.Rows.Clear();
                listaAlimentosCardapio.Clear();
                listaAlimentosCardapio = alimentoDAO.Buscar(string.Empty, cbxTabelaAlimentoCardapio.Text);
                if (listaAlimentosCardapio == null)
                {
                    loadStop(this);
                    return;
                }

                //DataTable dt = ConvertToDataTable(listaAlimentosCardápio);
                //dtgCardapioAlimentos.DataSource = dt;

                if (dtgCardapioAlimentos.Columns.Count == 0)
                {
                    dtgCardapioAlimentos.Columns.Add("codAlimento", "Código");
                    dtgCardapioAlimentos.Columns.Add("nomeAlimento", "Alimento");
                    dtgCardapioAlimentos.Columns.Add("kcal", "KCal");
                    dtgCardapioAlimentos.Columns.Add("qtd", "Qtd");
                    dtgCardapioAlimentos.Columns.Add("prot", "Prot");
                    dtgCardapioAlimentos.Columns.Add("carbo", "Carbo");
                    dtgCardapioAlimentos.Columns.Add("lipidio", "Lipídio");
                    dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
                    dtgCardapioAlimentos.Columns["nomeAlimento"].ReadOnly = true;
                    dtgCardapioAlimentos.Columns["kcal"].Visible = false;
                    dtgCardapioAlimentos.Columns["qtd"].Visible = false;
                    dtgCardapioAlimentos.Columns["prot"].Visible = false;
                    dtgCardapioAlimentos.Columns["carbo"].Visible = false;
                    dtgCardapioAlimentos.Columns["lipidio"].Visible = false;
                }

                listaAlimentosCardapio.ForEach(x =>
                {
                    dtgCardapioAlimentos.Rows.Add(x.codAlimento, x.nomeAlimento, x.kcal, x.qtd, x.prot, x.carbo, x.lipidio);
                });

                //dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
                //dtgCardapioAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";
                //dtgCardapioAlimentos.Columns["kcal"].Visible = false;
                //dtgCardapioAlimentos.Columns["qtd"].Visible = false;
                //dtgCardapioAlimentos.Columns["prot"].Visible = false;
                //dtgCardapioAlimentos.Columns["carbo"].Visible = false;
                //dtgCardapioAlimentos.Columns["lipidio"].Visible = false;
                //dtgCardapioAlimentos.Columns["nomeTabela"].Visible = false;
                //dtgCardapioAlimentos.Columns["MedidaCaseira"].Visible = false;
                //dtgCardapioAlimentos.Columns["Cardapio"].Visible = false;
                //dtgCardapioAlimentos.AutoResizeColumns();
                loadStop(this);

            }
        }
        private void btnCancelarCardapio_Click(object sender, EventArgs e)
        {
            txtPaciente.Text = string.Empty;
            PacienteModel.codPacienteModel = string.Empty;
            PacienteModel.nomePacienteModel = string.Empty;
            txtPacienteConsultaCardapio.Text = string.Empty;
            dtgRefeicoes.Rows.Clear();
            cbxTabelaAlimentoCardapio.Text = string.Empty;
            dtgCardapioAlimentos.DataSource = null;
            dtgCardapioAlimentos.Rows.Clear();
            dtgCardapioAlimentos.Columns.Clear();
            graficoMacroNutri.Series = null;
            trwDadosCard.Nodes.Clear();
            lblValorKcal.Text = string.Empty;
            cbxRefeicao.SelectedIndex = -1;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
        }

        private void tbConsultaCardapio_Click(object sender, EventArgs e)
        {
        }

        private void tbConsultaCardapio_Enter(object sender, EventArgs e)
        {
        }

        private void btnCancelarEditAlimentos_Click(object sender, EventArgs e)
        {
            cbxTabela.SelectedIndex = -1;
            txtAlimentoFiltro.Text = string.Empty;
            if (dtgConAlimento.Rows.Count > 0)
                dtgConAlimento.Rows.Clear();
            if (dtgConAlimento.Columns.Count > 0)
                dtgConAlimento.Columns.Clear();
        }

        private void cbxDataConsulta_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaCardapio();
        }

        private void CarregaCardapio()
        {
            if (String.IsNullOrEmpty(cbxDataConsulta.Text))
            {
                nMensagemAviso("Selecionar uma data para o carregamento das informações do cardápio!");
                return;
            }
            var listaCardapio = cardapioDAO.Consultar(Convert.ToInt32(PacienteModel.codPacienteModel), Convert.ToString(cbxDataConsulta.Text));
            if (listaCardapio == null || listaCardapio.Count == 0)
            {
                return;
            }

            trwDadosCard.Nodes.Clear();
            trwDadosCard.Columns.Clear();

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
                dtgCardGrid.Rows.Add(card.Refeicao, card.Alimentos.nomeAlimento, card.medidaCaseiraQtde, Convert.ToString(card.obs));
                switch (card.Refeicao)
                {
                    case "Café da manhã":
                        TreeGridNode filhoCafe = cafe.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add("Observação: " + card.obs.ToString());
                        filhoCafe.ImageIndex = 2;
                        filhoCafe = cafe.Nodes.Add(string.Empty);
                        return;

                    case "Lanche":
                        TreeGridNode filhoLanche = Lanche.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add("Observação: " + Convert.ToString(card.obs));
                        filhoLanche.ImageIndex = 2;
                        filhoLanche = Lanche.Nodes.Add(string.Empty);
                        return;

                    case "Almoço":
                        TreeGridNode filhoAlmoco = Almoco.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add("Observação: " + Convert.ToString(card.obs));
                        filhoAlmoco.ImageIndex = 2;
                        filhoAlmoco = Almoco.Nodes.Add(string.Empty);
                        return;

                    case "Lanche da tarde":
                        TreeGridNode filhoLancheTarde = LancheTarde.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add("Observação: " + Convert.ToString(card.obs));
                        filhoLancheTarde.ImageIndex = 2;
                        filhoLancheTarde = LancheTarde.Nodes.Add(string.Empty);
                        return;

                    case "Jantar":
                        TreeGridNode filhoJantar = Jantar.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add("Observação: " + Convert.ToString(card.obs));
                        filhoJantar.ImageIndex = 2;
                        filhoJantar = Jantar.Nodes.Add(string.Empty);
                        return;

                    case "Ceia":
                        TreeGridNode filhoCeia = Ceia.Nodes.Add("Alimento: " + card.Alimentos.nomeAlimento);
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Medida Caseira: " + card.medidaCaseiraQtde.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("KCal: " + card.kcal.ToString());
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add("Observação: " + Convert.ToString(card.obs));
                        filhoCeia.ImageIndex = 2;
                        filhoCeia = Ceia.Nodes.Add(string.Empty);
                        return;
                }
            });
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            if (txtPacienteAntro.Text == string.Empty)
            {
                nMensagemAviso("É necessário primeiramente informar um paciente para visualizar evolução gráfica!");
                return;
            }

            using (frmGraficoPaciente grafico = new frmGraficoPaciente(Convert.ToInt32(PacienteModel.codPacienteModel), txtPacienteAntro.Text))
            {
                grafico.ShowDialog();
            }
        }

        private void cbxTabela_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarAlimentos(string.Empty, cbxTabela.Text, dtgConAlimento);
            return;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(new System.IO.MemoryStream(Resources.ImpressaoCardapio));
            //WorksheetCollection worksheets = workbook.Worksheets;
            //StyleFlag flags = new StyleFlag
            //{
            //    All = true
            //};
            //string ultimaRefeicao = string.Empty;
            //var linha = worksheets.GetRangeByName("colRefeicao").FirstRow;

            //worksheets.GetRangeByName("paciente").PutValue(txtPacienteConsultaCardapio.Text, false, false);
            //Style stylePaciente = worksheets[0].Cells["B3"].GetStyle();
            ////stylePaciente.HorizontalAlignment = TextAlignmentType.Left;
            //stylePaciente.Font.IsBold = true;
            //stylePaciente.Font.Size = 16;
            //worksheets[0].Cells.Rows[linha].ApplyStyle(stylePaciente, flags);

            //worksheets.GetRangeByName("dataConsulta").PutValue(cbxDataConsulta.Text, false, false);
            //Style styleDataConsulta = worksheets[0].Cells["B3"].GetStyle();
            ////styleDataConsulta.HorizontalAlignment = TextAlignmentType.Left;
            //styleDataConsulta.Font.IsBold = true;
            //styleDataConsulta.Font.Size = 16;
            //worksheets[0].Cells.Rows[linha].ApplyStyle(styleDataConsulta, flags);

            //dtgCardGrid.Sort(dtgCardGrid.Columns["refeicao"], ListSortDirection.Ascending);

            //foreach (DataGridViewRow row in dtgCardGrid.Rows)
            //{            
            //    linha += 1;
            //    if (string.IsNullOrEmpty(ultimaRefeicao) || ultimaRefeicao != Convert.ToString(row.Cells["refeicao"].Value).ToUpper())
            //    {
            //        worksheets[0].Cells["A" + (linha + 1)].PutValue(Convert.ToString(row.Cells["refeicao"].Value), false, false);
            //        Style styleCell = worksheets[0].Cells["C" + (linha + 1)].GetStyle();
            //        //styleCell.HorizontalAlignment = TextAlignmentType.Right;
            //        styleCell.VerticalAlignment = TextAlignmentType.Right;
            //        styleCell.Font.IsBold = true;
            //        worksheets[0].Cells.Rows[linha].ApplyStyle(styleCell, flags);

            //        ultimaRefeicao = Convert.ToString(row.Cells["refeicao"].Value).ToUpper();
            //    }

            //    //if (Convert.ToString(row.Cells["alimento"].Value).Length < 15)
            //    //{
            //    worksheets[0].Cells["D" + (linha + 1)].PutValue(Convert.ToString(row.Cells["alimento"].Value).ToUpper(), false, false);
            //    Style styleCellFood = worksheets[0].Cells["D" + (linha + 1)].GetStyle();
            //    //styleCellFood.VerticalAlignment = TextAlignmentType.Center;
            //    worksheets[0].Cells.Rows[linha].ApplyStyle(styleCellFood, flags);

            //    //}
            //    //else
            //    //{
            //    //    var obs = worksheets[0].Cells["C" + (linha + 1)];
            //    //    obs.PutValue(Convert.ToString(row.Cells["alimento"].Value).Trim(), false, false);
            //    //    decimal lineBreak = Math.Ceiling(Convert.ToDecimal(obs.GetWidthOfValue() / 15));
            //    //    obs.Worksheet.Cells.Rows[linha + 1].Height = (double)(15 * lineBreak);
            //    //    if (lineBreak > 1)
            //    //        obs.Worksheet.Cells.Rows[linha + 1].Height += 3;
            //    //}

            //    worksheets[0].Cells["O" + (linha + 1)].PutValue(Convert.ToString(row.Cells["medidacaseiraqtd"].Value), false, false);
            //    Style styleCellMed = worksheets[0].Cells["O" + (linha + 1)].GetStyle();
            //    styleCellMed.HorizontalAlignment = TextAlignmentType.Center;
            //    worksheets[0].Cells.Rows[linha].ApplyStyle(styleCellMed, flags);

            //    //if (Convert.ToString(row.Cells["observ"].Value).Length < 20)
            //    //{
            //    worksheets[0].Cells["P" + (linha + 1)].PutValue(Convert.ToString(row.Cells["observ"].Value).Trim());
            //    Style styleCellObs = worksheets[0].Cells["P" + (linha + 1)].GetStyle();
            //    styleCellObs.HorizontalAlignment = TextAlignmentType.Left;
            //    worksheets[0].Cells.Rows[linha].ApplyStyle(styleCellObs, flags);

            //    //}
            //    //else
            //    //{
            //    //    var obs = worksheets[0].Cells["D" + (linha + 1)];
            //    //    obs.PutValue(Convert.ToString(row.Cells["observ"].Value).Trim(), false, false);
            //    //    decimal lineBreak = Math.Ceiling(Convert.ToDecimal(obs.GetWidthOfValue() / 75));
            //    //    obs.Worksheet.Cells.Rows[linha + 1].Height = (double)(15 * lineBreak);
            //    //    if (lineBreak > 1)
            //    //        obs.Worksheet.Cells.Rows[linha + 1].Height += 3;
            //    //}

            //    Style styles = new Style();
            //    styles.Font.Size = 14;
            //    styles.HorizontalAlignment = TextAlignmentType.Justify;

            //    StyleFlag flagsF = new StyleFlag
            //    {
            //        FontSize = true,
            //        All = true,
            //        ShrinkToFit = true
            //    };

            //    worksheets[0].Cells.Rows[linha].ApplyStyle(styles, flagsF);
            //    worksheets[0].Cells.UnhideRow(linha, 17);
            //}

            //AutoFitterOptions opt = new Aspose.Cells.AutoFitterOptions();
            //opt.OnlyAuto = true;
            //opt.IgnoreHidden = true;

            //worksheets[0].AutoFitColumns(opt);

            //string tempFile = Path.Combine(Path.GetTempPath(), Path.GetTempFileName().Replace(".tmp", ".pdf"));
            //workbook.Save(tempFile);
            //Process.Start(tempFile);
        }

        private void txtDataCardapio_Leave(object sender, EventArgs e)
        {
            if (txtDataCardapio.Text == string.Empty)
            {
                txtDataCardapio.Text = FormatDate(DateTime.Now.ToString("dd/MM/yyyy"));
            }
            else
            {
                txtDataCardapio.Text = FormatDate(txtDataCardapio.Text);
            }

            CarregarAlimentosCardapioConfig();
        }

        private void CarregarAlimentosCardapioConfig()
        {
            string data = string.Empty;
            if (cbxDataCardSalvo.Visible)
            {
                data = cbxDataCardSalvo.Text;
            }
            else
            {
                data = txtDataCardapio.Text;
            }
            if (string.IsNullOrEmpty(PacienteModel.codPacienteModel))
            {
                return;
            }
            if (string.IsNullOrEmpty(data))
            {
                return;
            }
            if (string.IsNullOrEmpty(cbxRefeicao.Text))
            {
                return;
            }

            var carregarAlimentos = cardapioDAO.Consultar(Convert.ToInt32(PacienteModel.codPacienteModel), data);

            dtgRefeicoes.DataSource = null;
            dtgRefeicoes.Rows.Clear();
            if (carregarAlimentos == null || carregarAlimentos.Count == 0)
                return;

            double kcalTotal = 0;
            carregarAlimentos.ForEach(x =>
            {
                var linha = dtgRefeicoes.Rows.Add(
                                x.codAlimento
                              , x.Alimentos.nomeAlimento
                              , x.medidaCaseiraQtde
                              , x.Alimentos.kcal
                              , x.Alimentos.prot
                              , x.Alimentos.carbo
                              , x.Alimentos.lipidio
                              , string.Empty
                              , x.Refeicao
                              , x.obs);

                kcalTotal += Convert.ToDouble(dtgRefeicoes.Rows[linha].Cells[kcal.Index].Value);
                CarregarGrafico(Convert.ToDouble(x.Alimentos.prot), Convert.ToDouble(x.Alimentos.carbo), Convert.ToDouble(x.Alimentos.lipidio));
            });
            lblValorKcal.Text = kcalTotal.ToString("N2");
            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
            {
                var medCaseiraItens = medidaCaseiraDAO.Buscar(Convert.ToInt32(row.Cells["codAlimento"].Value), string.Empty);

                if (medCaseiraItens is null)
                    continue;

                foreach (var medidaCaseira in medCaseiraItens)
                {
                    if (Convert.ToDouble(row.Cells["codAlimento"].Value) == Convert.ToDouble(medidaCaseira.codAlimento))
                    {
                        DataGridViewComboBoxCell comboCell = dtgRefeicoes.Rows[row.Index].Cells[cbxMedCaseira.Index] as DataGridViewComboBoxCell;

                        comboCell.Items.Add(medidaCaseira.descricao);
                        row.Cells["cbxMedCaseira"].Value = medidaCaseira.descricao;
                        row.Cells["qtd"].Value = medidaCaseira.qtd;
                    }
                }
            }
            dtgRefeicoes.AutoResizeColumns();
        }

        private void pbAddMedCaseira_Click(object sender, EventArgs e)
        {
            if (dtgMedCaseiraAlimentos.Rows.Count == 0)
                return;

            if (dtgMedCaseiraAlimentos.SelectedRows.Count >= 1 || dtgMedCaseiraAlimentos.SelectedCells.Count >= 1)
            {
                foreach (DataGridViewRow row in dtgMedCaseiraAlimentos.Rows)
                    if (row.Selected == true || row.Cells["nomeAlimento"].Selected)
                    {
                        dtgSalvarMedCaseira.Rows.Add(row.Cells["codAlimento"].Value
                             , row.Cells["nomeAlimento"].Value
                             , string.Empty
                             , string.Empty
                             , mCbxTabelasMedCas.Text);
                    }
            }
        }

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAlimentoFiltro.Text))
            {
                loadStart(this);
                var listaAlimentos = alimentoDAO.Buscar(txtAlimentoFiltro.Text, cbxTabela.Text);
                if (listaAlimentos == null)
                {
                    loadStop(this);
                    return;
                }

                if (dtgConAlimento.Columns.Count == 0)
                {
                    dtgConAlimento.Columns.Add("codAlimento", "Código");
                    dtgConAlimento.Columns.Add("nomeAlimento", "Alimento");
                    dtgConAlimento.Columns.Add("kcal", "KCal");
                    dtgConAlimento.Columns.Add("qtd", "Qtd");
                    dtgConAlimento.Columns.Add("prot", "Prot");
                    dtgConAlimento.Columns.Add("carbo", "Carbo");
                    dtgConAlimento.Columns.Add("lipidio", "Lipídio");
                    dtgConAlimento.Columns["codAlimento"].Visible = false;
                    dtgConAlimento.Columns["nomeAlimento"].ReadOnly = true;
                    dtgConAlimento.Columns["kcal"].Visible = false;
                    dtgConAlimento.Columns["qtd"].Visible = false;
                    dtgConAlimento.Columns["prot"].Visible = false;
                    dtgConAlimento.Columns["carbo"].Visible = false;
                    dtgConAlimento.Columns["lipidio"].Visible = false;
                }
                dtgConAlimento.Rows.Clear();
                FiltrarAlimentoTabela(txtAlimentoFiltro.Text, cbxTabela.Text, listaAlimentos, dtgConAlimento);

                //DataTable dt = ConvertToDataTable(listaAlimentos);
                //dtgCardapioAlimentos.DataSource = dt;

                //dtgCardapioAlimentos.Columns["codAlimento"].Visible = false;
                //dtgCardapioAlimentos.Columns["nomeAlimento"].HeaderText = "Alimento";
                //dtgCardapioAlimentos.Columns["kcal"].Visible = false;
                //dtgCardapioAlimentos.Columns["qtd"].Visible = false;
                //dtgCardapioAlimentos.Columns["prot"].Visible = false;
                //dtgCardapioAlimentos.Columns["carbo"].Visible = false;
                //dtgCardapioAlimentos.Columns["lipidio"].Visible = false;
                //dtgCardapioAlimentos.Columns["nomeTabela"].Visible = false;
                //dtgCardapioAlimentos.Columns["MedidaCaseira"].Visible = false;
                //dtgCardapioAlimentos.Columns["Cardapio"].Visible = false;
                dtgConAlimento.AutoResizeColumns();
                loadStop(this);
            }
        }

        private void calAgendamento_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (e.Item.BackgroundColor == Color.LightGreen || e.Item.BackgroundColor == Color.Tomato)
                return;

            if (nMensagemAceita("Você marcar como atendido esta consulta?") == DialogResult.Yes)
            {
                FinalizarAtendimento(Convert.ToString(e.Item.StartDate), e.Item.Text, true, (bool)(e.Item.BackgroundColor == Color.Cyan));
                e.Item.BackgroundColor = Color.LightGreen;
                return;
            }
            if (nMensagemAceita("Você deseja cancelar esta consulta?") == DialogResult.Yes)
            {
                CancelarAtendimento(Convert.ToString(e.Item.StartDate), e.Item.Text, false, (bool)(e.Item.BackgroundColor == Color.Cyan));
                e.Item.BackgroundColor = Color.Tomato;
                return;
            }
        }

        private void txtDataCardapio_LinkClicked(object sender, LinkClickedEventArgs e)
        {

        }

        private void cbxRefeicao_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {
            CarregarAlimentosCardapioConfig();
            CarregarDatasCardapio(cbxDataCardSalvo);
            CarregarCalculoSelecionado();
            lblValorKcal.Text = string.Empty;
        }

        private void CarregarCalculoSelecionado()
        {
            string formatarCampoValor = "###,###,##0.00";

            if (string.IsNullOrEmpty(PacienteModel.codPacienteModel))
                return;

            var loadCalc = CarregaCalculos(Convert.ToInt32(PacienteModel.codPacienteModel));
            if (rbHarrisBenedict.Checked)
            {
                lblTMB.Text = string.Empty;
                lblVET.Text = string.Empty;
                lblTMB.Text = Convert.ToString(CalcularHarrisBenedict(loadCalc).ToString(formatarCampoValor));
                lblVET.Text = Convert.ToString(CalcularHarrisPraVET(loadCalc).ToString(formatarCampoValor));
                if (lblVET.Text == "0")
                {
                    lblVET.Text = "Não possui configuração de Grau Atividade.";
                }
            }
            else if (rbFAOOMS.Checked)
            {
                lblVET.Text = string.Empty;
                lblVET.Text = Convert.ToString(CalculaFAOOMS(loadCalc).ToString(formatarCampoValor));
            }
            else if (rbDRI.Checked)
            {
                lblVET.Text = string.Empty;
                lblVET.Text = Convert.ToString(CalcularDRI(loadCalc).ToString(formatarCampoValor));
                if (lblVET.Text == "0")
                {
                    lblVET.Text = "Não possui configuração de CAF.";
                }
            }
        }

        private Antropometria CarregaCalculos(int codPaciente)
        {
            Antropometria antro = new Antropometria();
            antro.Paciente = new Paciente();

            var listaCardapio = antropometriaDAO.CarregarUltimaAntropometria();

            if (listaCardapio is null || listaCardapio.Count == 0)
                return null;

            listaCardapio.ForEach(x =>
            {
                antro.peso = x.peso;
                antro.altura = x.altura;
                antro.grauAtividade = x.grauAtividade;
                antro.temGrauAtividade = x.temGrauAtividade;
                antro.temCoefAtividade = x.temCoefAtividade;
                antro.coefAtividade = x.coefAtividade;
                antro.Paciente.dtNasc = x.Paciente.dtNasc;
                antro.Paciente.sexo = x.Paciente.sexo;
            });
            return antro;
        }

        private void rbHarrisBenedict_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHarrisBenedict.Checked)
            {
                chkTMB.Visible = true;
                mlblVET.Visible = true;
                chkTMB_CheckedChanged(sender, e);
                CarregarCalculoSelecionado();
            }
            else
            {
                chkTMB.Visible = false;
                chkTMB.Checked = false;
                mlblTMB.Visible = false;
                lblTMB.Visible = false;
            }
        }

        private void chkTMB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTMB.Checked)
            {
                mlblTMB.Visible = true;
                lblTMB.Visible = true;
                mlblTMB.Visible = true;
            }
            else
            {
                mlblTMB.Visible = false;
                lblTMB.Visible = false;
            }
        }

        private void rbFAOOMS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFAOOMS.Checked)
                CarregarCalculoSelecionado();
        }

        private void rbDRI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDRI.Checked)
                CarregarCalculoSelecionado();
        }
        #endregion

        #region Configurações
        [Obsolete]
        private void btnSalvarConfigUsuario_Click(object sender, EventArgs e)
        {
            bool alterarSenha = false;
            if (txtUsuarioConfig.Text == string.Empty)
            {
                Interaction.MsgBox("O usuário não foi informado");
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Interaction.MsgBox("As senhas não conferem");
                return;
            }
            FecharAbrirConexao();

            if (usuarioDAO.VerificarExisteUsuario(txtUsuarioConfig.Text, string.Empty))
            {
                if (Interaction.MsgBox("Você deseja alterar a senha do usuário?", MsgBoxStyle.YesNo, "ALTERAÇÃO DE SENHA") == MsgBoxResult.Yes)
                    alterarSenha = true;
                usuarioDAO.AlterarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmailConfig.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha, txtCRN.Text);
                tbConfig_Enter(sender, e);
                LimparCamposConfig();
            }
            else
            {
                usuarioDAO.CriarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmailConfig.Text, cbxSituacao.Text, cbxTipoUsuario.Text, txtCRN.Text);
                tbConfig_Enter(sender, e);
                LimparCamposConfig();
            }
        }

        private void LimparCamposConfig()
        {
            txtUsuarioConfig.Text = string.Empty;
            txtNomeUsuarioConfig.Text = string.Empty;
            cbxSituacao.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmarSenha.Text = string.Empty;
            cbxTipoUsuario.Text = string.Empty;
            txtEmailConfig.Text = string.Empty;
            txtCRN.Text = string.Empty;
        }

        private void tbConfig_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabConfig.Text))
            {
                return;
            };
            loadStart(this);

            var listaUsuario = usuarioDAO.getUsuario(string.Empty);
            if (listaUsuario == null)
            {
                loadStop(this);
                return;
            }

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
            dtgUsuarios.Columns["ConfiguracoesUsuarios"].Visible = false;
            dtgUsuarios.Columns["dtHoraUltAcesso"].Visible = false;
            dtgUsuarios.Columns["podeLogar"].Visible = false;
            dtgUsuarios.AutoResizeColumns();
            loadStop(this);
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
            loadStart(this);

            var listaUsuarios = usuarioDAO.getUsuario(string.Empty);
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
            {
                loadStop(this);
                return;
            }

            cbxUsuarioPerm.Items.Clear();
            listaUsuarios.ForEach(x => cbxUsuarioPerm.Items.Add(x.usuario));

            var listaPermissao = permissaoDAO.getAllPermissao();
            if (listaPermissao == null || listaPermissao.Count <= 0)
            {
                loadStop(this);
                return;
            }
            DataTable dt = ConvertToDataTable(listaPermissao);
            if (dtgPermUsuarios.Rows.Count > 0 && dtgPermUsuarios.Columns.Count > 0)
            {
                dtgPermUsuarios.Columns.Clear();
            }
            dtgPermUsuarios.DataSource = dt;
            dtgPermUsuarios.Columns["Login"].Visible = false;
            dtgPermUsuarios.Columns["ID"].Visible = false;
            dtgPermUsuarios.Columns["usuario"].HeaderText = "Usuário";
            dtgPermUsuarios.Columns["programa"].HeaderText = "Tela";
            dtgUsuarios.AutoResizeColumns();
            loadStop(this);
        }

        private void txtUsuarioConfig_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text != string.Empty)
                usuarioDAO.getUsuario(txtUsuarioConfig.Text);
        }

        private void btnSalvarPermissao_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxUsuarioPerm.Text)) { nMensagemAlerta("Favor informar usuário"); }
            if (String.IsNullOrEmpty(cbxTelaLiberarPerm.Text)) { nMensagemAlerta("Favor informar tela a liberar"); }

            FecharAbrirConexao();
            permissaoDAO.AdicionarPermissao(Convert.ToString(cbxUsuarioPerm.Text), Convert.ToString(cbxTelaLiberarPerm.Text));
            tbPermissao_Enter(sender, e);
        }

        private void btnExcluirConfigUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text == string.Empty)
            {
                nMensagemAlerta("É necessário informar o usuário no campo para remover.");
                return;
            }
            loadStart(this);
            FecharAbrirConexao();
            usuarioDAO.Deletar(txtUsuarioConfig.Text);
            loadStop(this);
            tbConfig_Enter(sender, e);
        }

        private void dtgUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                loadStart(this);
                usuarioDAO.Deletar(Convert.ToString(dtgUsuarios.CurrentRow.Cells["usuario"].Value));
                loadStop(this);
            }
        }

        private void tabHorarioAtendimento_Enter(object sender, EventArgs e)
        {

            loadStart(this);
            var listaUsuarios = usuarioDAO.getUsuario(string.Empty);
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
            {
                loadStop(this);
                return;
            }

            cbxUsuarioPerm.Items.Clear();
            listaUsuarios.ForEach(x =>
            {
                if (x.perfil.ToLower().Equals("nutricionista"))
                    cbxUsuNutri.Items.Add(x.usuario);
            });

            var listConfig = configDAO.Consultar();
            if (listConfig == null)
            {
                loadStop(this);
                return;
            }

            DataTable dt = ConvertToDataTable(listConfig);
            dtgConfigHorario.DataSource = dt;

            dtgConfigHorario.Columns["ID"].Visible = false;
            dtgConfigHorario.Columns["usuario"].HeaderText = "Usuário";
            dtgConfigHorario.Columns["diaSemana"].HeaderText = "Semana";
            dtgConfigHorario.Columns["horaInicio"].HeaderText = "Hora Início";
            dtgConfigHorario.Columns["horaFim"].HeaderText = "Hora Fim";
            dtgConfigHorario.Columns["Login"].Visible = false;
            loadStop(this);
        }

        private void btnSalvarHoraAtend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxUsuNutri.Text)) { nMensagemAviso("Favor informar o usuário!"); return; }
            if (string.IsNullOrEmpty(cbxDiaSemana.Text)) { nMensagemAviso("Favor informar o dia da semana!"); return; }
            if (string.IsNullOrEmpty(txtHoraInicio.Text)) { nMensagemAviso("Favor informar a hora início!"); return; }
            if (string.IsNullOrEmpty(txtHoraFim.Text)) { nMensagemAviso("Favor informar a hora fim!"); return; }
            if (txtHoraFim.Text.Contains("24:") || txtHoraFim.Text.Contains("00:")) { nMensagemAviso("Só é permitido agendar até as 23H!"); return; }
            if (DateTime.Compare(Convert.ToDateTime(txtHoraFim.Text), Convert.ToDateTime(txtHoraInicio.Text)) < 1) { nMensagemAviso("Não é possível agendar Hora Fim menor que Hora Início."); return; }
            FecharAbrirConexao();

            configDAO.Salvar(Convert.ToString(cbxUsuNutri.Text), Convert.ToString(cbxDiaSemana.Text), Convert.ToString(txtHoraInicio.Text), Convert.ToString(txtHoraFim.Text));
            CarregarConfigs();
            cbxUsuNutri.Text = string.Empty;
            cbxDiaSemana.Text = "Segunda";
            txtHoraInicio.Text = string.Empty;
            txtHoraFim.Text = string.Empty;
        }

        private void CarregarConfigs()
        {
            loadStart(this);
            var listaConfigs = configDAO.Consultar();
            if (listaConfigs == null)
            {
                loadStop(this);
                return;
            }
            DataTable dt = ConvertToDataTable(listaConfigs);
            dtgConfigHorario.DataSource = dt;

            dtgConfigHorario.Columns["ID"].Visible = false;
            dtgConfigHorario.Columns["Login"].Visible = false;
            dtgConfigHorario.Columns["diaSemana"].HeaderText = "Semana";
            dtgConfigHorario.Columns["horaInicio"].HeaderText = "Início";
            dtgConfigHorario.Columns["horaFim"].HeaderText = "Fim";

            GetConfigAtendimento();
            loadStop(this);

        }

        private void dtgConfigHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            cbxUsuNutri.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["usuario"].Value);
            cbxDiaSemana.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["diaSemana"].Value);
            txtHoraInicio.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["horaInicio"].Value);
            txtHoraFim.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["horaFim"].Value);
            cbxUsuNutri.Refresh();
            cbxDiaSemana.Refresh();
        }

        private void txtHoraInicio_Validated(object sender, EventArgs e)
        {
            txtHoraInicio.Text = formatarHora(txtHoraInicio.Text);
        }

        private void txtHoraFim_Validated(object sender, EventArgs e)
        {
            txtHoraFim.Text = formatarHora(txtHoraFim.Text);
        }

        private void btnExcluirPerm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxUsuarioPerm.Text)) { nMensagemAlerta("Favor informar usuário"); }
            if (String.IsNullOrEmpty(cbxTelaLiberarPerm.Text)) { nMensagemAlerta("Favor informar tela a ser removida"); }
            FecharAbrirConexao();
            permissaoDAO.RemoverPermissao(cbxUsuarioPerm.Text, cbxTelaLiberarPerm.Text);
        }

        private void dtgPermUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            cbxUsuarioPerm.Text = dtgPermUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            cbxTelaLiberarPerm.Text = dtgPermUsuarios.Rows[e.RowIndex].Cells["programa"].Value.ToString();
            cbxUsuarioPerm.Refresh();
            cbxTelaLiberarPerm.Refresh();
        }
        #endregion

        #region Tela Sobre

        private void tbSobre_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tbSobre.Text))
            {
                return;
            };
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            Deslogar(sender, e);
        }
                      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        #endregion

    }
}