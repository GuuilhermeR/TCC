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
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        private int retornaUltimoCodAlimento()
        {
            objConexao.Open();
            string strSQL = string.Empty;
            var codAlimento = default(int);
            strSQL = $"SELECT MAX(codigo) As Codigo FROM Alimento";
            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                codAlimento = Conversions.ToInteger(dr["Codigo"]);
            }

            objConexao.Close();
            return codAlimento;
        }

        public void Salvar(int codAlimento, string alimento, decimal qtd, decimal medidaCaseira, decimal kCal, decimal proteina, decimal carboidrato, decimal lipidio, decimal calcio, decimal ferro)
        {
            SQLiteTransaction trans = objConexao.BeginTransaction();
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                if (codAlimento != Conversions.ToDouble(""))
                {
                    strSQL = $@"UPDATE Paciente SET nome= '{alimento}', qtd = {qtd}, medidaCaseira = '{medidaCaseira}', 
                            kCal = '{kCal}', proteina = {proteina}, carboidrato = {carboidrato}, lipidio ={qtd}, calcio = {calcio}, ferro = {ferro} WHERE codigo = {codAlimento}";
                }
                else
                {
                    strSQL = $@"INSERT INTO Paciente (nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro) 
                            values ('{alimento}', {qtd}, '{medidaCaseira}', '{kCal}', {proteina}, {carboidrato}, {qtd}, {calcio}, {ferro})";
                }

                var cmd = new SQLiteCommand(strSQL, objConexao);
                cmd.ExecuteNonQuery();
                trans.Commit();
                Interaction.MsgBox("O Alimento foi salvo.", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
                trans.Commit();
            }

            objConexao.Close();
        }

        public void Deletar(int codAlimento)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                strSQL = $"DELETE FROM Alimento WHERE codAlimento = {codAlimento}";
                var cmd = new SQLiteCommand(strSQL, objConexao);
                cmd.ExecuteNonQuery();
                Interaction.MsgBox("O Alimento foi excluído!", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao excluir o Alimento." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
            }

            objConexao.Close();
        }

        public void Buscar(DataGridView dtgDados, string nomeAlimento, string nomeTabela)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT codigo, nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro, vitC FROM Alimento\n";
            strSQL += $"WHERE nome LIKE '%{nomeAlimento}%'\n";
            strSQL += $"AND nomeTabela = '{nomeTabela}'";


            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                dtgDados.Rows.Add(dr["codigo"], dr["nome"], dr["cpf"], dr["medidaCaseira"], dr["kCal"], dr["proteina"], dr["carboidrato"], dr["lipidio"], dr["calcio"], dr["ferro"]);
            objConexao.Close();
        }
    }
}