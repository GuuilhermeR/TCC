using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Transactions;
using TCC2.Banco_de_Dados;
using static Classes.ExibidorMensagem;

namespace ProjetoTCC
{
    public class AntropometriaDAO
    {

        public AntropometriaDAO() { }

        public void Salvar()
        {
            try
            {
                Antropometria antropometriaInsert = new Antropometria();



                BancoDadosSingleton.Instance.Antropometria.Add(antropometriaInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("Antropometria foi salvo!");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

    }
}
