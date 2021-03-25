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

namespace TCC2
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        public PacienteDAO paciente = new PacienteDAO();
        public UsuarioDAO usuario = new UsuarioDAO();
        public AlimentoDAO alimento = new AlimentoDAO();
        public AgendaDAO agenda = new AgendaDAO();
        private DataTableCollection tables;

        public frmMenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            usuario.setNomeUsuario(usuarioLogado);
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);

            this.MaximizeBox = false;
            if (usuario.getNomeUsuario() != null || usuario.getNomeUsuario() != "")
            {
                lblUsuario.Text = $"Seja bem vindo(a) ao sistema {usuario.getNomeUsuario()}";
                lblUsuario.Visible = true;
            }
        }

        #region Agenda

        private void tabAgenda_Enter(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            lblDataAtual.Text = hoje.ToString("dd/MM/yyyy");
            CriarHorariosPadrao();
            dtgAgenda.AutoResizeColumns();
            dtgAgenda.AutoResizeRows();
            dtgAgenda.Refresh();

            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {              
                row.Cells["nomePaciente"].Value = agenda.CarregarAgenda(lblDataAtual.Text, row.Cells["horario"].Value.ToString());
            }
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            dtgAgenda.Rows.Clear();
            CriarHorariosPadrao();
            var data = Convert.ToDateTime(lblDataAtual.Text);
            DateTime dataAvançada = data.AddDays(1);
            lblDataAtual.Text = dataAvançada.ToString("dd/MM/yyyy");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtgAgenda.Rows.Clear();
            CriarHorariosPadrao();
            var data = Convert.ToDateTime(lblDataAtual.Text);
            DateTime dataAvançada = data.AddDays(-1);
            lblDataAtual.Text = dataAvançada.ToString("dd/MM/yyyy");
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
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(Convert.ToDateTime(lblDataAtual.Text), DateTime.Now);

            if (result < 0)
            {
                MessageBox.Show(this, "Não é possível agendar consulta datas passadas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dtgAgenda.Rows)
            {
                agenda.AdicionarPaciente(lblDataAtual.Text, row.Cells["horario"].Value.ToString(), row.Cells["nomePaciente"].Value.ToString());
            }

        }
        #endregion

        #region Alimento

        private bool VerificarExisteTabela(string nomeTabela)
        {
            bool existe = false;

            string strSQL = $@"SELECT COUNT(1) AS Existe FROM Alimento WHERE nomeTabela='{nomeTabela}'";


            return existe;
        }


        private void ExcluirTabela(string nomeTabela)
        {

            string strSQL = $@"DELETE FROM Alimento WHERE nomeTabela = '{nomeTabela}'";


        }

        private void CarregarTabelas()
        {
            string strSQL = string.Empty;
            strSQL = "SELECT nomeTabela FROM Alimento";

        }

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
                    alimento.Buscar(dtgConAlimento, txtAlimentoFiltro.Text, cbxTabela.Text);
                    return;
                }
                else
                {
                    alimento.Buscar(dtgConAlimento, "", cbxTabela.Text);
                    return;
                }
            }
        }

        private void tbAlimento_Enter(object sender, EventArgs e)
        {
            CarregarTabelas();
        }

        private void _btnImportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeTabela.Text))
            {
                Interaction.MsgBox("Favor informar o nome da tabela que está sendo salvo!");
                return;
            }
            if (VerificarExisteTabela(txtNomeTabela.Text))
            {
                if (Interaction.MsgBox("Esta tabela já existe, Deseja apagar?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    ExcluirTabela(txtNomeTabela.Text);
                }
                return;
            }

            pbCarregando.Visible = true;
            pbCarregando.Value = 0;

            SQLiteCommand cmd;
            cmd = new SQLiteCommand();

            try
            {
                foreach (DataGridViewRow row in dtgDados.Rows)
                {
                    pbCarregando.PerformStep();
                    string alimento = row.Cells["ALIMENTO"].Value.ToString();
                    if (alimento.Contains("'"))
                    {
                        alimento.Replace("'", "''");
                    }
                    var qtde = row.Cells["PL"].Value.ToString();
                    var proteina = row.Cells["Prot"].Value.ToString();
                    var carboidrato = row.Cells["Carb"].Value.ToString();
                    var lipidio = row.Cells["Lipidio"].Value.ToString();
                    var Ca = row.Cells["Ca"].Value.ToString();
                    var Fe = row.Cells["Fe"].Value.ToString();
                    var B1 = row.Cells["B1"].Value.ToString();
                    var B2 = row.Cells["B2"].Value.ToString();
                    var vitC = row.Cells["C"].Value.ToString();
                    var FibrTotal = row.Cells["FibrTot"].Value.ToString();
                    string strSQL = $@"INSERT INTO Alimento (descAlimento, qtd, proteina, carboidrato, lipidio, calcio, ferro, vitB1, vitB2, vitC, fibraTtl, nomeTabela) 
                                    VALUES ('{alimento}',{qtde.Replace(",", ".")},{proteina.Replace(",", ".")},{carboidrato.Replace(",", ".")},{lipidio.Replace(",", ".")},{Ca.Replace(",", ".")}
                                    ,{Fe.Replace(",", ".")},{B1.Replace(",", ".")},{B2.Replace(",", ".")},{vitC.Replace(",", ".")},{FibrTotal.Replace(",", ".")}, '{txtNomeTabela.Text}')";
                };


                Interaction.MsgBox("Os dados foram Salvos", MsgBoxStyle.OkOnly, "SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "ERRO AO SALVAR");

            }

            pbCarregando.Value = 0;
            pbCarregando.Visible = false;
        }

        private void _cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = tables[_cbxNomePlanilha.SelectedItem.ToString()];
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
                        //Interaction.MsgBox(ex.Message);
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
            paciente.Buscar(dtgDados, txtNome.Text);
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
            paciente.Buscar(_dtgConsultaPacientes, _txtNomePaciente.Text);
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
                paciente.Deletar(Conversions.ToInteger(txtCodPaciente.Text));
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


            if (usuario.VerificarExisteUsuario(txtUsuarioConfig.Text) == false)
            {
                // usuario.CriarUsuario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text);
            }
            else
            {
                if (Interaction.MsgBox("Você deseja alterar a senha do usuário?", MsgBoxStyle.YesNo, "ALTERAÇÃO DE SENHA") == MsgBoxResult.Yes)
                    alterarSenha = true;
                usuario.AlterarUsuario(txtUsuarioConfig.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, cbxSituacao.Text, cbxTipoUsuario.Text, alterarSenha);

            }
        }
        private void txtUsuarioConfig_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioConfig.Text != "")
                usuario.Buscar(txtUsuarioConfig.Text);
        }
        private void tbConfig_Enter(object sender, EventArgs e)
        {
            CriarColunas();
            usuario.Buscar("");
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
