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
using System.Globalization;
using TCC2.Telas;
using TCC2.DAO;
using Calendar = System.Windows.Forms.Calendar.Calendar;

namespace TCC2
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
        private double quantidadeAntigaCardapio;
        //Image capturaImagem;
        public string caminhoImagemSalva = null;
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public DateTime dataAgendadoAnterior;
        #endregion

        #region Menu
        public FrmMenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            usuarioDAO.setNomeUsuario(usuarioLogado);
            var OpcoesMenu = new ContextMenu();
            OpcoesMenu.MenuItems.Add(new MenuItem("Deslogar", Deslogar));
            OpcoesMenu.MenuItems.Add(new MenuItem("Fechar", FecharAplicacao));
            NutreasyIconNotify.ContextMenu = OpcoesMenu;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen400, TextShade.WHITE);
            calAgendamento.MaximumViewDays = 70000;
            this.MaximizeBox = false;

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
            VerificarPermissao(tabMenu.Text);
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

        private void tabMenu_Click(object sender, EventArgs e)
        {
            var dataAgenda = DateTime.Now.ToString("dd/MM/yyyy");
            var dataInicio = dataAgenda + " 00:00:00";
            var dataFim = dataAgenda + " 23:59:59";
            DateTime dataMarcadasIni = Convert.ToDateTime(dataInicio);
            DateTime dataMarcadasFim = Convert.ToDateTime(dataFim);
            using (var db = new NutreasyEntities())
            {
                var selectAgendamento = db.Database.Connection.CreateCommand();

                selectAgendamento.CommandText = $"SELECT * FROM Agenda WHERE data>='{dataMarcadasIni.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                                                $"AND data<='{dataMarcadasFim.ToString("yyyy-MM-dd HH:mm:ss")}'";

                db.Database.Connection.Open();
                IDataReader dr = selectAgendamento.ExecuteReader();

                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["data"]).ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && (int)dr["Cancelado"] == 0)
                    {
                        if (mlblNome.Text != "Nome")
                            return;

                        if ((DateTime)dr["data"] <= DateTime.Now && (bool)dr["atendido"] != true)
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
                                mlblObservação.Text = "";
                            }
                            if ((bool)dr["atendido"])
                            {
                                mCardAtendimentoAtual.BackColor = Color.LightGreen;
                            }
                            // NutreasyIconNotify.ShowBalloonTip(10, "Consulta atual", $"Você possui horário agora com: {x.paciente}", ToolTipIcon.Info);
                        }
                        else if ((DateTime)dr["data"] > DateTime.Now && (int)dr["Cancelado"] == 0)
                        {
                            if ((DateTime)dr["data"] > DateTime.Now)
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
                                    mlblObservacaoFuturo.Text = "";
                                }
                                if ((bool)dr["atendido"])
                                {
                                    mCardAtendimentoFuturo.BackColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                mCardAtendimentoFuturo.Visible = false;
                            }
                            //NutreasyIconNotify.ShowBalloonTip(10, "Consulta às {x.hora}", $"Você possui horário marcado com: {x.paciente} às {x.hora}", ToolTipIcon.Info);
                        }
                        else
                        {
                            mCardAtendimentoAtual.Visible = false;
                        }
                    }
                }
                db.Database.Connection.Close();
            }

            //var ConsultasMarcada = this.agendaDAO.CarregarAgenda(DateTime.Now.ToString("dd/MM/yyyy"));

            //if (ConsultasMarcada != null)
            //    ConsultasMarcada.ForEach(x =>
            //    {
            //        if (x.data == DateTime.Now && x.Cancelado == 0)
            //        {
            //            if (Convert.ToDateTime(x.data) <= DateTime.Now && x.atendido != true)
            //            {
            //                mCardAtendimentoAtual.Visible = true;
            //                mlblNome.Text = x.paciente;
            //                mlblHorario.Text = x.data.ToString();
            //                if ((bool)x.retorno)
            //                {
            //                    mlblObservação.Text = "Retorno";
            //                }
            //                else
            //                {
            //                    mlblObservação.Text = "";
            //                }
            //                if ((bool)x.atendido)
            //                {
            //                    mCardAtendimentoAtual.BackColor = Color.LightGreen;
            //                }
            //                // NutreasyIconNotify.ShowBalloonTip(10, "Consulta atual", $"Você possui horário agora com: {x.paciente}", ToolTipIcon.Info);
            //            }
            //            else if (Convert.ToDateTime(x.data.ToString()) > DateTime.Now && x.Cancelado == 0)
            //            {
            //                if (Convert.ToDateTime(x.data.ToString()) > DateTime.Now)
            //                {
            //                    mCardAtendimentoFuturo.Visible = true;
            //                    mlblNomeFuturo.Text = x.paciente;
            //                    mlblHoraFutura.Text = x.data.ToString();
            //                    if ((bool)x.retorno)
            //                    {
            //                        mlblObservacaoFuturo.Text = "Retorno";
            //                    }
            //                    else
            //                    {
            //                        mlblObservacaoFuturo.Text = "";
            //                    }
            //                    if ((bool)x.atendido)
            //                    {
            //                        mCardAtendimentoFuturo.BackColor = Color.LightGreen;
            //                    }
            //                }
            //                else
            //                {
            //                    mCardAtendimentoFuturo.Visible = false;
            //                }
            //                //NutreasyIconNotify.ShowBalloonTip(10, "Consulta às {x.hora}", $"Você possui horário marcado com: {x.paciente} às {x.hora}", ToolTipIcon.Info);
            //            }
            //            else
            //            {
            //                mCardAtendimentoAtual.Visible = false;
            //            }
            //        }
            //    });
            //timer1.Enabled = true;
            //mCardConsultas.BackColor = mCardConsultas.BackColor == Color.Red ? Color.White : Color.Red;
        }
        #endregion

        #region Agenda
        private void tabAgenda_Enter(object sender, EventArgs e)
        {
            calAgendamento.Items.Clear();
            VerificarPermissao(tabAgenda.Text);
            GetConfigAtendimento();
            calAgendamento.ViewStart = RetornaInicioSemana(DateTime.Today);
            calAgendamento.ViewEnd = RetornaFimSemana(DateTime.Today);
            BuscarConsultasAgendadas();
            calAgendamento.Refresh();
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
            if (txtDataAgendamento.Text != "")
            {
                DateTime dt;
                DateTime.TryParseExact(txtDataAgendamento.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

                if (validarData(dt.ToString("dd/MM/yyyy")))
                {
                    txtDataAgendamento.Text = dt.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtDataAgendamento.Text = String.Empty;
                }
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
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Wednesday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Thursday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Friday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Saturday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                case DayOfWeek.Sunday:
                    if (TimeSpan.Compare(horario, configCalendar[0].StartTime) >= 0 && TimeSpan.Compare(configCalendar[0].EndTime, horario) > 0)
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            if (!ValidarAgendamento(Convert.ToDateTime(txtDataAgendamento.Text), Convert.ToString(txtHoraAgenda.Text)))
            {
                nMensagemAviso("Não é possível agendar uma consulta em um horário não disponível do nutricionista!");
                return;
            }
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
            BuscarConsultasAgendadas();

        }

        private void LimparCamposAgenda()
        {
            txtPacienteAgenda.Text = "";
            txtDataAgendamento.Text = "";
            txtHoraAgenda.Text = "";
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
            if (nMensagemAlerta($"Você deseja alterar o paciente {e.Item.Text} para {e.Item.StartDate}") == DialogResult.Yes)
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
            if (nMensagemAlerta($"Você deseja excluir a consulta do paciente {e.Item.Text}") == DialogResult.Yes)
            {
                agendaDAO.DeletarPacienteAgenda(e.Item.Text.ToString()
                    , (e.Item.StartDate.ToString()).Substring(0, 10)
                    , (e.Item.StartDate.ToString()).Substring(11, 5));
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
                FinalizarAtendimento(DateTime.Today.ToString(), mlblNomeFuturo.Text, mcbxAtendidoFuturo.Checked, temRetorno);
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
            agendaDAO.AtualizarPaciente(Convert.ToString(data.Substring(0, 10)), data.Substring(11), paciente, atendido, retorno, 1, true, Convert.ToString(usuarioDAO.getUsuario()));
        }

        private void FinalizarAtendimento(string data, string paciente, bool atendido, bool retorno)
        {
            agendaDAO.AtualizarPaciente(Convert.ToString(data.Substring(0, 10)), data.Substring(11), paciente, atendido, retorno, 0, true, Convert.ToString(usuarioDAO.getUsuario()));
        }

        private void calAgendamento_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void CalendarioMes_Click(object sender, EventArgs e)
        {
            DateTime dtInicio;
            DateTime.TryParseExact(CalendarioMes.SelectionStart.ToString("dd/MM/yyyy"),
                                   "dd/MM/yyyy",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None,
                                   out dtInicio);
            txtDataAgendamento.Text = CalendarioMes.SelectionStart.ToString("dd/MM/yyyy");

            calAgendamento.ViewStart = dtInicio;

            calAgendamento.ViewEnd = dtInicio.AddDays(5);

            BuscarConsultasAgendadas();
            GetConfigAtendimento();
        }

        private void BuscarConsultasAgendadas()
        {
            var agendados = agendaDAO.CarregarAgenda();
            if (agendados is null || agendados.Count == 0)
                return;

            //adicionar para pintar de outra cor o card, caso seja retorno.
            agendados.ForEach(x =>
            {
                CalendarItem calAgendamentos = new CalendarItem(calAgendamento, Convert.ToDateTime(x.data.ToString()), Convert.ToDateTime(x.data.ToString()).AddHours(1), x.paciente);
                calAgendamento.Items.Add(calAgendamentos);

                if (Convert.ToBoolean(x.retorno))
                    calAgendamento.BackColor = Color.LightYellow;
                else
                    calAgendamento.BackColor = Color.LightGreen;
            });
        }

        private void btnBuscarPacienteAgendamento_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAgenda.Text = CardapioDAO.nomePacienteCard;
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
            VerificarPermissao(tabAlimento.Text);
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

            var listaMedCaseira = medidaCaseiraDAO.Buscar(0);

            if (listaMedCaseira == null)
                return;

            foreach (MedidaCaseira medCaseira in listaMedCaseira)
                dtgSalvarMedCaseira.Rows.Add(medCaseira.codAlimento, medCaseira.Alimentos.nomeAlimento, medCaseira.descricao, medCaseira.qtd, medCaseira.Alimentos.nomeTabela);
        }

        private void dtgMedCaseiraAlimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            dtgSalvarMedCaseira.Rows.Add(dtgMedCaseiraAlimentos.CurrentRow.Cells["codAlimento"].Value, dtgMedCaseiraAlimentos.CurrentRow.Cells["nomeAlimento"].Value, "", "", dtgMedCaseiraAlimentos.CurrentRow.Cells["nomeTabela"].Value);

        }

        //private void btnAddMedCaseira_Click(object sender, EventArgs e)
        //{
        //    dtgSalvarMedCaseira.Rows.Add(txtCodAlimentoMedCas.Text,txtAlimentoMedCaseira.Text, txtDescMedCaseira.Text, txtQtdMedCas.Text);
        //    txtCodAlimentoMedCas.Text = "";
        //    txtAlimentoMedCaseira.Text = "";
        //    txtDescMedCaseira.Text = "";
        //    txtQtdMedCas.Text = "";
        //}

        private void btnSalvarMedCas_Click(object sender, EventArgs e)
        {
            medidaCaseiraDAO.Deletar();
            foreach (DataGridViewRow rows in dtgSalvarMedCaseira.Rows)
            {
                medidaCaseiraDAO.Salvar(rows.Cells["colDescricao"].Value.ToString(), Convert.ToDouble(rows.Cells["colQtd"].Value), Convert.ToInt32(rows.Cells["colCodAlimento"].Value));
            }
        }

        private void _tbConsulta_Enter(object sender, EventArgs e)
        {
            VerificarPermissao(tabAlimento.Text);
            tabAlimento_Enter(sender, e);
        }

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (cbxTabela.Text != "" && txtAlimentoFiltro.Text != "")
            {
                CarregarAlimentos(txtAlimentoFiltro.Text, cbxTabela.Text);
                return;
            }
        }

        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmWait wait = new frmWait();
            //wait.Show();
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
            //wait.Hide();
            return;

        }
        private void mCbxTabelasMedCas_SelectedValueChanged(object sender, EventArgs e)
        {
            dtgMedCaseiraAlimentos.DataSource = null;
            CarregarAlimentos("", "");
        }

        private void CarregarAlimentos(string nomeAlimento, string nomeTabela)
        {
            var listaAlimentos = alimentoDAO.Buscar(nomeAlimento, nomeTabela);
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

        private void mTxtFiltroAlimentoMedCas_Leave(object sender, EventArgs e)
        {
            if (mTxtFiltroAlimentoMedCas.Text != "")
            {
                CarregarAlimentos(mTxtFiltroAlimentoMedCas.Text, mCbxTabelasMedCas.Text);
                return;
            }
        }
        #endregion

        #region Paciente 
        private void tbPaciente_Enter(object sender, EventArgs e)
        {
            VerificarPermissao(tabPaciente.Text);
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
            string CPF = txtCPF.Text.Replace("-", "").Replace(".", "");
            string CEP = txtCEP.Text.Replace("-", "");
            pacienteDAO.Salvar(Convert.ToString(txtNome.Text), Convert.ToDouble(CPF), Convert.ToString(txtDtNasc.Text), Convert.ToString(txtEmail.Text), Convert.ToDouble(CEP),
                            Convert.ToDouble(txtNumero.Text), Convert.ToString(txtTelefone.Text), Convert.ToString(txtCelular.Text), Convert.ToString(txtEndereco.Text), Convert.ToString(txtBairro.Text)
                            , Convert.ToString(txtMunicipio.Text), Convert.ToString(txtUF.Text), Convert.ToString(txtComplemento.Text), this.vetorImagens);
            LimparCamposPaciente();
            tbCadastro_Enter(sender, e);
        }

        private void LimparCamposPaciente()
        {
            txtCodPaciente.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtDtNasc.Text = "";
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

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            if (txtPeso.Text != "" && txtAltura.Text != "")
                CalcularIMC(Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtAltura.Text));
        }

        private void CalcularIMC(double peso, double altura)
        {
            double imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            imc = (peso / (altura * altura));

            if (imc <= 18.5)
            {
                lblIMC.Text = ("Peso abaixo do normal.");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                lblIMC.Text = ("Peso normal.");
            }
            else if ((imc >= 25) && (imc < 30))
            {
                lblIMC.Text = ("Sobrepeso.");
            }
            else if ((imc >= 30) && (imc < 35))
            {
                lblIMC.Text = ("Grau de Obesidade I.");
            }
            else if ((imc >= 35) && (imc < 40))
            {
                lblIMC.Text = ("Grau de Obesidade II.");
            }
            else if (imc >= 40)
            {
                lblIMC.Text = ("Obesidade Grau III ou Mórbida.");
            }
        }
        private void btnFindPacienteAnamnese_Click(object sender, EventArgs e)
        {
            btnPacienteCardapio_Click(sender, e);
            txtPacienteAnamnese.Text = CardapioDAO.nomePacienteCard;
        }
        private void txtUF_Leave(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void btnPacAnt_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAntro.Text = CardapioDAO.nomePacienteCard;
        }

        private void btnSalvarAnamnese_Click(object sender, EventArgs e)
        {
            anamneseDAO.Salvar(Convert.ToInt32(CardapioDAO.codPacienteCard), Convert.ToString(rtxtAnamnese.Text));
        }

        private void txtDtNasc_Leave(object sender, EventArgs e)
        {
            try
            {
                txtDtNasc.Text = Regex.Replace(txtDtNasc.Text, @"(\d{2}\/\d{2}\/\d{4})", "dd/MM/yyyy");
            }
            catch { }
        }

        private void btnSalvarAntro_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CardapioDAO.codPacienteCard) == 0)
            {
                nMensagemAlerta("É necessário informar o paciente");
                return;
            }

            antropometriaDAO.Salvar(Convert.ToInt32(CardapioDAO.codPacienteCard),
                Convert.ToDouble(txtAltura.Text),
                Convert.ToDouble(txtAntebraco.Text),
                Convert.ToDouble(txtBraco.Text),
                Convert.ToDouble(txtCintura.Text),
                Convert.ToDouble(txtCoxa.Text),
                Convert.ToDouble(txtPanturrilha.Text),
                Convert.ToDouble(txtPeso.Text),
                Convert.ToDouble(txtPunho.Text),
                Convert.ToDouble(txtQuadril.Text),
                Convert.ToDouble(txtTorax.Text));
        }
        #endregion

        #region Cardápio
        //Ao invés de colocar medida caseira, para finalizar o básico do projeto, será possível apenas colocar quantidade em gramas. O gráfico irá carregar após 
        //informar a quantidade em gramas (evento sair da célula) apenas. Posteriormente, como ajustes será implementado medidas caseiras.
        private void tbCardapio_Enter(object sender, EventArgs e)
        {
            VerificarPermissao(tabCardapio.Text);
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
            if (!String.IsNullOrEmpty(txtPacienteConsultaCardapio.Text))
            {
                cardapioDAO.Deletar();
                trwDadosCard.Nodes.Clear();
                trwDadosCard.Columns.Clear();
                trwDadosCard.Refresh();
                txtPacienteConsultaCardapio_TextChanged(sender, e);
            }
        }
        private void btnAddAliCard_Click(object sender, EventArgs e)
        {
            if (cbxRefeicao.Text == "")
            {
                MessageBox.Show("É necessário informar a refeição.");
                return;
            }

            double proteina = 0;
            double carboidrato = 0;
            double lipidio = 0;
            double kcal = 0;
            List<DataGridViewRow> linhaAdicionada = new List<DataGridViewRow>();

            if (dtgCardapioAlimentos.SelectedRows.Count >= 1 || dtgCardapioAlimentos.SelectedCells.Count >= 1)
            {
                foreach (DataGridViewRow row in dtgCardapioAlimentos.Rows)
                    if (row.Selected == true || row.Cells["nomeAlimento"].Selected)
                    {

                       var linha = dtgRefeicoes.Rows.Add(row.Cells["codAlimento"].Value
                            , row.Cells["nomeAlimento"].Value
                            , 100
                            , row.Cells["kcal"].Value
                            , row.Cells["prot"].Value
                            , row.Cells["carbo"].Value
                            , row.Cells["lipidio"].Value);
                        //linhaAdicionada = Adicionar(row);
                        //dtgRefeicoes.Rows.Add(linhaAdicionada);
                        kcal += Convert.ToDouble(row.Cells[2].Value);
                        proteina += Convert.ToDouble(row.Cells["prot"].Value);
                        carboidrato += Convert.ToDouble(row.Cells["carbo"].Value);
                        lipidio += Convert.ToDouble(row.Cells["lipidio"].Value);
                        linhaAdicionada.Add(dtgRefeicoes.Rows[linha]);
                        dtgRefeicoes.Rows[linha].Visible = false;

                    }

                if(linhaAdicionada != null || linhaAdicionada.Count > 0)
                foreach (var linhaIndex in linhaAdicionada)
                {
                    if (proteina > Convert.ToDouble(txtProteina.Text))
                    {
                        nMensagemAlerta("A proteína atingiu o limite configurado!");
                        dtgRefeicoes.Rows.Remove(linhaIndex);
                        return;
                    }
                    else if (carboidrato > Convert.ToDouble(txtCarboidrato.Text))
                    {
                        nMensagemAlerta("O carboidrato atingiu o limite configurado!");
                        dtgRefeicoes.Rows.Remove(linhaIndex);
                        return;
                    }
                    else if (lipidio > Convert.ToDouble(txtLipidio.Text))
                    {
                        nMensagemAlerta("O lipídio atingiu o limite configurado!");
                        dtgRefeicoes.Rows.Remove(linhaIndex);
                        return;
                    }
                    dtgRefeicoes.Rows[linhaIndex.Index].Visible = true;
                }
                dtgRefeicoes.Visible = true;

                foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                {
                    var medCaseiraItens = medidaCaseiraDAO.Buscar(Convert.ToInt32(row.Cells["codAlimento"].Value));

                    if (medCaseiraItens is null)
                        continue;

                    foreach (var teste in medCaseiraItens)
                    {
                        if (Convert.ToDouble(row.Cells["codAlimento"].Value) == Convert.ToDouble(teste.codAlimento))
                        {
                            cbxMedCaseira.Items.Add(teste.descricao);
                            row.Cells["cbxMedCaseira"].Value = teste.descricao;
                            row.Cells["qtd"].Value = teste.qtd;
                        }
                    }

                }
                dtgRefeicoes.AutoResizeColumns();
            }

            lblVlrKcal.Visible = true;
            lblValorKcal.Text = kcal.ToString("N2") + " Kcal";
            CarregarGrafico(proteina, carboidrato, lipidio);
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

        private DataGridViewRow Adicionar(DataGridViewRow row)
        {
            if (dtgRefeicoes.Columns.Count == 0)
            {

                DataGridViewComboBoxColumn colunaMedidaCaseira = new DataGridViewComboBoxColumn();
                colunaMedidaCaseira.HeaderText = "TATATATATA";
                colunaMedidaCaseira.Name = "medCaseira";

                dtgRefeicoes.Columns.Add("codAlimento", "codAlimento");
                dtgRefeicoes.Columns.Add("nomeAlimento", "Alimento");
                dtgRefeicoes.Columns.Add("kcal", "KCal");
                dtgRefeicoes.Columns.Add("qtd", "Qtd");
                dtgRefeicoes.Columns.Add("prot", "Prot");
                dtgRefeicoes.Columns.Add("carbo", "Carbo");
                dtgRefeicoes.Columns.Add("lipidio", "Lipidio");
                dtgRefeicoes.Columns.Add("nomeTabela", "nomeTabela");
                dtgRefeicoes.Columns.Add("obs", "Observação");
                dtgRefeicoes.Columns.Add(colunaMedidaCaseira);
                dtgRefeicoes.Columns["codAlimento"].Visible = false;
                dtgRefeicoes.Columns["nomeAlimento"].HeaderText = "Alimento";
                dtgRefeicoes.Columns["kcal"].Visible = false;
                dtgRefeicoes.Columns["qtd"].Visible = true;
                dtgRefeicoes.Columns["prot"].Visible = false;
                dtgRefeicoes.Columns["carbo"].Visible = false;
                dtgRefeicoes.Columns["lipidio"].Visible = false;
                dtgRefeicoes.Columns["nomeTabela"].Visible = false;
            }

            DataGridViewRow newRow = (DataGridViewRow)row.Clone();

            DataGridViewComboBoxCell cellCbx = new DataGridViewComboBoxCell();

            var medCaseiraItens = medidaCaseiraDAO.Buscar(Convert.ToInt32(row.Cells["codAlimento"].Value));

            if (medCaseiraItens != null)
            {
                cellCbx.DataSource = null;

                medCaseiraItens.ForEach(x =>
                {
                    foreach (DataGridViewRow linha in dtgRefeicoes.Rows)
                    {
                        if (Convert.ToDouble(x.codAlimento) == Convert.ToDouble(dtgRefeicoes.Rows[linha.Index].Cells["codAlimento"].Value))
                        {
                            cellCbx = (DataGridViewComboBoxCell)linha.Cells["medCaseira"];
                            cellCbx.Items.Add(x.descricao);
                        }
                    }
                });
            }

            newRow.Cells[0].Value = row.Cells["codAlimento"].Value;
            newRow.Cells[1].Value = row.Cells["nomeAlimento"].Value;
            newRow.Cells[2].Value = row.Cells["kcal"].Value;
            newRow.Cells[3].Value = row.Cells["qtd"].Value;
            newRow.Cells[4].Value = row.Cells["prot"].Value;
            newRow.Cells[5].Value = row.Cells["carbo"].Value;
            newRow.Cells[6].Value = row.Cells["lipidio"].Value;

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
                                                    Convert.ToDouble(row.Cells["kcal"].Value),
                                                    Convert.ToString(usuarioDAO.getUsuario()));
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
            BuscadorPaciente();
            txtPaciente.Text = CardapioDAO.nomePacienteCard;
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
            txtPacienteConsultaCardapio.Text = CardapioDAO.nomePacienteCard;
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
                usuarioDAO.AlterarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmailConfig.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha, txtCRN.Text);
                tbConfig_Enter(sender, e);
            }
            else
            {
                usuarioDAO.CriarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNomeUsuarioConfig.Text, txtEmailConfig.Text, cbxSituacao.Text, cbxTipoUsuario.Text, txtCRN.Text);
                tbConfig_Enter(sender, e);
            }
        }
        private void tbConfig_Enter(object sender, EventArgs e)
        {
            VerificarPermissao(tabConfig.Text);
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
            dtgUsuarios.Columns["ConfiguracoesUsuarios"].Visible = false;
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
            var listaUsuarios = usuarioDAO.getUsuario("");
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
                return;
            cbxUsuarioPerm.Items.Clear();
            listaUsuarios.ForEach(x => cbxUsuarioPerm.Items.Add(x.usuario));

            var listaPermissao = permissaoDAO.getAllPermissao();
            if (listaPermissao == null || listaPermissao.Count <= 0)
                return;
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
            tbConfig_Enter(sender, e);

        }

        private void dtgUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                usuarioDAO.Deletar(Convert.ToString(dtgUsuarios.CurrentRow.Cells["usuario"].Value));
            }
        }

        private void tabHorarioAtendimento_Enter(object sender, EventArgs e)
        {
            var listaUsuarios = usuarioDAO.getUsuario("");
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
                return;
            cbxUsuarioPerm.Items.Clear();
            listaUsuarios.ForEach(x => cbxUsuNutri.Items.Add(x.usuario));

            var listConfig = configDAO.Consultar();
            if (listConfig == null)
                return;
            DataTable dt = ConvertToDataTable(listConfig);
            dtgConfigHorario.DataSource = dt;

            dtgConfigHorario.Columns["ID"].Visible = false;
            dtgConfigHorario.Columns["usuario"].HeaderText = "Usuário";
            dtgConfigHorario.Columns["diaSemana"].HeaderText = "Semana";
            dtgConfigHorario.Columns["horaInicio"].HeaderText = "Hora Início";
            dtgConfigHorario.Columns["horaFim"].HeaderText = "Hora Fim";
            dtgConfigHorario.Columns["Login"].Visible = false;

        }

        private void btnSalvarHoraAtend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxUsuNutri.Text)) { nMensagemAviso("Favor informar o usuário!"); return; }
            if (string.IsNullOrEmpty(cbxDiaSemana.Text)) { nMensagemAviso("Favor informar o dia da semana!"); return; }
            if (string.IsNullOrEmpty(txtHoraInicio.Text)) { nMensagemAviso("Favor informar a hora início!"); return; }
            if (string.IsNullOrEmpty(txtHoraFim.Text)) { nMensagemAviso("Favor informar a hora fim!"); return; }

            configDAO.Salvar(Convert.ToString(cbxUsuNutri.Text), Convert.ToString(cbxDiaSemana.Text), Convert.ToString(txtHoraInicio.Text), Convert.ToString(txtHoraFim.Text));
            CarregarConfigs();
        }

        private void CarregarConfigs()
        {
            var listaConfigs = configDAO.Consultar();
            if (listaConfigs == null)
                return;
            DataTable dt = ConvertToDataTable(listaConfigs);
            dtgConfigHorario.DataSource = dt;

            dtgConfigHorario.Columns["ID"].Visible = false;
            dtgConfigHorario.Columns["Login"].Visible = false;
            dtgConfigHorario.Columns["diaSemana"].HeaderText = "Semana";
            dtgConfigHorario.Columns["horaInicio"].HeaderText = "Início";
            dtgConfigHorario.Columns["horaFim"].HeaderText = "Fim";

            GetConfigAtendimento();
        }

        private void dtgConfigHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            cbxUsuarioPerm.SelectedText = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["usuario"].Value);
            cbxDiaSemana.SelectedText = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["diaSemana"].Value);
            txtHoraInicio.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["horaInicio"].Value);
            txtHoraFim.Text = Convert.ToString(dtgConfigHorario.CurrentRow.Cells["horaFim"].Value);
        }
        #endregion

        private void tbSobre_Enter(object sender, EventArgs e)
        {
            VerificarPermissao(tabAgenda.Text);
        }

        private void VerificarPermissao(string telaPermissao)
        {
            if (!permissaoDAO.VerificarPermissao(Convert.ToString(usuarioDAO.getUsuario()), telaPermissao))
            {
                nMensagemAviso("Você não possui permissão nessa tela!");
                TabControlNutreasy.SelectedTab = tabMenu;
                return;
            }
        }

        public static bool validarData(string data)
        {
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            return r.Match(data).Success;
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BuscadorPaciente()
        {
            frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this);
            buscaPacientes.ShowDialog();
        }

        private void calAgendamento_ItemsPositioned(object sender, EventArgs e)
        {

        }

        private void calAgendamento_ItemSelected(object sender, CalendarItemEventArgs e)
        {
            dataAgendadoAnterior = e.Item.StartDate;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            Deslogar(sender, e);
        }

        private void tabAgenda_Leave(object sender, EventArgs e)
        {
            calAgendamento.Items.Clear();
        }

        private void dtgRefeicoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            if (txtPacienteAntro.Text == "")
            {
                nMensagemAviso("É necessário primeiramente informar um pacietne para poder abrir a tela de gráficos.");
                return;
            }

            using (frmGraficoPaciente grafico = new frmGraficoPaciente(Convert.ToInt32(CardapioDAO.codPacienteCard), txtPacienteAntro.Text))
            {
                grafico.ShowDialog();
            }

        }
    }
}