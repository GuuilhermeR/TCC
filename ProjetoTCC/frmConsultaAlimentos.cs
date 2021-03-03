using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public partial class frmConsultaAlimentos
    {
        public frmConsultaAlimentos()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
            InitializeComponent();
            _dtgConsultaAlimentos.Name = "dtgConsultaAlimentos";
            _btnRecalcular.Name = "btnRecalcular";
            _btnConsultar.Name = "btnConsultar";
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        private double quantidadeSalva;
        private double verificarHouveAlteracao;

        private void frmConsultaMedidasCaseiras_Load(object sender, EventArgs e)
        {
            // teste
        }

        private void btnRecalcular_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgConsultaAlimentos.Rows)
            {
                if (row.DefaultCellStyle.ForeColor == Color.Red)
                {
                    double ProteinaGramas;
                    double ProteinaKcal;
                    ProteinaGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["proteina"].Value), quantidadeSalva));
                    ProteinaKcal = ProteinaGramas * 4d;
                    row.Cells["proteina"].Value = ProteinaGramas.ToString("N2");
                    double CarboidratoGramas;
                    double CarboidratoKcal;
                    CarboidratoGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["carboidrato"].Value), quantidadeSalva));
                    CarboidratoKcal = CarboidratoGramas * 4d;
                    row.Cells["carboidrato"].Value = CarboidratoGramas.ToString("N2");
                    double LipidioGramas;
                    double LipidioKcal;
                    LipidioGramas = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(row.Cells["qtde"].Value, row.Cells["lipidio"].Value), quantidadeSalva));
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

            foreach (DataGridViewRow rows in dtgConsultaAlimentos.Rows)
            {
                if (rows.DefaultCellStyle.ForeColor == Color.Red)
                {
                    rows.DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (objConexao.State == ConnectionState.Closed)
            {
                objConexao.Open();
            }

            string strSQL = $@"SELECT Alimento AS Alimento,
                                qtde AS Quantidade, 
                                kcal AS KCal, 
                                proteina AS Proteína, 
                                carboidrato AS Carboidrato, 
                                lipidio AS Lipídio, 
                                calcio AS Cálcio, 
                                ferro AS Ferro, 
                                vitC AS VitaminaC
                                FROM InfosAlimentosNutricionais" + '\r' + '\n';
            if (!string.IsNullOrEmpty(txtAlimento.Text))
            {
                strSQL += $"WHERE codAlimento LIKE '%{txtAlimento.Text}%'";
            }

            using (var cmd = new SQLiteCommand(strSQL, objConexao))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    criarColunasGrid();
                    while (dr.Read())
                        dtgConsultaAlimentos.Rows.Add(dr["Alimento"], dr["Quantidade"], dr["KCal"], dr["Proteína"], dr["Carboidrato"], dr["Lipídio"], dr["Cálcio"], dr["Ferro"], dr["VitaminaC"]);
                }
            }

            objConexao.Close();
        }

        private void criarColunasGrid()
        {
            if (dtgConsultaAlimentos.Rows.Count == 0)
            {
                dtgConsultaAlimentos.Columns.Add("alimento", "Alimento");
                dtgConsultaAlimentos.Columns.Add("qtde", "Quantidade");
                dtgConsultaAlimentos.Columns.Add("kcal", "KCal");
                dtgConsultaAlimentos.Columns.Add("proteina", "Proteína");
                dtgConsultaAlimentos.Columns.Add("carboidrato", "Carboidrato");
                dtgConsultaAlimentos.Columns.Add("lipidio", "Lipídio");
                dtgConsultaAlimentos.Columns.Add("calcio", "Cálcio");
                dtgConsultaAlimentos.Columns.Add("ferro", "Ferro");
                dtgConsultaAlimentos.Columns.Add("vitC", "Vitamina C");
            }
        }

        private void dtgConsultaAlimentos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Conversions.ToBoolean(!Operators.ConditionalCompareObjectEqual(verificarHouveAlteracao, dtgConsultaAlimentos.CurrentCell.Value, false)))
            {
                dtgConsultaAlimentos.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void dtgConsultaAlimentos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                quantidadeSalva = Conversions.ToDouble(dtgConsultaAlimentos.CurrentRow.Cells["qtde"].Value);
                verificarHouveAlteracao = Conversions.ToDouble(dtgConsultaAlimentos.CurrentCell.Value);
            }
        }
    }
}