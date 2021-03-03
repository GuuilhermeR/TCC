using System.Data.OleDb;

namespace ProjetoTCC
{
    public class importPlanilhaExcel
    {
        public void BuscarPlanilha(string caminhoArquivoExcel, string nomePlanilhaExcel)
        {
            var cmd = new OleDbCommand();
            nomePlanilhaExcel = nomePlanilhaExcel + "$";
            OleDbConnection conexaoOleDb = null;
            conexaoOleDb = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + caminhoArquivoExcel + ";Extended Properties=Excel 8.0;");
            cmd.CommandText = "Select * from [" + nomePlanilhaExcel + "]";
        }
    }
}