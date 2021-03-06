using System;
using System.Data;
using System.Data.SQLite;
using Microsoft.VisualBasic;

namespace ProjetoTCC
{
    public class DBAcesso
    {
        private SQLiteConnection objConexao;
        private string stringConexao = "Data Source=BancoDadosTCC.DB; Version=3;";

        public void Conectar()
        {
            try
            {
                objConexao = new SQLiteConnection(stringConexao);
                objConexao.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Conexao()
        {
            return stringConexao;
        }

        public void Fechar()
        {
            try
            {
                if (!Information.IsNothing(objConexao))
                {
                    if (objConexao.State == ConnectionState.Open)
                    {
                        objConexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}