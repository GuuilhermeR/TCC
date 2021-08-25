using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;
using static Classes.ExibidorMensagem;

namespace ProjetoTCC
{
    public class AgendaDAO
    {
        public AgendaDAO()
        {

        }

        public List<Agenda> CarregarAgenda(string dataAgenda)
        {
            try
            {
                var agenda = (from a in BancoDadosSingleton.Instance.Agenda where a.data == dataAgenda select a).ToList();
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

        public List<Agenda> CarregarAgenda()
        {
            try
            {
                var agenda = (from a in BancoDadosSingleton.Instance.Agenda select a).ToList();
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

        public void AdicionarPaciente(string dataAgenda, string horario, string paciente, bool atendido, bool retorno, int cancelado, bool ajusteConsulta, string usuario)
        {
            try
            {
                var a = (from c in BancoDadosSingleton.Instance.Agenda where c.paciente == paciente && c.data == dataAgenda select c).Single();

                a.data = dataAgenda;
                a.hora = horario;
                a.atendido = atendido;
                a.retorno = retorno;
                a.Cancelado = cancelado;
                a.usuarioResp = usuario;

                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("Consulta do paciente atualizado.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }

        }

        public void AtualizarPaciente(string dataAgenda, string horario, string paciente, bool atendido, bool retorno, int cancelado, bool ajusteConsulta, string usuario)
        {
            try
            {
                Agenda agendaInsert = new Agenda();

                agendaInsert.paciente = paciente;
                agendaInsert.data = dataAgenda;
                agendaInsert.hora = horario;
                agendaInsert.atendido = atendido;
                agendaInsert.retorno = retorno;
                agendaInsert.Cancelado = cancelado;
                agendaInsert.usuarioResp = usuario;

                BancoDadosSingleton.Instance.Agenda.Add(agendaInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("Consulta do paciente foi agendado.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

        public bool VerificarPacienteAgendado(string pacienteAgendar, string dataAgendada)
        {
            var paciente = "";
            var agendado = "";
            try
            {
                paciente = (from a in BancoDadosSingleton.Instance.Agenda where a.paciente == pacienteAgendar && a.data == dataAgendada select a.paciente).Single();
                agendado = paciente.ToString();
            }
            catch
            {
                return false;
            }

            return Convert.ToBoolean(agendado != "");
        }

        public void DeletarPacienteAgenda(string paciente)
        {
            try
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Agenda WHERE paciente = '{paciente}'";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemAviso("Consultas foram removidas.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao deletar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}
