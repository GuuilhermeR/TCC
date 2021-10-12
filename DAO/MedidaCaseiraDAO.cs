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

namespace TCC2
{
    public class MedidaCaseiraDAO
    {
        public MedidaCaseiraDAO()
        {
        }


        public string Salvar(string descricao, double qtd, int codAlimento)
        {
            try
            {
                loadStart();

                MedidaCaseira medCasInsert = new MedidaCaseira();

                medCasInsert.descricao = descricao;
                medCasInsert.qtd = qtd;
                medCasInsert.codAlimento = codAlimento;

                BancoDadosSingleton.Instance.MedidaCaseira.Add(medCasInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                loadStop();
            }
            catch (Exception ex)
            {
                return "Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException;
            }
            return string.Empty;
        }

        public List<MedidaCaseira> Buscar(int codAlimento, string descricao)
        {
            try
            {
                List<MedidaCaseira> medCaseira = new List<MedidaCaseira>();
                if (codAlimento > 0 && string.IsNullOrEmpty(descricao))
                {
                    medCaseira = ((from mc in BancoDadosSingleton.Instance.MedidaCaseira
                                   where mc.codAlimento == codAlimento
                                   select mc).Distinct()).ToList();
                }
                else if (codAlimento == 0 && string.IsNullOrEmpty(descricao))
                {
                    medCaseira = ((from mc in BancoDadosSingleton.Instance.MedidaCaseira
                                   select mc).Distinct()).ToList();
                }
                else if (codAlimento > 0 && !string.IsNullOrEmpty(descricao))
                {
                    medCaseira = ((from mc in BancoDadosSingleton.Instance.MedidaCaseira
                                   where mc.codAlimento == codAlimento && mc.descricao == descricao
                                   select mc).Distinct()).ToList();
                }

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

        public void Deletar()
        {
            try
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM MedidaCaseira";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao deletar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}