using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public class AlimentoDAO
    {
        public AlimentoDAO()
        {
        }


        private int retornaUltimoCodAlimento()
        {

            string strSQL = string.Empty;
            var codAlimento = default(int);
            strSQL = $"SELECT MAX(codigo) As Codigo FROM Alimento";
           
            return codAlimento;
        }

        public void Salvar(int codAlimento, string alimento, decimal qtd, decimal kCal, decimal proteina, decimal carboidrato, decimal lipidio, decimal calcio, decimal ferro, decimal vitB1, decimal vitB2, decimal vitC, decimal fibraTtl, string nomeTabela)
        {
            string strSQL = string.Empty;
            try
            {
                if (codAlimento != Conversions.ToDouble(""))
                {
                    strSQL = $@"UPDATE Paciente SET descAlimento= '{alimento}', qtd = {qtd}, proteina = {proteina}, 
                                carboidrato = {carboidrato}, lipidio ={lipidio}, calcio = {calcio}, ferro = {ferro}, vitB1 = {vitB1}
                                ,vitB2 = {vitB2}, vitC = {vitC}, fibraTtl = {fibraTtl}, kcal = {kCal}, nomeTabela = '{nomeTabela}' WHERE codigo = {codAlimento}";
                }
                else
                {
                    strSQL = $@"INSERT INTO Paciente (nome, qtde, kCal, proteina, carboidrato, lipidio, calcio, ferro, vitB1, vitB2, vitC, fibraTtl, nometabela) 
                            values ('{alimento}', {qtd}, '{kCal}', {proteina}, {carboidrato}, {lipidio}, {calcio}, {ferro}, {vitB1}, {vitB2}, {vitC}, {fibraTtl}, '{nomeTabela}')";
                }

               
                Interaction.MsgBox("O Alimento foi salvo.", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
                
            }

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