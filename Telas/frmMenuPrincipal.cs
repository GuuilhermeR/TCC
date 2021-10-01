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
using static Classes.HelperFuncoes;
using System.Windows.Forms.Calendar;
using TCC2.Telas;
using TCC2.DAO;
using System.Globalization;
using Aspose.Cells;
using TCC2.Properties;
using System.Threading;
using Model;

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
        public DateTime dataAgendadoAnterior;
        public bool jaIniciou = false;
        private bool primeiraVez = true;
        private DateTime dataHoraNotif = DateTime.Now;
        #endregion

        #region Menu
        public FrmMenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            usuarioDAO.setNomeUsuario(usuarioLogado);
            var OpcoesMenu = new ContextMenu();
            OpcoesMenu.MenuItems.Add(new MenuItem("Deslogar", Deslogar));
            OpcoesMenu.MenuItems.Add(new MenuItem("Fechar", FecharAplicacao));
            NutriEzIconNotify.ContextMenu = OpcoesMenu;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            FormatView(this);

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

        private void CarregarCardConsultas()
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
                    if (Convert.ToDateTime(dr["data"]) <= DateTime.Now || (int)dr["Cancelado"] == 1 || (bool)dr["atendido"] == true)
                    {
                        return;
                    }

                    //if (mlblNome.Text != "Nome" || mlblNomeFuturo.Text != "Nome")
                    //    return;

                    if ((DateTime)dr["data"] <= DateTime.Now && (bool)dr["atendido"] != true && (int)dr["Cancelado"] == 0)
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
                    }

                    if ((DateTime)dr["data"] >= DateTime.Now && (bool)dr["atendido"] != true && (int)dr["Cancelado"] == 0)
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
            if (!VerificarPermissao(tabAgenda.Text))
            {
                return;
            };
            loadStart();

            if (!jaIniciou)
            {
                calAgendamento.Items.Clear();
                GetConfigAtendimento();
                calAgendamento.ViewStart = RetornaInicioSemana(DateTime.Today);
                calAgendamento.ViewEnd = RetornaFimSemana(DateTime.Today);
                BuscarConsultasAgendadas();
                calAgendamento.Refresh();
            }
            loadStop();

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

            CarregarCardConsultas();
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

            CarregarCardConsultas();
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

            CarregarCardConsultas();
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

            CarregarCardConsultas();
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

        //private void CalendarioMes_Click(object sender, EventArgs e)
        //{
        //    DateTime dtInicio;
        //    DateTime.TryParseExact(CalendarioMes.SelectionStart.ToString("dd/MM/yyyy"),
        //                           "dd/MM/yyyy",
        //                           CultureInfo.InvariantCulture,
        //                           DateTimeStyles.None,
        //                           out dtInicio);
        //    txtDataAgendamento.Text = CalendarioMes.SelectionStart.ToString("dd/MM/yyyy");

        //    calAgendamento.ViewStart = dtInicio;

        //    calAgendamento.ViewEnd = dtInicio.AddDays(5);

        //    BuscarConsultasAgendadas();
        //    GetConfigAtendimento();
        //}
        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dtInicio;
            DateTime.TryParseExact(mCalendar.SelectionStart.ToString("dd/MM/yyyy"),
                                   "dd/MM/yyyy",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None,
                                   out dtInicio);
            txtDataAgendamento.Text = mCalendar.SelectionStart.ToString("dd/MM/yyyy");

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

                jaIniciou = true;
            });
        }

        private void btnBuscarPacienteAgendamento_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPacienteAgenda.Text = PacienteModel.nomePacienteCard;
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
                    lblVlrKcal.Text = Convert.ToString(somaTotalCaloria);
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

            loadStart();
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
            loadStop();
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

        private void _cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
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
            loadStart();

            medidaCaseiraDAO.Deletar();
            foreach (DataGridViewRow rows in dtgSalvarMedCaseira.Rows)
            {
                medidaCaseiraDAO.Salvar(rows.Cells["colDescricao"].Value.ToString(), Convert.ToDouble(rows.Cells["colQtd"].Value), Convert.ToInt32(rows.Cells["colCodAlimento"].Value));
            }

            loadStop();
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
            CarregarAlimentos("", "", dtgMedCaseiraAlimentos);
            dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
            dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
        }

        private void CarregarAlimentos(string nomeAlimento, string nomeTabela, DataGridView dtg)
        {
            loadStart();
            var listaAlimentos = alimentoDAO.Buscar(nomeAlimento, nomeTabela);
            if (listaAlimentos == null)
            {
                loadStop();
                return;
            }
            DataTable dt = ConvertToDataTable(listaAlimentos);
            dtg.DataSource = dt;

            dtg.Columns["codAlimento"].Visible = false;
            dtg.Columns["qtd"].HeaderText = "Quantidade";
            dtg.Columns["kcal"].HeaderText = "KCal";
            dtg.Columns["prot"].HeaderText = "Proteína";
            dtg.Columns["carbo"].HeaderText = "Carboidrato";
            dtg.Columns["lipidio"].HeaderText = "Lipídio";
            dtg.Columns["MedidaCaseira"].Visible = false;
            dtg.Columns["Cardapio"].Visible = false;
            dtg.Columns["nomeTabela"].HeaderText = "Tabela";
            dtg.Columns["nomeAlimento"].HeaderText = "Alimento";

            dtg.AutoResizeColumns();
            loadStop();
        }

        private void mTxtFiltroAlimentoMedCas_Leave(object sender, EventArgs e)
        {
            if (mTxtFiltroAlimentoMedCas.Text != "")
            {
                CarregarAlimentos(mTxtFiltroAlimentoMedCas.Text, mCbxTabelasMedCas.Text, dtgMedCaseiraAlimentos);
                dtgMedCaseiraAlimentos.Columns["qtd"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["kcal"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["prot"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["carbo"].Visible = false;
                dtgMedCaseiraAlimentos.Columns["lipidio"].Visible = false;
                return;
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
                loadStart();
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
                loadStop();
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
            cbxCarregarTemplate.Text = "";
        }
        private void txtPacienteAnamnese_TextChanged(object sender, EventArgs e)
        {
            loadStart();
            var listaCardapio = anamneseDAO.CarregarDataAnamnese(Convert.ToInt32(PacienteModel.codPacienteCard));

            if (listaCardapio == null || listaCardapio.Count == 0)
            {
                cbxDataAnamnese.Visible = false;
                loadStop();
                return;
            }

            cbxDataAnamnese.Visible = true;

            listaCardapio.ForEach(x =>
            {
                cbxDataAnamnese.Items.Add(x);
            });
            loadStop();
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
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                nMensagemAviso("Necessário informar pelo menos o nome!");
                return;
            }
            loadStart();
            string CPF = txtCPF.Text.Replace("-", "").Replace(".", "");
            string CEP = txtCEP.Text.Replace("-", "");
            pacienteDAO.Salvar(Convert.ToString(txtNome.Text), Convert.ToDouble(CPF), Convert.ToString(txtDtNasc.Text), Convert.ToString(txtEmail.Text), Convert.ToDouble(CEP),
                            Convert.ToDouble(txtNumero.Text), Convert.ToString(txtTelefone.Text), Convert.ToString(txtCelular.Text), Convert.ToString(txtEndereco.Text), Convert.ToString(txtBairro.Text)
                            , Convert.ToString(txtMunicipio.Text), Convert.ToString(txtUF.Text), Convert.ToString(txtComplemento.Text), this.vetorImagens);
            LimparCamposPaciente();
            loadStop();
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
            loadStart();

            btnCapturarImagem.Visible = false;
            _dtgConsultaPacientes.DataSource = null;
            var listaPacientes = pacienteDAO.Buscar("");

            if (listaPacientes == null)
            {
                loadStop();
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

            loadStop();
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
            if (txtPeso.Text != "" && txtAltura.Text != "")
                CalcularIMC(Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtAltura.Text));
        }

        private void CalcularIMC(double peso, double altura)
        {
            double imc;

            peso = Math.Round(Convert.ToDouble(txtPeso.Text));
            altura = Math.Round(Convert.ToDouble(txtAltura.Text));

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
            txtPacienteAnamnese.Text = PacienteModel.nomePacienteCard;
        }
        private void txtUF_Leave(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void btnPacAnt_Click(object sender, EventArgs e)
        {
            loadStart();
            BuscadorPaciente();
            txtPacienteAntro.Text = PacienteModel.nomePacienteCard;
            loadStop();
        }

        private void btnSalvarAnamnese_Click(object sender, EventArgs e)
        {
            anamneseDAO.Salvar(Convert.ToInt32(PacienteModel.codPacienteCard), Convert.ToString(rtxtAnamnese.Text));
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
            if (Convert.ToInt32(PacienteModel.codPacienteCard) == 0)
            {
                nMensagemAlerta("É necessário informar o paciente");
                return;
            }

            antropometriaDAO.Salvar(Convert.ToInt32(PacienteModel.codPacienteCard),
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

            ClearCamposAntro();
        }

        private void ClearCamposAntro()
        {
            txtPacienteAntro.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtAntebraco.Text = string.Empty;
            txtBraco.Text = string.Empty;
            txtCintura.Text = string.Empty;
            txtCoxa.Text = string.Empty;
            txtPanturrilha.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtPunho.Text = string.Empty;
            txtQuadril.Text = string.Empty;
            txtTorax.Text = string.Empty;
        }

        private void BuscadorPaciente()
        {
            frmBuscarPaciente buscaPacientes = new frmBuscarPaciente(this);
            buscaPacientes.ShowDialog();
        }

        private void dtgRefeicoes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
            {
                RecalcularMacroNutrientes(dtgRefeicoes, Convert.ToDecimal(row.Cells[qtd.Index].Value));
                CarregarGrafico(Convert.ToDouble(row.Cells[prot.Index].Value), Convert.ToDouble(row.Cells[carbo.Index].Value), Convert.ToDouble(row.Cells[lipidio.Index].Value));
            }
        }
        #endregion

        #region Cardápio
        //Ao invés de colocar medida caseira, para finalizar o básico do projeto, será possível apenas colocar quantidade em gramas. O gráfico irá carregar após 
        //informar a quantidade em gramas (evento sair da célula) apenas. Posteriormente, como ajustes será implementado medidas caseiras.
        private void tbCardapio_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tabCardapio.Text))
            {
                return;
            };
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
            if (cbxRefeicao.Text == "")
            {
                MessageBox.Show("É necessário informar a refeição.");
                return;
            }

            double proteina = 0;
            double carboidrato = 0;
            double lipidio = 0;
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
                        proteina += Convert.ToDouble(row.Cells["prot"].Value);
                        carboidrato += Convert.ToDouble(row.Cells["carbo"].Value);
                        lipidio += Convert.ToDouble(row.Cells["lipidio"].Value);
                        linhaAdicionada.Add(dtgRefeicoes.Rows[linha]);
                        dtgRefeicoes.Rows[linha].Visible = false;
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

                    foreach (var teste in medCaseiraItens)
                    {
                        if (Convert.ToDouble(row.Cells["codAlimento"].Value) == Convert.ToDouble(teste.codAlimento))
                        {
                            DataGridViewComboBoxCell comboCell = dtgRefeicoes.Rows[row.Index].Cells[cbxMedCaseira.Index] as DataGridViewComboBoxCell;

                            comboCell.Items.Add(teste.descricao);
                            row.Cells["cbxMedCaseira"].Value = teste.descricao;
                            row.Cells["qtd"].Value = teste.qtd;
                        }
                    }

                }
                dtgRefeicoes.AutoResizeColumns();
            }

            lblVlrKcal.Visible = true;
            if (dtgRefeicoes.Rows.Count > 0)
            {
                RecalcularMacroNutrientes(dtgConAlimento, quantidadeSalva);
                CarregarGrafico(proteina, carboidrato, lipidio);
            }

        }

        private void txtPacienteConsultaCardapio_TextChanged(object sender, EventArgs e)
        {
            if (PacienteModel.codPacienteCard == "")
                return;

            var listaCardapio = cardapioDAO.ConsultarDataConsultas(Convert.ToInt32(PacienteModel.codPacienteCard));

            if (listaCardapio == null)
            {
                cbxDataConsulta.Visible = false;
                return;
            }
            else if (listaCardapio.Count == 0)
            {
                cbxDataConsulta.Visible = false;
                return;
            }

            cbxDataConsulta.Visible = true;
            listaCardapio.ForEach(x =>
            {
                cbxDataConsulta.Items.Add(x);
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
            loadStart();

            double Kcal = Convert.ToDouble(lblValorKcal.Text.Split(' ')[0]);

            bool Update = Convert.ToBoolean(cardapioDAO.Consultar(Convert.ToInt32(PacienteModel.codPacienteCard), txtDataCardapio.Text).Count > 0);

            foreach (DataGridViewRow row in dtgRefeicoes.Rows)
                cardapioDAO.Salvar(Convert.ToInt32(PacienteModel.codPacienteCard),
                                                    Convert.ToInt32(row.Cells["codAlimento"].Value),
                                                    Convert.ToString(cbxRefeicao.Text),
                                                    Convert.ToInt32(row.Cells["qtd"].Value),
                                                    Convert.ToString(row.Cells["obs"].Value),
                                                    Convert.ToDouble(row.Cells["kcal"].Value),
                                                    Convert.ToString(usuarioDAO.getUsuario()),
                                                    txtDataCardapio.Text,
                                                    Update);

            btnApagar_Click(sender, e);
            btnCancelarCardapio_Click(sender, e);
            loadStop();
        }

        private void btnPacienteCardapio_Click(object sender, EventArgs e)
        {
            BuscadorPaciente();
            txtPaciente.Text = PacienteModel.nomePacienteCard;
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

        private void dtgRefeicoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgRefeicoes.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
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
            txtPacienteConsultaCardapio.Text = PacienteModel.nomePacienteCard;
        }

        private void dtgRefeicoes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value) != 0)
                quantidadeAntigaCardapio = Convert.ToDouble(dtgRefeicoes.CurrentRow.Cells["qtd"].Value);

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            dtgRefeicoes.DataSource = null;
            graficoMacroNutri.Series = null;
            txtPaciente.Text = null;
            cbxRefeicao.Text = null;
            lblValorKcal.Text = null;
            cbxTabelaAlimentoCardapio.SelectedIndex = -1;
            PacienteModel.codPacienteCard = null;
            PacienteModel.nomePacienteCard = null;
            txtPacienteConsultaCardapio.Clear();
            trwDadosCard.Nodes.Clear();
        }

        private void cbxTabelaAlimentoCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTabelaAlimentoCardapio.Text != "")
            {
                loadStart();

                var listaAlimentos = alimentoDAO.Buscar("", cbxTabelaAlimentoCardapio.Text);
                if (listaAlimentos == null)
                {
                    loadStop();
                    return;
                }


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
                loadStop();

            }
        }
        private void btnCancelarCardapio_Click(object sender, EventArgs e)
        {
            txtPaciente.Text = "";
            PacienteModel.codPacienteCard = "";
            PacienteModel.nomePacienteCard = "";
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

        private void cbxDataConsulta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxDataConsulta.Text))
            {
                nMensagemAviso("Selecionar uma data para o carregamento das informações do cardápio!");
                return;
            }
            loadStart();
            var listaCardapio = cardapioDAO.Consultar(Convert.ToInt32(PacienteModel.codPacienteCard), Convert.ToString(cbxDataConsulta.Text));
            if (listaCardapio == null)
            {
                loadStop();
                return;
            }
            else if (listaCardapio.Count == 0)
            {
                loadStop();
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
                dtgCardGrid.Rows.Add(card.Refeicao, card.Alimentos.nomeAlimento, card.medidaCaseiraQtde, card.kcal, card.Obs);
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
            loadStop();
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            if (txtPacienteAntro.Text == "")
            {
                nMensagemAviso("É necessário primeiramente informar um paciente para visualizar evolução gráfica!");
                return;
            }

            using (frmGraficoPaciente grafico = new frmGraficoPaciente(Convert.ToInt32(PacienteModel.codPacienteCard), txtPacienteAntro.Text))
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
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(new System.IO.MemoryStream(Resources.ImpressaoCardapio));
            //var worksheet = workbook.Worksheets();

        }
        private void txtDataCardapio_Leave(object sender, EventArgs e)
        {
            if (txtDataCardapio.Text == "")
            {
                txtDataCardapio.Text = FormatDate(DateTime.Now.ToString("dd/MM/yyyy"));
            }
            else
            {
                txtDataCardapio.Text = FormatDate(txtDataCardapio.Text);
            }
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
            if (!VerificarPermissao(tabConfig.Text))
            {
                return;
            };
            loadStart();

            var listaUsuario = usuarioDAO.getUsuario("");
            if (listaUsuario == null)
            {
                loadStop();
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
            dtgUsuarios.AutoResizeColumns();
            loadStop();
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
            loadStart();

            var listaUsuarios = usuarioDAO.getUsuario("");
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
            {
                loadStop();
                return;
            }

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
            loadStop();
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
            loadStart();
            usuarioDAO.Deletar(txtUsuarioConfig.Text);
            loadStop();
            tbConfig_Enter(sender, e);
        }

        private void dtgUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                loadStart();
                usuarioDAO.Deletar(Convert.ToString(dtgUsuarios.CurrentRow.Cells["usuario"].Value));
                loadStop();
            }
        }

        private void tabHorarioAtendimento_Enter(object sender, EventArgs e)
        {

            loadStart();
            var listaUsuarios = usuarioDAO.getUsuario("");
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
            {
                loadStop();
                return;
            }

            cbxUsuarioPerm.Items.Clear();
            listaUsuarios.ForEach(x => cbxUsuNutri.Items.Add(x.usuario));

            var listConfig = configDAO.Consultar();
            if (listConfig == null)
            {
                loadStop();
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
            loadStop();
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
            loadStart();
            var listaConfigs = configDAO.Consultar();
            if (listaConfigs == null)
            {
                loadStop();
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
            loadStop();

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
        private void txtHoraInicio_Validated(object sender, EventArgs e)
        {
            txtHoraInicio.Text = formatarHora(txtHoraInicio.Text);
        }

        private void txtHoraFim_Validated(object sender, EventArgs e)
        {
            txtHoraInicio.Text = formatarHora(txtHoraInicio.Text);
        }

        private void btnExcluirPerm_Click(object sender, EventArgs e)
        {
            permissaoDAO.RemoverPermissao(cbxUsuarioPerm.Text, cbxTelaLiberarPerm.Text);
        }

        private void dtgPermUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
                return;

            cbxUsuarioPerm.Text = dtgPermUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            cbxTelaLiberarPerm.Text = dtgPermUsuarios.Rows[e.RowIndex].Cells["programa"].Value.ToString();
        }
        #endregion

        private void tbSobre_Enter(object sender, EventArgs e)
        {
            if (!VerificarPermissao(tbSobre.Text))
            {
                return;
            };
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
            //calAgendamento.Items.Clear();
        }

        private void dtgRefeicoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnClearAntro_Click(object sender, EventArgs e)
        {
            ClearCamposAntro();
        }

    }
}