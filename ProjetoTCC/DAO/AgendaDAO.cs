using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC.DAO
{
   public class AgendaDAO
    {
        public AgendaDAO()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        public void CarregarAgenda(DataGridView dtgDados, string dataAgenda)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT horario, paciente FROM Agenda\n";
            strSQL += $"WHERE data = '{dataAgenda}'\n";

            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (DataGridViewRow row in dtgDados.Rows)
                {
                    //if(row.Cells("horario").value == dr["horario"]) {
                    //    dtgDados.Rows.Add(dr["horario"],dr["paciente"]);
                    //}
                }

            }
            objConexao.Close();
        }

    }
}
