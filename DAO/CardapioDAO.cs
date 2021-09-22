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

namespace TCC2
{
    public class CardapioDAO
    {
        public static string codPacienteCard = "";
        public static string nomePacienteCard = "";

        public CardapioDAO()
        {
        }

        public void Salvar(int codPaciente, int codAlimento, string refeicao, double medidaCaseiraQtde, string obs, double kcal, string usuario, string data, bool Update)
        {            
            if (Update)
            {
                try
                {
                    var cardUpdt = (from card in BancoDadosSingleton.Instance.Cardapio
                                    where card.codPaciente == codPaciente && card.Data == data
                                    select card).Single();

                    cardUpdt.codPaciente = codPaciente;
                    cardUpdt.Data = data;
                    cardUpdt.usuarioResp = usuario;
                    cardUpdt.codAlimento = codAlimento;
                    cardUpdt.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardUpdt.Refeicao = refeicao;
                    cardUpdt.Obs = obs;
                    cardUpdt.kcal = kcal;

                    BancoDadosSingleton.Instance.Cardapio.Add(cardUpdt);
                    BancoDadosSingleton.Instance.SaveChanges();
                    nMensagemAviso("Cardápio foi atualizado!");
                }
                catch (Exception ex)
                {
                    nMensagemErro("Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException);
                }
            }
            else
            {
                try
                {
                    Cardapio cardapioInsert = new Cardapio();

                    cardapioInsert.codPaciente = codPaciente;
                    cardapioInsert.Data = data;
                    cardapioInsert.usuarioResp = usuario;
                    cardapioInsert.codAlimento = codAlimento;
                    cardapioInsert.medidaCaseiraQtde = medidaCaseiraQtde;
                    cardapioInsert.Refeicao = refeicao;
                    cardapioInsert.Obs = obs;
                    cardapioInsert.kcal = kcal;

                    BancoDadosSingleton.Instance.Cardapio.Add(cardapioInsert);
                    BancoDadosSingleton.Instance.SaveChanges();

                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Ocorreu um erro ao salvar o Cardápio." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");
                }
            }
        }

        public List<Cardapio> Consultar(int codPaciente, string data)
        {
            try
            {
                var cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                 where card.codPaciente == codPaciente && card.Data == data
                                 select card).Distinct()).ToList();

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
                                 select card.Data).Distinct()).ToList();

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

        public void Deletar()
        {
            if (!String.IsNullOrEmpty(codPacienteCard))
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Cardapio WHERE codPaciente = {codPacienteCard}";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemErro("Cardápio foi excluído");
            }
        }

    }
}
