using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;

namespace TCC2
{
    public class MedidaCaseiraDAO
    {
        public MedidaCaseiraDAO()
        {
        }

        public void Salvar(string descricao, double qtd, int codAlimento)
        {
            try
            {
                MedidaCaseira medCasInsert = new MedidaCaseira();

                medCasInsert.descricao = descricao;
                medCasInsert.qtd = qtd;
                medCasInsert.codAlimento = codAlimento;

                BancoDadosSingleton.Instance.MedidaCaseira.Add(medCasInsert);
                BancoDadosSingleton.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");

            }
        }

        public List<MedidaCaseira> Buscar(int codAlimento)
        {
            try
            {
                var medCaseira = ((from mc in BancoDadosSingleton.Instance.MedidaCaseira 
                                   where mc.codAlimento == codAlimento 
                                   select mc).Distinct()).ToList();
                if (medCaseira.Count > 0)
                {
                    return medCaseira;

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
    }
}