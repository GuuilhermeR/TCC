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

        public void Salvar(int codAlimento, string alimento, int qtd, string medidaCaseira, string kCal, double proteina, double carboidrato, int lipidio, int calcio, int ferro)
        {
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
                Interaction.MsgBox("O Alimento foi salvo.", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
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

        public void Buscar(DataGridView dtgDados, string nomeAlimento)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT codigo, nome, cpf, medidaCaseira, kCal, proteina, carboidrato, lipidio, calcio, ferro, vitC FROM Alimento";
            if (!string.IsNullOrEmpty(nomeAlimento))
            {
                strSQL += $"WHERE nome LIKE '%{nomeAlimento}%'";
            }

            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                dtgDados.Rows.Add(dr["codigo"], dr["nome"], dr["cpf"], dr["medidaCaseira"], dr["kCal"], dr["proteina"], dr["carboidrato"], dr["lipidio"], dr["calcio"], dr["ferro"]);
            objConexao.Close();
        }
    }
}