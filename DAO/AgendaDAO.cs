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
            
        }

        //public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        public void CarregarAgenda(DataGridView dtgDados, string dataAgenda)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT horario, paciente FROM Agenda\n";
            strSQL += $"WHERE data = '{dataAgenda}'\n";

        }

    }
}
