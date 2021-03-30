using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace ProjetoTCC
{
   public class AgendaDAO
    {
        public AgendaDAO()
        {
            
        }

        public List<Agenda> CarregarAgenda(string dataAgenda, string horario)
        {
            try
            {
                var agenda = (from a in BancoDadosSingleton.Instance.Agenda where a.data == dataAgenda && a.hora == horario select a).ToList();
                if (agenda.Count > 0)
                {
                    return agenda;

                }
                else
                {
                    return null;

                }
            }
            catch
            {
                return null;
            }
        }

        public void AdicionarPaciente(string dataAgenda, string horario, string paciente, bool atendido, bool retorno)
        {
            if (VerificarPacienteAgendado(paciente))
            {
                var a = (from c in BancoDadosSingleton.Instance.Agenda where c.paciente == paciente select c).Single();

                a.data = dataAgenda;
                a.hora = horario;
                a.atendido= atendido;
                a.retorno= retorno;

                BancoDadosSingleton.Instance.SaveChanges();
            }
            else
            {
                Agenda agendaInsert = new Agenda();

                agendaInsert.paciente = paciente;
                agendaInsert.data = dataAgenda;
                agendaInsert.hora = horario;
                agendaInsert.atendido = atendido;
                agendaInsert.retorno = retorno;

                BancoDadosSingleton.Instance.Agenda.Add(agendaInsert);
                BancoDadosSingleton.Instance.SaveChanges();
            }
            
        }

        public bool VerificarPacienteAgendado(string pacienteAgendar)
        {
            var paciente = "";
            var agendado = "";
            try
            {
                paciente = (from a in BancoDadosSingleton.Instance.Agenda where a.paciente == pacienteAgendar select a.paciente).Single();
                agendado = paciente.ToString();
            }
            catch
            {
                return false;
            }

            if (agendado != "")
            {
                return true;
            }

            return false;
        }

        public void DeletarPacienteAgenda(List<string> ID)
        {
            using (var db = new NutreasyEntities())
            {
                ID.ForEach(x =>
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Agenda WHERE ID IN ({x})";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                });                
            }
        }

    }
}
