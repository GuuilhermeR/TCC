using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace ProjetoTCC
{
    public class AlimentoDAO
    {
        public AlimentoDAO()
        {
        }

        public void Salvar(string alimento, decimal qtd, decimal kCal, decimal proteina, decimal carboidrato, decimal lipidio, string nomeTabela)
        {
            try
            {
                Alimentos alimentosInsert = new Alimentos();

                alimentosInsert.nomeAlimento = alimento;
                alimentosInsert.qtd = qtd;
                alimentosInsert.kcal = kCal;
                alimentosInsert.prot = proteina;
                alimentosInsert.carbo = carboidrato;
                alimentosInsert.lipidio = lipidio;
                alimentosInsert.nomeTabela = nomeTabela;

                BancoDadosSingleton.Instance.Alimentos.Add(alimentosInsert);
                BancoDadosSingleton.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");

            }

        }

        public bool VerificarAlimento(string alimentoVerificar)
        {
            var alimentoRetorno = "";
            try
            {
                var Alimentos = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.nomeAlimento == alimentoVerificar select ali).Single();
                alimentoRetorno = Alimentos.ToString();
            }
            catch
            {
                return false;
            }

            if (alimentoRetorno != "")
            {
                return true;
            }

            return false;
        }

        public void Deletar(int codAlimento)
        {

            string strSQL = string.Empty;
            try
            {
                strSQL = $"DELETE FROM Alimento WHERE codAlimento = {codAlimento}";

                Interaction.MsgBox("O Alimento foi excluído!", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao excluir o Alimento." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
            }


        }

        public void Buscar(DataGridView dtgDados, string nomeAlimento, string nomeTabela)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT codigo, nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro, vitC FROM Alimento\n";
            strSQL += $"WHERE nomeTabela = '{nomeTabela}' \n";
            if (nomeAlimento != "")
                strSQL += $"AND nome LIKE '%{nomeAlimento}%'";

        }
    }
}