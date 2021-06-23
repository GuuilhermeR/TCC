using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TCC2.Banco_de_Dados;

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

        public object getUsuario()
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

        public bool validarLogin(string usuarioLogado, string senha)
        {
            try
            {
                var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogado && c.senha == senha select c).ToList();
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

        public void AlterarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, bool alterarSenha)
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();

            try
            {

                if (alterarSenha)
                {

                    var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();

                    usuUpdate.nome = nome;
                    usuUpdate.senha = senha;
                    usuUpdate.email = email;
                    usuUpdate.situacao = situacao;
                    usuUpdate.perfil = tipoUsuario;

                    BancoDadosSingleton.Instance.Login.Add(usuUpdate);
                    BancoDadosSingleton.Instance.SaveChanges();

                }
                else
                {
                    var usuUpdate = (from usu in BancoDadosSingleton.Instance.Login where usu.usuario == usuario select usu).Single();

                    usuUpdate.nome = nome;
                    usuUpdate.email = email;
                    usuUpdate.situacao = situacao;
                    usuUpdate.perfil = tipoUsuario;

                    BancoDadosSingleton.Instance.Login.Add(usuUpdate);
                    BancoDadosSingleton.Instance.SaveChanges();
                }

                Interaction.MsgBox("Os dados foram Salvos.", MsgBoxStyle.OkOnly, "SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar.\n\n" + ex.Message, MsgBoxStyle.OkOnly, "ERRO AO SALVAR");
            }
        }

        public void CriarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, bool alterarSenha)
        {
            try
            {
                Login loginInsert = new Login();

                loginInsert.usuario = usuario;
                loginInsert.senha = senha;
                loginInsert.nome = nome;
                loginInsert.email = email;
                loginInsert.situacao = situacao;
                loginInsert.perfil = tipoUsuario;

                BancoDadosSingleton.Instance.Login.Add(loginInsert);
                BancoDadosSingleton.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o usuário." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");
            }
        }

        public bool VerificarExisteUsuario(string usuario)
        {
            var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuario select c.usuario).ToList();

            if (usuarioLog.Count > 0)
                return true;

            return false;
        }
    }
}