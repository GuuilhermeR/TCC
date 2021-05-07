using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC2
{
    public class ImportadorPlanilha
    {
        //private Excel.Application xl = new Excel.Application();
        //private Excel.Workbook xlw;
        //private Excel.Worksheet xls;
        public ImportadorPlanilha()
        {

        }

        //    public bool ImportaArquivoExcel(string nome_planilha, DataGridView dataGridView, int numColunas, DataTable data_table)
        //    {
        //        ArrayList itens = new ArrayList();
        //        int qtdRegistros;
        //        ComboBox cbxTemporario = new ComboBox();
        //        int i;
        //        int j;

        //        // Abre o arquivo excel
        //        xlw = xl.Workbooks.Open(nome_planilha);

        //        // Passa esses dados para o combobox temporário
        //        foreach (var xls in xlw.Worksheets) // Le todos os nomes das planilhas dentro do .xls
        //            cbxTemporario.Items.Add(xls.Name);// Insiro no meu combobox cada nome encontrado

        //        // Seleciona a 1° linha do combox
        //        cbxTemporario.SelectedIndex = 0;

        //        xlw.Sheets(cbxTemporario.SelectedItem).Select(); // Seleciona a planilha escolhida na combobox
        //                                                         // xlw.Sheets("Plan1").Select() 'Também pode ser usado assim, mas com a combobox fica dinâmico

        //        // Conta a quantidade de registros 
        //        qtdRegistros = xlw.Application.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

        //        // Comessei a parti da 2° linha, pois a primeira é referente ao nome das colunas
        //        for (i = 2; i <= qtdRegistros; i++)
        //        {

        //            // Limpa o array list
        //            itens.Clear();

        //            // Busca o valor das linhas para poder adicionar o arraylist
        //            for (j = 1; j <= numColunas; j++)
        //                itens.Add(xlw.Application.Cells(i, j).Value);

        //            // Adiciona o dado na grid view. Lembre que essa grid já deve estar montada.
        //            objPixDataGridView.Grd_IncluiLinhaDataGridView(data_table, itens, dataGridView);
        //        }

        //        // Fecha o arquivo .xls sem salvar nada
        //        xlw.Close(false);

        //        return false;
        //    }
        //}
    }
}
