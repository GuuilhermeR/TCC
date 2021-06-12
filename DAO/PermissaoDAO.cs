using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2.Banco_de_Dados;

namespace DAO
{
    public class PermissaoDAO
    {
        public PermissaoDAO() { }

        public bool temPermissao(string usuario, string nameAba)
        {
            try
            {
                var temPerm = (from p in TCC2.BancoDadosSingleton.Instance.Permissao where p.usuario == usuario && p.programa == nameAba select p.funcaoPermitida).ToList();
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



    }
}
