using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

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

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            if (_txtAlimentoFiltro.Text != "")
                alimento.Buscar(dtgConAlimento, _txtAlimentoFiltro.Text);
        }

        private void tbConsulta_Click(object sender, EventArgs e)
        {
            alimento.Buscar(dtgConAlimento, null);
        }

        private void btnBuscarPlanilha_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoArquivoExcel.Text = ofd.FileName;
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
            }
        }

        private void cbxNomePlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = tables[cbxNomePlanilha.SelectedItem.ToString()];
            dtgDados.DataSource = dt;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            objConexao.Open();
            pbCarregando.Visible = true;
            pbCarregando.Value = 0;
            try
            {
                foreach (DataGridViewRow row in dtgDados.Rows)
                {
                    pbCarregando.PerformStep();
                    var alimento = row.Cells["ALIMENTO"].Value;
                    string proteina = row.Cells["Prot"].Value.ToString();
                    string carboidrato = row.Cells["Carb"].Value.ToString();

                    string strSQL = $@"INSERT INTO Alimento (Alimento, proteina, carboidrato, quantidade) 
                                    VALUES ('{alimento}',{proteina.Replace(",", ".")},{carboidrato.Replace(",", ".")},{row.Cells["PL"].Value})";

                    var cmd = new SQLiteCommand(strSQL, objConexao);
                    cmd.ExecuteNonQuery();

                };
                Interaction.MsgBox("Os dados foram Salvos", MsgBoxStyle.OkOnly, "ERRO AO SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "ERRO AO SALVAR");
            }
            objConexao.Close();
            pbCarregando.Value = 0;
            pbCarregando.Visible=false;
        }

        private bool VerificarExisteTabela(string nomeTabela)
        {
            bool existe = false;

            string strSQL = $@"SELECT COUNT(1) AS Existe FROM TabelasImportadas WHERE nomeTabela={nomeTabela}";

            var cmd = new SQLiteCommand(strSQL, objConexao);

            objConexao.Open();

            var dr = cmd.ExecuteReader();

            while (dr.Read())
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
    }
}