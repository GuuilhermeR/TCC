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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtCodAlimento.Text))
                {
                    strSQL = $@"UPDATE InfosAlimentosNutricionais 
                            SET Alimento= {txtAlimento.Text}, qtde = {txtQtde.Text}, kcal ={txtKCal.Text}, proteina ={txtProteina.Text}, carboidrato = {txtCarboidrato.Text}, 
                            lipidio = {txtLipidio.Text}, calcio = {txtCalcio.Text}, ferro = {txtFerro.Text}, vitC = {txtVitC.Text}
                            WHERE codAlimento = {txtCodAlimento.Text}";
                }
                else
                {
                    strSQL = $@"INSERT INTO InfosAlimentosNutricionais (Alimento, qtde, kcal, proteina, carboidrato, lipidio, calcio, ferro, vitC, medidaCaseira) 
                            values ({txtAlimento.Text}, {txtQtde.Text}, {txtKCal.Text}, {txtProteina.Text}, {txtCarboidrato.Text}, {txtLipidio.Text}, {txtCalcio.Text},
                            {txtFerro.Text}, {txtVitC.Text}, {txtMedidaCaseira.Text})";
                }

                var cmd = new SQLiteCommand(strSQL, objConexao);
                cmd.ExecuteNonQuery();
                Interaction.MsgBox("Seus dados foram salvos", Constants.vbInformation, "Atenção!");
                limparCampos();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento.", (MsgBoxStyle)Constants.vbYes, "Alerta");
            }

            objConexao.Close();
        }

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

        private void txtAlimentoFiltro_Leave(object sender, EventArgs e)
        {
            alimento.Buscar(dtgConAlimento, txtAlimento.Text);
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
        }
    }
}