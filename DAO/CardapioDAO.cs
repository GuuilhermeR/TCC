using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace TCC2
{
    public class CardapioDAO
    {
        public static string codPacienteCard = "";
        public static string nomePacienteCard = "";

        public CardapioDAO()
        {
        }

        public void Salvar(int codPaciente, int codAlimento, decimal medidaCaseiraQtde, string obs, decimal kcal)
        {
            try
            {
                Cardapio cardapioInsert = new Cardapio();

                cardapioInsert.codPaciente = codPaciente;
                cardapioInsert.codAlimento = codAlimento;
                cardapioInsert.medidaCaseiraQtde = medidaCaseiraQtde;               
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

        public List<Cardapio> Consultar(int codPaciente)
        {
            try
            {
                var cardapio = ((from card in BancoDadosSingleton.Instance.Cardapio
                                   where card.codPaciente == codPaciente
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


    }

}
