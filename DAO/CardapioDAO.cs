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
using Model;

namespace TCC2
{
    public class CardapioDAO
    {


        public CardapioDAO()
        {
        }

        public string Salvar(int codPaciente, int codAlimento, string refeicao, double medidaCaseiraQtde, double kcal, string usuario, string data, string obs)
        {
            if (VerificarExiste(codPaciente, codAlimento, data, refeicao))
            {
                try
                {
                    var cardUpdt = (from card in BancoDadosSingleton.Instance.Cardapio
                                    where card.codPaciente == codPaciente
                                    && card.data == data
                                    && card.Refeicao == refeicao
                                    && card.codAlimento == codAlimento
                                    select card).Single();

                    cardUpdt.codPaciente = codPaciente;
                    cardUpdt.data = data;
                    cardUpdt.usuarioResp = usuario;
                    cardUpdt.codAlimento = codAlimento;
                    cardUpdt.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardUpdt.Refeicao = refeicao;
                    cardUpdt.kcal = kcal;
                    cardUpdt.obs = obs;

                    BancoDadosSingleton.Instance.SaveChanges();
                    BancoDadosSingleton.Instance.Entry(cardUpdt).State = System.Data.Entity.EntityState.Modified;
                }
                catch (Exception ex)
                {
                    return "Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException;
                }
            }
            else
            {
                try
                {
                    Cardapio cardapioInsert = new Cardapio();

                    cardapioInsert.codPaciente = codPaciente;
                    cardapioInsert.data = data;
                    cardapioInsert.usuarioResp = usuario;
                    cardapioInsert.codAlimento = codAlimento;
                    cardapioInsert.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardapioInsert.Refeicao = refeicao;
                    cardapioInsert.kcal = kcal;
                    cardapioInsert.obs = obs;

                    BancoDadosSingleton.Instance.Cardapio.Add(cardapioInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    BancoDadosSingleton.Instance.Entry(cardapioInsert).State = System.Data.Entity.EntityState.Modified;
                }
                catch (Exception ex)
                {
                    return "Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException;
                }
            }
            return string.Empty;
        }

        public bool VerificarExiste(int codPaciente, int codAlimento, string data, string refeicao)
        {
            try
            {
                List<Cardapio> cardapio = new List<Cardapio>();
                if (codAlimento > 0)
                {
                    cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente
                                 && card.codAlimento == codAlimento
                                 && card.data == data
                                 && card.Refeicao == refeicao
                                 select card).Distinct()).ToList();
                }


                if (cardapio.Count > 0)
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

        public List<Cardapio> Consultar(int codPaciente, string data, string refeicao)
        {
            try
            {
                List<Cardapio> cardapio = new List<Cardapio>();
                if (!string.IsNullOrEmpty(refeicao))
                {
                    cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente && card.data == data && card.Refeicao == refeicao
                                 select card).Distinct()).ToList();
                }
                else
                {
                    cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente && card.data == data
                                 select card).Distinct()).ToList();
                }

                if (cardapio.Count > 0)
                {
                    return cardapio;
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

        public List<string> ConsultarDataConsultas(int codPaciente)
        {
            try
            {
                var cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente
                                 select card.data).Distinct()).ToList();

                if (cardapio.Count > 0)
                {
                    return cardapio;
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

        public void Deletar(string data)
        {
            if (!String.IsNullOrEmpty(PacienteModel.codPacienteModel))
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Cardapio WHERE codPaciente = {PacienteModel.codPacienteModel} AND data={data}";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemErro("Cardápio foi excluído");
            }
        }

        public void RemoverComidaCardapio(string refeicao, string data, int alimento)
        {
            if (!String.IsNullOrEmpty(PacienteModel.codPacienteModel))
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Cardapio " +
                                         $" WHERE codPaciente={PacienteModel.codPacienteModel}" +
                                         $" AND Refeicao='{refeicao}'" +
                                         $" AND data='{data}'" +
                                         $" AND codAlimento={alimento}";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    BancoDadosSingleton.Instance.Entry(delete).State = System.Data.Entity.EntityState.Modified;
                    db.Database.Connection.Close();
                }
            }
        }
    }
}
