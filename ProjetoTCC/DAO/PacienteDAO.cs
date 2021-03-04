using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public class PacienteDAO
    {
        public PacienteDAO()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;

        private int retornaUltimoCodPaciente()
        {
            objConexao.Open();
            string strSQL = string.Empty;
            var codPaciente = default(int);
            strSQL = $"SELECT MAX(codigo) As Codigo FROM Paciente";
            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                codPaciente = Conversions.ToInteger(dr["Codigo"]);
            }

            objConexao.Close();
            return codPaciente;
        }

        public void Salvar(int codPaciente, string nomeCompleto, int cpf, DateTime dtNasc, string email, double peso, double altura, int cep, int num, int telefone, int celular)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                if (codPaciente != Conversions.ToDouble(""))
                {
                    strSQL = $@"UPDATE Paciente SET nome= '{nomeCompleto}', cpf = {cpf}, dtNasc = '{dtNasc.ToString("dd/MM/yyyy")}', 
                            email = '{email}', peso = {peso}, altura = {altura}, cep ={cep}, numero = {num}, telefone = {telefone}, celular = {celular} WHERE codigo = {codPaciente}";
                }
                else
                {
                    strSQL = $@"INSERT INTO Paciente (nome, cpf, dtNasc, email, peso, altura, cep, numero, telefone, celular) 
                            values ('{nomeCompleto}', {cpf}, '{dtNasc.ToString("dd/MM/yyyy")}', '{email}', {peso}, {altura}, {cep}, {num}, {telefone}, {celular})";
                }

                var cmd = new SQLiteCommand(strSQL, objConexao);
                cmd.ExecuteNonQuery();
                Interaction.MsgBox("O Paciente foi salvo.", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Paciente." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
            }

            objConexao.Close();
        }

        public void Deletar(int codPaciente)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                strSQL = $"DELETE FROM Paciente WHERE codAlimento = {codPaciente}";
                var cmd = new SQLiteCommand(strSQL, objConexao);
                cmd.ExecuteNonQuery();
                Interaction.MsgBox("O Paciente foi excluído!", Constants.vbInformation, "Atenção!");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao excluir o Paciente." + '\n' + ex.Message, Constants.vbOKOnly, "Alerta");
            }

            objConexao.Close();
        }

        public void Buscar(DataGridView dtgDados, string nomePaciente)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT codigo, nome, cpf, dtNasc, email, peso, altura, cep, telefone, celular FROM Paciente";
            if (!string.IsNullOrEmpty(nomePaciente.Text))
            {
                strSQL += $"WHERE nome LIKE '%{nomePaciente.Text}%'";
            }

            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                dtgDados.Rows.Add(dr["codigo"], dr["nome"], dr["cpf"], dr["dtNasc"], dr["email"], dr["peso"], dr["altura"], dr["cep"], dr["telefone"], dr["celular"]);
            objConexao.Close();
        }
    }
}