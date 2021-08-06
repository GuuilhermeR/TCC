using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.ExibidorMensagem;
using TCC2.Banco_de_Dados;

namespace TCC2.DAO
{
    public class ConfiguracoesDAO
    {

        public ConfiguracoesDAO() { }


        public List<ConfiguracoesUsuarios> Consultar(int codPaciente)
        {
            try
            {
                var configs = ((from card in BancoDadosSingleton.Instance.ConfiguracoesUsuarios
                                where card.codPaciente == codPaciente
                                 select card).Distinct()).ToList();

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

        public void Salvar()
        {
            try
            {
                ConfiguracoesUsuarios configInsert = new ConfiguracoesUsuarios();

               

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
