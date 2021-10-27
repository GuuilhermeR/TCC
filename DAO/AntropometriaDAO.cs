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
using System.Data.Entity;
using Model;

namespace ProjetoTCC
{
    public class AntropometriaDAO
    {

        public AntropometriaDAO() { }

        public void Salvar(int codPaciente, double altura, double antebraco,double braco,double cintura,double coxa,double panturrilha,double peso, double punho, double quadril, double torax, double pescoco, double abdome, string data, string grauAtividade, int temGrauAtividade, int temCoefAtividade, string coefAtividade)
        {
            DateTime date = Convert.ToDateTime(data);
            try
            {
                if (!VerificarExisteSalvo(codPaciente, Convert.ToDateTime(data)))
                {
                    Antropometria antropometriaInsert = new Antropometria();

                    antropometriaInsert.codPaciente = codPaciente;
                    antropometriaInsert.altura = altura;
                    antropometriaInsert.antebraco = antebraco;
                    antropometriaInsert.braco = braco;
                    antropometriaInsert.cintura = cintura;
                    antropometriaInsert.coxa = coxa;
                    antropometriaInsert.panturrilha = panturrilha;
                    antropometriaInsert.peso = peso;
                    antropometriaInsert.punho = punho;
                    antropometriaInsert.quadril = quadril;
                    antropometriaInsert.torax = torax;
                    antropometriaInsert.pescoco = torax;
                    antropometriaInsert.abdome = torax;
                    antropometriaInsert.grauAtividade = grauAtividade;
                    antropometriaInsert.temGrauAtividade = temGrauAtividade;
                    antropometriaInsert.temCoefAtividade = temCoefAtividade;
                    antropometriaInsert.coefAtividade = coefAtividade;
                    antropometriaInsert.Data = Convert.ToDateTime(date.ToString("yyyy-MM-dd HH:mm"));

                    BancoDadosSingleton.Instance.Antropometria.Add(antropometriaInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    BancoDadosSingleton.Instance.Entry(antropometriaInsert).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    using (var db = new NutreasyEntities())
                    {
                        var update = db.Database.Connection.CreateCommand();
                        update.CommandText = $"UPDATE Antropometria SET altura={altura}, braco={braco}, punho={punho}, cintura={cintura}, torax={torax}, quadril={quadril}" +
                            $", panturrilha={panturrilha}, antebraco={antebraco}, coxa={coxa}, peso={peso}, pescoco={pescoco}, abdome={abdome}, grauAtividade='{grauAtividade}'" +
                            $"WHERE codPaciente = {codPaciente} AND Data='{date.ToString("yyyy-MM-dd HH:mm")}'";
                        db.Database.Connection.Open();
                        update.ExecuteNonQuery();                        
                        db.Database.Connection.Close();
                    }
                }
               
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
                select.CommandText = $"SELECT COUNT(0) AS Existe FROM Antropometria WHERE data>='{data.ToString("yyyy-MM-dd HH:mm:ss")}' AND data<='{data.ToString("yyyy-MM-dd")} 23:59:59' AND codPaciente={paciente}";
                db.Database.Connection.Open();
                select.ExecuteNonQuery();
                IDataReader dr = select.ExecuteReader();
                if (dr.Read())
                {
                    return (bool)(Convert.ToInt32(dr["Existe"])>0);
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

        public List<Antropometria> CarregarUltimaAntropometria()
        {
            List<Antropometria> listAntro = new List<Antropometria>();
            if (!String.IsNullOrEmpty(PacienteModel.codPacienteModel))
            {
                using (var db = new NutreasyEntities())
                {
                    var select = db.Database.Connection.CreateCommand();

                    select.CommandText = $"SELECT A.codPaciente, A.peso, A.altura, A.grauAtividade, A.temGrauAtividade," +
                                         $" A.temCoefAtividade, A.coefAtividade, P.codPaciente, P.dtNasc, P.sexo " +
                                         $"FROM Antropometria A " +
                                         $"LEFT JOIN Paciente P " +
                                         $"ON A.codPaciente=P.codPaciente " +
                                         $"WHERE A.codPaciente = {PacienteModel.codPacienteModel} " +
                                         $"AND A.data=(SELECT MAX(An.data) FROM Antropometria An WHERE An.codPaciente = {PacienteModel.codPacienteModel})";

                    db.Database.Connection.Open();
                    select.ExecuteNonQuery();
                    IDataReader dr = select.ExecuteReader();
                    if (dr.Read())
                    {
                        Antropometria antropometria = new Antropometria() {
                            codPaciente = Convert.ToInt64(dr["codPaciente"]),
                            peso = Convert.ToDouble(dr["peso"]),
                            grauAtividade = Convert.ToString(dr["grauAtividade"]),
                            altura = Convert.ToDouble(dr["altura"]),
                            temGrauAtividade = Convert.ToInt32(dr["temGrauAtividade"]),
                            temCoefAtividade = Convert.ToInt32(dr["temCoefAtividade"]),
                            coefAtividade = Convert.ToString(dr["coefAtividade"])
                        };
                        Paciente paciente = new Paciente
                        {
                            codPaciente = Convert.ToInt64(dr["codPaciente"]),
                            dtNasc = Convert.ToString(dr["dtNasc"]),
                            sexo = Convert.ToString(dr["sexo"])
                        };
                        antropometria.Paciente = paciente;

                        listAntro.Add(antropometria);
                    }
                    dr.Close();
                    db.Database.Connection.Close();
                }
            }
            return listAntro;
        }

        public List<Antropometria> CarregarInfos(int codPaciente, DateTime data)
        {
            List<Antropometria> antro = new List<Antropometria>();
            using (var db = new NutreasyEntities())
            {
                var select = db.Database.Connection.CreateCommand();
                select.CommandText = $"SELECT altura, braco, punho, cintura, torax, quadril, panturrilha, " +
                    $"antebraco, coxa, peso, pescoco, abdome, temCoefAtividade, temGrauAtividade, coefAtividade, grauAtividade" +
                    $" FROM Antropometria " +
                    $" WHERE codPaciente = {codPaciente} " +
                    $" AND Data>='{data.ToString("yyyy-MM-dd HH:mm")}' AND data<='{data.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm")}'";
                db.Database.Connection.Open();

                select.ExecuteNonQuery();
                IDataReader dr = select.ExecuteReader();
                if (dr.Read())
                {
                    Antropometria antrop = new Antropometria();

                    antrop.altura = (double)(dr["altura"]);
                    antrop.antebraco = (double)(dr["antebraco"]);
                    antrop.braco = (double)(dr["braco"]);
                    antrop.cintura = (double)(dr["cintura"]);
                    antrop.coxa = (double)(dr["coxa"]);
                    antrop.panturrilha = (double)(dr["panturrilha"]);
                    antrop.peso = (double)(dr["peso"]);
                    antrop.punho = (double)(dr["punho"]);
                    antrop.quadril = (double)(dr["quadril"]);
                    antrop.torax = (double)(dr["torax"]);
                    antrop.pescoco = (double)(dr["torax"]);
                    antrop.abdome = (double)(dr["torax"]);
                    antrop.temCoefAtividade = (long)(dr["temCoefAtividade"]);
                    antrop.temGrauAtividade = (long)(dr["temGrauAtividade"]);
                    antrop.coefAtividade = (string)(dr["coefAtividade"]);
                    antrop.grauAtividade = (string)(dr["grauAtividade"]);

                    antro.Add(antrop);
                }

                db.Database.Connection.Close();
            }
            return antro;
        }

    }
}
