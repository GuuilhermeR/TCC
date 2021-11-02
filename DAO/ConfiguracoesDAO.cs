using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.HelperFuncoes;
using NutriEz.Banco_de_Dados;
using System.Data.Entity;

namespace NutriEz.DAO
{
    public class ConfiguracoesDAO
    {

        public ConfiguracoesDAO() { }


        public List<ConfiguracoesUsuarios> Consultar()
        {
            try
            {
                var configs = ((from config in BancoDadosSingleton.Instance.ConfiguracoesUsuarios
                                 select config).Distinct()).ToList();

                if (configs.Count > 0)
                {
                    return configs;
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

        public void Salvar(string usuario, string diaSemana, string horaInicio, string horaFim)
        {
            try
            {
                if (!ConsultarExisteConfig(usuario, diaSemana))
                {
                    ConfiguracoesUsuarios configInsert = new ConfiguracoesUsuarios();

                    configInsert.usuario = usuario;
                    configInsert.diaSemana = diaSemana;
                    configInsert.horaInicio = horaInicio;
                    configInsert.horaFim = horaFim;

                    BancoDadosSingleton.Instance.ConfiguracoesUsuarios.Add(configInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    BancoDadosSingleton.Instance.Entry(configInsert).State = EntityState.Modified;
                }
                else
                {
                    var configUpdate = (from card in BancoDadosSingleton.Instance.ConfiguracoesUsuarios
                                                where card.usuario == usuario
                                                    && card.diaSemana == diaSemana
                                                    && card.horaInicio == horaInicio
                                                    && card.horaFim == horaFim
                                                     select card).Single();

                    configUpdate.usuario = usuario;
                    configUpdate.diaSemana = diaSemana;
                    configUpdate.horaInicio = horaInicio;
                    configUpdate.horaFim = horaFim;

                    BancoDadosSingleton.Instance.SaveChanges();
                    BancoDadosSingleton.Instance.Entry(configUpdate).State = System.Data.Entity.EntityState.Modified;
                }                
            }
            catch (Exception ex)
            {
                nMensagemAlerta("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public bool ConsultarExisteConfig(string usuario, string diaSemana)
        {
            try
            {
                var configs = ((from config in BancoDadosSingleton.Instance.ConfiguracoesUsuarios
                                where config.usuario == usuario && config.diaSemana == diaSemana
                                select config).Distinct()).ToList();

                if (configs.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void RemoverConfig(string usuario, string diaSemana)
        {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM ConfiguracoesUsuarios WHERE usuario={usuario} AND diaSemana={diaSemana}";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
        }

    }
}
