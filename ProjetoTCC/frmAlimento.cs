using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Z.EntityFramework;
using Z.BulkOperations;

namespace ProjetoTCC
{
    public partial class frmAlimento
    {
        public frmAlimento()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
            InitializeComponent();
            _tbConsulta.Name = "tbConsulta";
            _txtAlimentoFiltro.Name = "txtAlimentoFiltro";
            _cbxNomePlanilha.Name = "cbxNomePlanilha";
            _btnImportar.Name = "btnImportar";
            _btnBuscarPlanilha.Name = "btnBuscarPlanilha";
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        public AlimentoDAO alimento = new AlimentoDAO();
        private DataTableCollection tables;

        private void limparCampos()
        {
            txtAlimento.Text = "";
            txtCalcio.Text = "";
            txtCarboidrato.Text = "";
            txtCodAlimento.Text = "";
            txtFerro.Text = "";
            txtKCal.Text = "";
            txtLipidio.Text = "";
            txtMedidaCaseira.Text = "";
            txtProteina.Text = "";
            txtQtde.Text = "";
            txtVitC.Text = "";
        }

        private void CarregarTabelas()
        {
            string strSQL = string.Empty;
            strSQL = "SELECT nomeTabela FROM Alimento";
            
            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                cbxNomePlanilha.Items.Add(dr["nomeTabela"]);
            objConexao.Close();
        }

        private void btnBuscarPlanilha_Click(object sender, EventArgs e)
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
                                cbxNomePlanilha.Items.Clear();
                                foreach (DataTable table in tables)
                                    cbxNomePlanilha.Items.Add(table.TableName);
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

        private void cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = tables[cbxNomePlanilha.SelectedItem.ToString()];
            dtgDados.DataSource = dt;
        }

        private void ExcluirTabela(string nomeTabela)
        {
            objConexao.Open();
            string strSQL = $@"DELETE FROM Alimento WHERE nomeTabela = '{nomeTabela}'";

            var cmd = new SQLiteCommand(strSQL, objConexao);
            cmd.ExecuteNonQuery();
            objConexao.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ListView teste = new ListView();
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

            objConexao.Open();
            pbCarregando.Visible = true;
            pbCarregando.Value = 0;

            SQLiteTransaction trans = objConexao.BeginTransaction();

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

                    var cmd = new SQLiteCommand(strSQL, objConexao);
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                };
                Interaction.MsgBox("Os dados foram Salvos", MsgBoxStyle.OkOnly, "ERRO AO SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "ERRO AO SALVAR");
                trans.Rollback();
            }
            objConexao.Close();
            pbCarregando.Value = 0;
            pbCarregando.Visible=false;
        }

        private bool VerificarExisteTabela(string nomeTabela)
        {
            bool existe = false;

            string strSQL = $@"SELECT COUNT(1) AS Existe FROM Alimento WHERE nomeTabela='{nomeTabela}'";

            var cmd = new SQLiteCommand(strSQL, objConexao);

            objConexao.Open();

            var dr = cmd.ExecuteReader();

            if (dr.Read())
                existe = Convert.ToBoolean(dr["Existe"]);

            objConexao.Close();

            return existe;
        }

        private void btnProcurarAlimento_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            alimento.Salvar(Convert.ToInt32(txtCodAlimento.Text), txtAlimento.Text, Convert.ToDecimal(txtQtde.Text), Convert.ToDecimal(txtMedidaCaseira.Text), Convert.ToDecimal(txtKCal.Text), Convert.ToDecimal(txtProteina.Text), Convert.ToDecimal(txtCarboidrato.Text) , Convert.ToDecimal(txtLipidio.Text), Convert.ToDecimal(txtCalcio.Text), Convert.ToDecimal(txtFerro.Text));
            limparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAlimento.Text))
            {
                alimento.Deletar(Conversions.ToInteger(txtCodAlimento.Text));
            }
            else
            {
                Interaction.MsgBox("Não é possível excluir sem antes informar o código.");
            }
        }

        private void _txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (cbxNomePlanilha.Text != "")
                alimento.Buscar(dtgConAlimento, _txtAlimentoFiltro.Text, cbxNomePlanilha.Text);
            
        }

        private void _tbConsulta_Enter(object sender, EventArgs e)
        {
            CarregarTabelas();
        }

        private void dtgConAlimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0) {
                if (e.ColumnIndex >= 0) {

                    

                }
            }
        }
    }
}