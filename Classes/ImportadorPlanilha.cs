using ExcelDataReader;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2
{
    public class ImportadorPlanilha
    {
        private DataTableCollection tables;

        public ImportadorPlanilha()
        {

        }

        public void ImporterWorksheet(string caminhoExcel, ComboBox carregarCombo, TextBox caminhoExcelText)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if(caminhoExcel != null)
                    {
                        caminhoExcelText.Text = ofd.FileName;
                    } else
                    {
                        ofd.FileName = caminhoExcel;
                    }

                    try
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = new Func<IExcelDataReader, ExcelDataTableConfiguration>(__ => new ExcelDataTableConfiguration() { UseHeaderRow = true }) });
                                tables = result.Tables;
                                carregarCombo.Items.Clear();
                                foreach (DataTable table in tables)
                                    carregarCombo.Items.Add(table.TableName);
                            }
                        }
                        carregarCombo.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Ocorreu um erro:" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, MsgBoxStyle.Critical, "ERRO AO SALVAR");
                    }
                }
            }
        }
        
    }
}
