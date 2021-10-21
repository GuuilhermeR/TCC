using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2;
using TCC2.Banco_de_Dados;
using static Classes.HelperFuncoes;

namespace DAO
{
    public class PermissaoDAO
    {
        public PermissaoDAO() { }

        public bool temPermissao(string usuario, string nameAba)
        {
            try
            {
                var temPerm = (from p in TCC2.BancoDadosSingleton.Instance.Permissao where p.usuario == usuario && p.programa == nameAba select p).ToList();
                if (temPerm.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void AdicionarPermissao(string usuario, string telaPermissao)
        {
            if (!VerificarPermissao(usuario, telaPermissao))
            {
                Permissao permissaoInsert = new Permissao();

                permissaoInsert.usuario = usuario;
                permissaoInsert.programa = telaPermissao;

                BancoDadosSingleton.Instance.Permissao.Add(permissaoInsert);
                BancoDadosSingleton.Instance.SaveChanges();
            }
            else
            {
                nMensagemErro("Esse usuário ja possui permissão para essa tela");
            }

        }

        public bool VerificarPermissao(string usuario, string tela)
        {
            var temPerm = (from p in TCC2.BancoDadosSingleton.Instance.Permissao where p.usuario == usuario && p.programa == tela && p.Login.perfil.ToLower() != "nutricionista" || p.Login.perfil.ToLower() != "estudante" select p).ToList();
            if (temPerm.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Permissao> getAllPermissao()
        {
            try
            {
                var permUsuario = (from perm in TCC2.BancoDadosSingleton.Instance.Permissao select perm).ToList();
                if (permUsuario.Count > 0)
                {
                    return permUsuario;
                }
            }
            catch
            {
                return null;

            }
            return null;
        }

        public void RemoverPermissao(string usuario, string tela)
        {
            try
            {
                using (var db = new NutreasyEntities())
                {
                    var delete = db.Database.Connection.CreateCommand();
                    delete.CommandText = $"DELETE FROM Permissao WHERE usuario='{usuario}' AND programa='{tela}' ";
                    db.Database.Connection.Open();
                    delete.ExecuteNonQuery();
                    db.Database.Connection.Close();
                }
                nMensagemAviso("A consulta foi removida.");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao deletar!" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}
