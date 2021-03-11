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

        public void Atualizar(double codPaciente, string nomeCompleto, string cpf, string dtNasc, string email, string peso, string altura, string cep, double num, string telefone, string celular, string endereco, string bairro, string municipio, string uf, string complemento)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                strSQL = $@"UPDATE Paciente SET nome= '{nomeCompleto}', cpf = {cpf}, dtNasc = '{dtNasc}', 
                            email = '{email}', peso = {peso}, altura = {altura}, cep ={cep}, endereco ='{endereco}', bairro ='{bairro}', municipio ='{municipio}', uf ='{uf}', complemento ='{complemento}',
                            numero = {num}, telefone = {telefone}, celular = {celular} WHERE codigo = {codPaciente}";

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

        public void Salvar(string nomeCompleto, string cpf, string dtNasc, string email, string peso, string altura, string cep, double num, string telefone, string celular, string endereco, string bairro, string municipio, string uf, string complemento)
        {
            objConexao.Open();
            string strSQL = string.Empty;
            try
            {
                strSQL = strSQL = $@"INSERT INTO Paciente (nome, cpf, dtNasc, email, peso, altura, cep, endereco, bairro, municipio, uf, numero, telefone, celular) 
                            values ('{nomeCompleto}', {cpf}, '{dtNasc}', '{email}', {peso}, {altura}, {cep}, '{endereco}', '{bairro}', '{municipio}', '{uf}', {num}, {telefone}, {celular})";

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
            if (!string.IsNullOrEmpty(nomePaciente.ToString()))
            {
                strSQL += $"WHERE nome LIKE '%{nomePaciente.ToString()}%'";
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