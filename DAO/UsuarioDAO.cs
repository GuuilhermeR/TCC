using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;
using Classes;
using System.Web.Security;
using static Classes.HelperFuncoes;
using TCC2.Classes;

namespace TCC2
{
    public class UsuarioDAO
    {
        public UsuarioDAO()
        { }

        private string usuario;
        private string senha;
        private string nome;

        public void setNomeUsuario(string usuarioLogin)
        {
            if (usuarioLogin == "")
            {
                return;
            }
            try
            {
                var usuarioLogado = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogin select c.nome).FirstOrDefault();
                nome = usuarioLogado.ToString();
                usuario = usuarioLogin.ToString();
                return;
            }
            catch
            {
                return;
            }
        }

        public object getNomeUsuario()
        {
            return nome;
        }

        public string getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string usuarioLogado)
        {
            usuario = usuarioLogado.ToString();
        }

        public void setUsuarioSenha(string senhaatual)
        {
            senha = senhaatual;
        }

        [Obsolete]
        public bool validarLogin(string usuarioLogado, string senha)
        {

            senha = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "MD5");
            try
            {
                var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogado && c.senha == senha && c.situacao.ToLower() == "ativo" select c).ToList();
                if (usuarioLog.Count > 0)
                {
                    return true;
                }
            }
            catch
            {
                return false;

            }
            return false;
        }

        public List<Login> getUsuario(string usuario)
        {
            List<Login> usuarios = new List<Login>(); ;
            if (usuario != "")
            {
                usuarios = ((from c in BancoDadosSingleton.Instance.Login where (c.usuario.ToUpper()).Contains(usuario.ToUpper()) select c).Distinct()).ToList();
            }
            else
            {
                usuarios = ((from c in BancoDadosSingleton.Instance.Login select c).Distinct()).ToList();
            }

            return usuarios;

        }

        public List<Login> getEmail(string usuario)
        {
            List<Login> emailUsuario = new List<Login>(); ;
            if (usuario != "")
            {
                emailUsuario = ((from c in BancoDadosSingleton.Instance.Login where (c.usuario.ToUpper()).Contains(usuario.ToUpper()) select c).Distinct()).ToList();
            }

            return emailUsuario;

        }

        [Obsolete]
        public void AlterarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, bool alterarSenha, string crn)
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();

            try
            {

                if (alterarSenha)
                {

                    var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();
                    senha = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "MD5");

                    usuUpdate.usuario = usuario;
                    usuUpdate.nome = nome;
                    usuUpdate.senha = senha;
                    usuUpdate.email = email;
                    usuUpdate.situacao = situacao;
                    usuUpdate.perfil = tipoUsuario;
                    if (crn != "")
                        usuUpdate.CRN = crn;

                    BancoDadosSingleton.Instance.SaveChanges();
                }
                else
                {
                    var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();

                    usuUpdate.usuario = usuario;
                    usuUpdate.nome = nome;
                    usuUpdate.email = email;
                    usuUpdate.situacao = situacao;
                    usuUpdate.perfil = tipoUsuario;
                    usuUpdate.CRN = crn;
                    BancoDadosSingleton.Instance.SaveChanges();
                }

                nMensagemAviso("Os dados foram Salvos.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar.\n\n" + ex.Message);
            }
        }

        [Obsolete]
        public void CriarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, string crm)
        {

            //CRYPTOGRAFAR SENHA
            senha = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "MD5");

            try
            {
                Login loginInsert = new Login();

                loginInsert.usuario = usuario;
                loginInsert.senha = senha;
                loginInsert.nome = nome;
                loginInsert.email = email;
                loginInsert.situacao = situacao;
                loginInsert.perfil = tipoUsuario;
                //loginInsert.CRM = crm;

                BancoDadosSingleton.Instance.Login.Add(loginInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("O seu usuário foi criado");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar o usuário." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public bool VerificarExisteUsuario(string usuario)
        {
            var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuario select c.usuario).ToList();

            if (usuarioLog.Count > 0)
                return true;

            return false;
        }

        public void Deletar(string usuario)
        {
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Login WHERE usuario = '{usuario}'";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
            nMensagemErro("Usuário foi excluído");
        }

        public string GerarNovaSenha()
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();
            string senha = string.Empty;

            string senhaDescrip = GeraSenhaAleatoria();
            senha = senhaDescrip;
            
            return senhaDescrip;
        }

        [Obsolete]
        public void SalvarNovaSenha(string usuario, string senha)
        {
            var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();
            senha = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "MD5");

            usuUpdate.usuario = usuario;
            usuUpdate.senha = senha;
            BancoDadosSingleton.Instance.SaveChanges();
        }

        private string GeraSenhaAleatoria()
        {
            const string charPerm = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";

            
            string permitido = "";
            permitido += charPerm;

            int caracteres_minimo = 5;
            int caracteres_maximo = 10;
            int numero_caracteres = Crypto.RandomInteger(caracteres_minimo, caracteres_maximo);

            string _senha = "";
            _senha += RandomChar(charPerm);

            while (_senha.Length < numero_caracteres)
                _senha += RandomChar(permitido);

            _senha = RandomizeString(_senha);
            return _senha;
        }

        private string RandomChar(string str)
        {
            return str.Substring(Crypto.RandomInteger(0, str.Length - 1), 1);
        }

        private string RandomizeString(string str)
        {
            string resultado = "";
            while (str.Length > 0)
            {
                // Pega um numero aleatorio
                int i = Crypto.RandomInteger(0, str.Length - 1);
                resultado += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return resultado;
        }

        public bool CheckAvailable()
        {
            using (var db = new NutreasyEntities())
            {
                var checkDate = db.Database.Connection.CreateCommand();
                checkDate.CommandText = $"SELECT CURRENT_DATE AS dataAtual";
                db.Database.Connection.Open();
                using (IDataReader dr = checkDate.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        return Convert.ToBoolean(Convert.ToString(dr["dataAtual"])==Convert.ToString(DateTime.Now));
                    }
                }
                    db.Database.Connection.Close();
            }

            return false;
        }

    }
}