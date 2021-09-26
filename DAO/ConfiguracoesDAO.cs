using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.HelperFuncoes;
using TCC2.Banco_de_Dados;

namespace TCC2.DAO
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
                ConfiguracoesUsuarios configInsert = new ConfiguracoesUsuarios();

                configInsert.usuario = usuario;
                configInsert.diaSemana = diaSemana;
                configInsert.horaInicio = horaInicio;
                configInsert.horaFim = horaFim;

                BancoDadosSingleton.Instance.ConfiguracoesUsuarios.Add(configInsert);
                BancoDadosSingleton.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                nMensagemAlerta("Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }        

    }
}
