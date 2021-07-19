using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;
using Classes;
using System.Web.Security;
using static Classes.ExibidorMensagem;

namespace TCC2
{
    public class UsuarioDAO
    {
        public UsuarioDAO()
        { }

        private Criptografador cript = new Criptografador();

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

        public List<string> getAllUsuarios()
        {
            try
            {
                var usuarios = (from c in TCC2.BancoDadosSingleton.Instance.Login select c.usuario).ToList();
                if (usuarios.Count > 0)
                {
                    return usuarios;
                }
            }
            catch
            {
                return null;

            }
            return null;
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
                    if(crn != "")
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

    }
}