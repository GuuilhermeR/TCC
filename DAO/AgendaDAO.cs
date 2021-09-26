using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;
using static Classes.HelperFuncoes;
using System.Data.Entity;

namespace ProjetoTCC
{
    public class AgendaDAO
    {
        public AgendaDAO()
        {

        }

        public List<Agenda> CarregarAgenda(string dataAgenda)
        {
            var dataInicio = dataAgenda + " 00:00:00";
            var dataFim = dataAgenda + " 23:59:59";
            DateTime dataMarcadasIni = Convert.ToDateTime(dataInicio);
            DateTime dataMarcadasFim = Convert.ToDateTime(dataFim);
            try
            {
                var agenda = BancoDadosSingleton.Instance.Agenda.Where(a =>
                                    (DateTime.ParseExact(a.data.ToString(), "yyyy-MM-dd HH:mm:ss", null) >= dataMarcadasIni)
                                    && (DateTime.ParseExact(a.data.ToString(), "yyyy-MM-dd HH:mm:ss", null) <= dataMarcadasFim)).ToList();
                if (agenda.Count > 0)
                    return agenda;
                else
                    return null;

            }
            catch (Exception ex)
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
            catch(Exception ex)
            {
                return null;
            }
        }

        public void AtualizarPaciente(string dataAgenda, string dataAgendaAntigo, string paciente, bool atendido, bool retorno, int cancelado, bool ajusteConsulta, string usuario)
        {
            DateTime dataHoraAgenda = Convert.ToDateTime(dataAgenda);
            DateTime dataHoraAgendaOld = Convert.ToDateTime(dataAgendaAntigo);
            long ID = 0;
            try
            {
                using (var db = new NutreasyEntities())
                {
                    var select = db.Database.Connection.CreateCommand();
                    select.CommandText = $"SELECT ID, retorno FROM AGENDA WHERE data='{dataHoraAgendaOld.ToString("yyyy-MM-dd HH:mm:ss")}' AND paciente ='{paciente}'";
                    db.Database.Connection.Open();
                    select.ExecuteNonQuery();
                    IDataReader dr = select.ExecuteReader();
                    if (dr.Read())
                    {
                        ID=(long)dr["ID"];
                        retorno=(bool)dr["retorno"];
                    }

                    if (ID == 0)
                    {
                        db.Database.Connection.Close();
                        return;
                    }

                    var update = db.Database.Connection.CreateCommand();
                    update.CommandText = $"UPDATE Agenda SET data='{dataHoraAgenda.ToString("yyyy-MM-dd HH:mm:ss")}'" +
                                                     $", retorno='{Convert.ToInt16(retorno)}'" +
                                                     $", atendido='{Convert.ToInt16(atendido)}'" +
                                                     $", cancelado='{cancelado}'" +
                                                     $", usuarioResp='{usuario}' " +
                                                     $"WHERE ID ={ID} ";
                    update.ExecuteNonQuery();
                    db.Database.Connection.Close();
                    BancoDadosSingleton.Instance.SaveChanges();
                   // BancoDadosSingleton.Instance.Login.Local;
                }

                nMensagemAviso("Consulta do paciente atualizado.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

        public void AdicionarPaciente(DateTime dataAgenda, string horario, string paciente, bool atendido, bool retorno, int cancelado, bool ajusteConsulta, string usuario)
        {
            try
            {
                Agenda agendaInsert = new Agenda();

                agendaInsert.paciente = paciente;
                agendaInsert.data = Convert.ToDateTime(dataAgenda.ToString("dd/MM/yyyy") + " " + horario + ":00");
                //agendaInsert.hora = horario;
                agendaInsert.atendido = atendido;
                agendaInsert.retorno = (bool)retorno;
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

        public bool VerificarPacienteAgendado(string pacienteAgendar, DateTime dataAgendada)
        {
            var agendado = "";
            var dataSemana = Convert.ToDateTime(dataAgendada).AddDays(5);
            try
            {
                var paciente = (from a in BancoDadosSingleton.Instance.Agenda
                                where a.paciente == pacienteAgendar
                                && a.data >= dataAgendada
                                && a.data <= dataSemana
                                select a.paciente).ToList();

                agendado = paciente.ToString();
            }
            catch
            {
                return false;
            }
            return Convert.ToBoolean(agendado != "");
        }

        public void DeletarPacienteAgenda(string paciente, string data, string hora)
        {
            DateTime dataHora = Convert.ToDateTime(data + " " + hora + ":00");
            try
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Agenda WHERE paciente = '{paciente}' AND data = '{dataHora.ToString("yyyy-MM-dd HH:mm:ss")}' ";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemAviso("A consulta foi removida.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao deletar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}
