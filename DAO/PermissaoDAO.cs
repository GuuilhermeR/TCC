using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2;
using TCC2.Banco_de_Dados;
using static Classes.ExibidorMensagem;

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
            var temPerm = (from p in TCC2.BancoDadosSingleton.Instance.Permissao where p.usuario == usuario && p.programa == tela && p.Login.perfil.ToLower() != "recepcionista" select p).ToList();
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

    }
}
