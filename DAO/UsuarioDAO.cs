using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using NutriEz.Banco_de_Dados;
using Classes;
using System.Web.Security;
using static Classes.HelperFuncoes;
using NutriEz.Classes;
using System.Data.Entity;

namespace NutriEz
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
            if (usuarioLogin == string.Empty)
            {
                return;
            }
            try
            {
                var usuarioLogado = (from c in NutriEz.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogin select c.nome).FirstOrDefault();
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

        public void setAcesso(string usuario, DateTime dataHora, bool terminou)
        {
            var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();

            usuUpdate.usuario = usuario;
            usuUpdate.dtHoraUltAcesso = dataHora;
            if (terminou)
                usuUpdate.podeLogar = 0;

            BancoDadosSingleton.Instance.SaveChanges();
            BancoDadosSingleton.Instance.Entry(usuUpdate).State = EntityState.Modified;
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
                var usuarioLog = (from c in NutriEz.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogado && c.senha == senha && c.situacao.ToLower() == "ativo" select c).ToList();
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
            if (usuario != string.Empty)
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
            List<Login> emailUsuario = new List<Login>();
            if (usuario != string.Empty)
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
                    if (crn != string.Empty)
                        usuUpdate.CRN = crn;

                    BancoDadosSingleton.Instance.SaveChanges();
                BancoDadosSingleton.Instance.Entry(usuUpdate).State = EntityState.Modified;
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
                    BancoDadosSingleton.Instance.Entry(usuUpdate).State = EntityState.Modified;
                }

                nMensagemAviso("Os dados foram Salvos.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar.\n\n" + ex.Message);
            }
        }

        [Obsolete]
        public void CriarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, string crn)
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
                loginInsert.podeLogar = 1;
                if(!string.IsNullOrEmpty(crn))
                loginInsert.CRN = crn;

                BancoDadosSingleton.Instance.Login.Add(loginInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("O seu usuário foi criado");
                BancoDadosSingleton.Instance.Entry(loginInsert).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar o usuário." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public bool VerificarExisteUsuario(string usuario, string perfil)
        {
            List<string> usuarioLog = new List<string>();
            if(!string.IsNullOrEmpty(usuario))
            usuarioLog = (from c in NutriEz.BancoDadosSingleton.Instance.Login where c.usuario == usuario select c.usuario).ToList();
            else if (!string.IsNullOrEmpty(perfil))
            usuarioLog = (from c in NutriEz.BancoDadosSingleton.Instance.Login where c.perfil == perfil select c.usuario).ToList();

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

        public bool CheckAvailable(string usuario)
        {
            using (var db = new NutreasyEntities())
            {
                var checkDate = db.Database.Connection.CreateCommand();
                checkDate.CommandText = $"SELECT dtHoraUltAcesso, podeLogar FROM Login WHERE usuario='{usuario}'";
                db.Database.Connection.Open();
                using (IDataReader dr = checkDate.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (Convert.ToBoolean(Convert.ToInt64(dr["podeLogar"]) == 0))
                        {
                            return true;
                        }
                        else
                        {
                            return Convert.ToBoolean(Convert.ToDateTime(dr["dtHoraUltAcesso"]) > Convert.ToDateTime(DateTime.Now));
                        }
                    }
                }
                db.Database.Connection.Close();
            }
            return false;
        }

    }
}