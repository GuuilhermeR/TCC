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

        public void Salvar(int codPaciente, double altura, double antebraco,double braco,double cintura,double coxa,double panturrilha,double peso, double punho, double quadril, double torax)
        {
            try
            {
                Antropometria antropometriaInsert = new Antropometria();

                antropometriaInsert.codPaciente = codPaciente;
                antropometriaInsert.Data = DateTime.Now.ToString("dd/MM/yyyy");
                antropometriaInsert.altura = altura;
                antropometriaInsert.antebraco = antebraco;
                antropometriaInsert.braco = braco;
                antropometriaInsert.cintura = cintura;
                antropometriaInsert.coxa = coxa;
                antropometriaInsert.panturrilha = panturrilha;
                antropometriaInsert.peso= peso;
                antropometriaInsert.punho= punho;
                antropometriaInsert.quadril= quadril;
                antropometriaInsert.torax= torax;

                BancoDadosSingleton.Instance.Antropometria.Add(antropometriaInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("Antropometria foi salvo!");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public void Deletar(int codPaciente, string data)
        {
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Antropometria WHERE codPaciente = {codPaciente} AND Data = {data}";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
            nMensagemAviso("Os dados antropométrico foram excluídos!");
        }

        //public List<Antropometria> Buscar()
        //{
        //    try
        //    {
        //        List<Antropometria> antropometria = new List<Antropometria>();
        //        antropometria = ((from a in BancoDadosSingleton.Instance.Antropometria select a).Distinct()).ToList();
        //        
        //        return antropometria;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
