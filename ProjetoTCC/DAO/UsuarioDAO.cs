using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProjetoTCC
{
    public class UsuarioDAO
    {
        public UsuarioDAO()
        {
            objConexao = new SQLiteConnection(objBanco.Conexao().ToString());
        }

        public DBAcesso objBanco = new DBAcesso();
        public SQLiteConnection objConexao;
        private string usuario;
        private string senha;
        private string nome;

        public void setNomeUsuario(string usuarioLogin)
        {
            if (usuarioLogin is object)
            {
                if (objConexao.State == ConnectionState.Closed)
                {
                    objConexao.Open();
                }

                string strSQL = $"SELECT Nome FROM Login WHERE usuario = '{usuarioLogin}'" + '\r' + '\n';
                using (var cmd = new SQLiteCommand(strSQL, objConexao))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            nome = Conversions.ToString(dr["Nome"]);
                    }
                }

                objConexao.Close();
            }
        }

        public object getNomeUsuario()
        {
            return nome;
        }

        public object getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string usuarioLogado)
        {
            usuario = usuarioLogado;
        }

        public object getUsuarioSenha()
        {
            return senha;
        }

        public void setUsuarioSenha(string senhaatual)
        {
            senha = senhaatual;
        }

        public object verificarUsuarioLogado(string usuarioLogado, string senha)
        {
            string strSQL = string.Empty;
            bool usuarioOK = false;
            strSQL = $"SELECT count(1) AS existe FROM Login WHERE usuario = '{usuarioLogado}' AND senha = '{senha}'";
            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuarioOK = Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(dr["existe"], 0, false));
            }

            objConexao.Close();
            return usuarioOK;
        }

        public void Buscar(string usuario, DataGridView dtgDados)
        {
            string strSQL = string.Empty;
            var config = new frmConfiguracoes();
            strSQL = $"SELECT * FROM Login\n";
            if (usuario != "")
            {
                strSQL = $"WHERE usuario = '{usuario}'";
            }
            var cmd = new SQLiteCommand(strSQL, objConexao);
            objConexao.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgDados.Rows.Add(dr["usuario"], dr["nome"], dr["email"], dr["tipoUsuario"], dr["situacao"]);
            }

        }

    }
}