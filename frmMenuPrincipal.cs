using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjetoTCC;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Collections.Generic;

namespace TCC2
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        public PacienteDAO pacienteDAO = new PacienteDAO();
        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        public AlimentoDAO alimentoDAO = new AlimentoDAO();
        public AgendaDAO agendaDAO = new AgendaDAO();
        private DataTableCollection tables;
        List<string> deletar = new List<string>();

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
            } else
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
            for (int i = 7; i <= 19; i++)
            {
                dtgAgenda.Rows.Add(i + ":00");
            }
        }

        private void dtgAgenda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgAgenda.AutoResizeColumns();

            if (dtgAgenda.Rows[e.RowIndex].Cells["nomePaciente"].Value == "")
                dtgAgenda.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

            dtgAgenda.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Tomato;
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(Convert.ToDateTime(lblDataAtual.Text), DateTime.Now);

            if (result != -1)
            {
                MessageBox.Show(this, "Não é possível agendar consulta em datas passadas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadAgenda();
                return;
            }
            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {
                bool atendido = true;
                bool retorno = true;
                if (row.DefaultCellStyle.BackColor == Color.Tomato)
                {
                    if (row.Cells["atendido"].Value == null)
                    {
                        atendido = false;
                    }
                    if (row.Cells["retorno"].Value == null)
                    {
                        retorno = false;
                    }
                    agendaDAO.AdicionarPaciente(
                        lblDataAtual.Text,
                        row.Cells["horario"].Value.ToString(),
                        row.Cells["nomePaciente"].Value.ToString(),
                        atendido,
                        retorno);
                }
            }
            if (deletar.Count > 0)
            {
                agendaDAO.DeletarPacienteAgenda(deletar);
            }
            LoadAgenda();
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
            foreach (DataGridViewRow row in dtgConAlimento.Rows)
            {
                double ProteinaGramas;
                double ProteinaKcal;
                ProteinaGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["proteina"].Value), row.Cells["qtde"].Value));
                ProteinaKcal = ProteinaGramas * 4d;
                row.Cells["proteina"].Value = ProteinaGramas.ToString("N2");

                double CarboidratoGramas;
                double CarboidratoKcal;
                CarboidratoGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["carboidrato"].Value), row.Cells["qtde"].Value));
                CarboidratoKcal = CarboidratoGramas * 4d;
                row.Cells["carboidrato"].Value = CarboidratoGramas.ToString("N2");

                double LipidioGramas;
                double LipidioKcal;
                LipidioGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["lipidio"].Value), row.Cells["qtde"].Value));
                LipidioKcal = LipidioGramas * 9d;
                row.Cells["lipidio"].Value = LipidioGramas.ToString("N2");

                double somaTotalCaloria;
                somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal;

                row.Cells["kcal"].Value = somaTotalCaloria.ToString("N2");

                double calcio;
                calcio = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["calcio"].Value, row.Cells["qtde"].Value));
                row.Cells["calcio"].Value = calcio.ToString("N2");

                double ferro;
                ferro = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["ferro"].Value, row.Cells["qtde"].Value));
                row.Cells["ferro"].Value = ferro.ToString("N2");

                double VitaminaC;
                VitaminaC = Conversions.ToDouble(Operators.MultiplyObject(row.Cells["vitC"].Value, row.Cells["qtde"].Value));
                row.Cells["vitC"].Value = VitaminaC.ToString("N2");
            }
        }

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (cbxTabela.Text != "")
            {
                if (txtAlimentoFiltro.Text != "")
                {
                    alimentoDAO.Buscar(dtgConAlimento, txtAlimentoFiltro.Text, cbxTabela.Text);
                    return;
                }
                else
                {
                    alimentoDAO.Buscar(dtgConAlimento, "", cbxTabela.Text);
                    return;
                }
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
            //if (VerificarExisteTabela(txtNomeTabela.Text))
            //{
            //    if (Interaction.MsgBox("Esta tabela já existe, Deseja apagar?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
            //    {
            //        ExcluirTabela(txtNomeTabela.Text);
            //    }
            //    return;
            //}
            
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
            var dt = tables[_cbxNomePlanilha.SelectedItem.ToString().Replace(",",".")];
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
                        Interaction.MsgBox(ex.Message);
                    }

                }
            }
        }
        #endregion

        #region CadastroPaciente 
        private void _btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            tbConsultaPaciente.Show();
        }
        private void buscarEndCep(string CEP)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($@"https://viacep.com.br/ws/{CEP}/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
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

        private void btnSearchPatient_Click_1(object sender, EventArgs e)
        {
            pacienteDAO.Buscar(dtgDados, txtNome.Text);
        }

        private void limparCamposCadPaciente()
        {
            txtCodPaciente.Text = "";
            _txtNomePaciente.Text = "";
            txtCPF.Text = "";
            txtDtNasc.Text = "";
            txtEmail.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
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
            pacienteDAO.Buscar(_dtgConsultaPacientes, _txtNomePaciente.Text);
        }

        private void btnSalvarCardapio_Click(object sender, EventArgs e)
        {
            tbConsultaPaciente.Show();
        }
        private void txtCEP_Leave(object sender, EventArgs e)
        {
            buscarEndCep(txtCEP.Text);
        }
        private void _btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPaciente.Text))
            {
                pacienteDAO.Deletar(Conversions.ToInteger(txtCodPaciente.Text));
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
                txtCodPaciente.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                _txtNomePaciente.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCPF.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtDtNasc.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtEmail.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtPeso.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtAltura.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCEP.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtNumero.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtComplemento.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtTelefone.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                txtCelular.Text = Conversions.ToString(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value);
                buscarEndCep(_dtgConsultaPacientes.Rows[e.RowIndex].Cells[""].Value.ToString());
                tbPaciente.SelectedTab = tbCadastro;
            }
        }
        #endregion

        #region Cardápio

        private void tabCardapio_Enter(object sender, EventArgs e)
        {
            CarregarColunas();
            //efetuar cálculo, onde 100% é kCal X e desse valor tirar as porcentagens para montar o gráfico
            //GraficoProtChoLip.Series[0].Points.AddXY("Carboidrato", 25);
            //GraficoProtChoLip.Series[0].Points.AddXY("Lipídio", 25);
            //GraficoProtChoLip.Series[0].Points.AddXY("Proteina", 50);
        }

        private void CarregarColunas()
        {
            if (dtgRefeicoes.ColumnCount <= 0)
            {
                dtgRefeicoes.Columns.Add("refeicao", "Refeição"); // Vai buscar a descrição salva na tela PlanilhaCardapio
                dtgRefeicoes.Columns.Add("alimento", "Alimento");
                dtgRefeicoes.Columns.Add("qtde", "Quantidade");
                dtgRefeicoes.Columns.Add("hora", "Horário");
            }
        }

        private void _btnAdicionar_Click(object sender, EventArgs e)
        {
            // var frmAddRefeicao = new frmAdicionarRefeição();
            //  frmAddRefeicao.Show();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            // var frmBuscaPaciente = new frmBuscarPaciente();
            //frmBuscarPaciente.Show();
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

    }
}
