using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;

namespace ProjetoTCC
{
   public class AgendaDAO
    {
        public AgendaDAO()
        {
            
        }

        public string CarregarAgenda(string dataAgenda, string horario)
        {
            var agenda = "";
            try
            {
             agenda  = (from a in TCC2.BancoDadosSingleton.Instance.Agenda where a.data == dataAgenda && a.hora == horario select a.paciente).Single();
            }
            catch
            {

            }
            return agenda.ToString();
        }

        public void AdicionarPaciente(string dataAgenda, string horario, string paciente)
        {
            Agenda agendaInsert = new Agenda();

            agendaInsert.paciente = paciente;
            agendaInsert.data = dataAgenda;
            agendaInsert.hora = horario;

            BancoDadosSingleton.Instance.Agenda.Add(agendaInsert);
            BancoDadosSingleton.Instance.SaveChanges();
        }
    }
}
