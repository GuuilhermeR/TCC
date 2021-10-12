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
using static Classes.HelperFuncoes;

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
                antropometriaInsert.Data= DateTime.Now;

                BancoDadosSingleton.Instance.Antropometria.Add(antropometriaInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                BancoDadosSingleton.Instance.Entry(antropometriaInsert).State = System.Data.Entity.EntityState.Modified;
                nMensagemAviso("Antropometria foi salvo!");
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public bool VerificarExisteSalvo(int paciente, DateTime data)
        {
            using (var db = new NutreasyEntities())
            {
                var select = db.Database.Connection.CreateCommand();
                select.CommandText = $"SELECT COUNT(0) AS Existe FROM AGENDA WHERE data='{data.ToString("yyyy-MM-dd HH:mm:ss")}' AND paciente ='{paciente}'";
                db.Database.Connection.Open();
                select.ExecuteNonQuery();
                IDataReader dr = select.ExecuteReader();
                if (dr.Read())
                {
                    return (bool)dr["Existe"];
                }
                return false;
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
            nMensagemAviso("Os dados antropométricos foram excluídos!");
        }

        public List<Antropometria> Buscar()
        {
            try
            {
                List<Antropometria> antropometria = new List<Antropometria>();
                antropometria = ((from a in BancoDadosSingleton.Instance.Antropometria select a).Distinct()).ToList();

                return antropometria;
            }
            catch
            {
                return null;
            }
        }

        public List<DateTime> BuscarData(int codPaciente)
        {
            try
            {
                List<DateTime> antropometria = ((from a in BancoDadosSingleton.Instance.Antropometria 
                                                 where a.codPaciente == codPaciente 
                                                 select a.Data).Distinct()).ToList();

                return antropometria;
            }
            catch
            {
                return null;
            }
        }
    }
}
