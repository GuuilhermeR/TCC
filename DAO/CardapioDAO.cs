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

        public string Salvar(int codPaciente, int codAlimento, string refeicao, double medidaCaseiraQtde, string obs, double kcal, string usuario, string data)
        {
            if (VerificarExiste(codPaciente, codAlimento,data,refeicao))
            {
                try
                {
                    loadStart();
                    var cardUpdt = (from card in BancoDadosSingleton.Instance.Cardapio
                                    where card.codPaciente == codPaciente && card.data == data
                                    select card).Single();

                    cardUpdt.codPaciente = codPaciente;
                    cardUpdt.data = data;
                    cardUpdt.usuarioResp = usuario;
                    cardUpdt.codAlimento = codAlimento;
                    cardUpdt.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardUpdt.Refeicao = refeicao;
                    cardUpdt.Obs = obs;
                    cardUpdt.kcal = kcal;

                    BancoDadosSingleton.Instance.Cardapio.Add(cardUpdt);
                    BancoDadosSingleton.Instance.SaveChanges();
                    loadStop();

                }
                catch (Exception ex)
                {
                    loadStop();
                    return "Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException;
                }
            }
            else
            {
                try
                {
                    loadStart();
                    Cardapio cardapioInsert = new Cardapio();

                    cardapioInsert.codPaciente = codPaciente;
                    cardapioInsert.data = data;
                    cardapioInsert.usuarioResp = usuario;
                    cardapioInsert.codAlimento = codAlimento;
                    cardapioInsert.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardapioInsert.Refeicao = refeicao;
                    cardapioInsert.Obs = obs;
                    cardapioInsert.kcal = kcal;

                    BancoDadosSingleton.Instance.Cardapio.Add(cardapioInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    loadStop();
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

                var cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente && card.codAlimento == codAlimento && card.data == data && card.Refeicao == refeicao
                                 select card).Distinct()).ToList();

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
            if (!String.IsNullOrEmpty(PacienteModel.codPacienteCard))
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Cardapio WHERE codPaciente = {PacienteModel.codPacienteCard} AND data={data}";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemErro("Cardápio foi excluído");
            }
        }

    }
}
