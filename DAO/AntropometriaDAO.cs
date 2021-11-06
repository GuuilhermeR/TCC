using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using NutriEz;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using NutriEz.Banco_de_Dados;
using static Classes.HelperFuncoes;
using System.Data.Entity;
using Model;

namespace ProjetoTCC
{
    public class AntropometriaDAO
    {

        public AntropometriaDAO() { }

        public void Salvar(Antropometria antro)
        {
            try
            {
                if (!VerificarExisteSalvo((int)antro.codPaciente, antro.Data))
                {
                    Antropometria antropometriaInsert = new Antropometria();

                    antropometriaInsert.codPaciente = antro.codPaciente;
                    if(antro.altura > 0)
                    antropometriaInsert.altura = antro.altura;
                    if(antro.antebraco > 0)
                    antropometriaInsert.antebraco = antro.antebraco;
                    if(antro.braco > 0)
                    antropometriaInsert.braco = antro.braco;
                    if(antro.cintura > 0)
                    antropometriaInsert.cintura = antro.cintura;
                    if(antro.coxa > 0)
                    antropometriaInsert.coxa = antro.coxa;
                    if(antro.panturrilha > 0)
                    antropometriaInsert.panturrilha = antro.panturrilha;
                    if(antro.peso > 0)
                    antropometriaInsert.peso = antro.peso;
                    if(antro.punho > 0)
                    antropometriaInsert.punho = antro.punho;
                    if(antro.quadril > 0)
                    antropometriaInsert.quadril = antro.quadril;
                    if(antro.torax > 0)
                    antropometriaInsert.torax = antro.torax;
                    if(antro.pescoco > 0)
                    antropometriaInsert.pescoco = antro.pescoco;
                    if(antro.abdome > 0)
                    antropometriaInsert.abdome = antro.abdome;
                    if(!string.IsNullOrEmpty(antro.grauAtividade))
                    antropometriaInsert.grauAtividade = antro.grauAtividade;
                    if(antro.temGrauAtividade > 0)
                    antropometriaInsert.temGrauAtividade = antro.temGrauAtividade;
                    if (antro.temCoefAtividade > 0)
                    antropometriaInsert.temCoefAtividade = antro.temCoefAtividade;
                    if(!string.IsNullOrEmpty(antro.coefAtividade))
                    antropometriaInsert.coefAtividade = antro.coefAtividade;
                    antropometriaInsert.Data = antro.Data;

                    BancoDadosSingleton.Instance.Antropometria.Add(antropometriaInsert);
                    BancoDadosSingleton.Instance.SaveChanges();

                }
                else
                {
                    using (var db = new NutreasyEntities())
                    {
                        var update = db.Database.Connection.CreateCommand();
                        update.CommandText = $"UPDATE Antropometria SET altura={antro.altura}, braco={antro.braco}, punho={antro.punho}, cintura={antro.cintura}, torax={antro.torax}, quadril={antro.quadril}" +
                            $", panturrilha={antro.panturrilha}, antebraco={antro.antebraco}, coxa={antro.coxa}, peso={antro.peso}, pescoco={antro.pescoco}, abdome={antro.abdome}, grauAtividade='{antro.grauAtividade}'" +
                            $"WHERE codPaciente = {antro.codPaciente} AND Data='{antro.Data}'";
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
                            codPaciente = dr["codPaciente"] == DBNull.Value  ? 0 : Convert.ToInt64(dr["codPaciente"]),
                            peso = dr["peso"] == DBNull.Value ? 0 : Convert.ToDouble(dr["peso"]),
                            grauAtividade = dr["grauAtividade"] == DBNull.Value ? string.Empty : Convert.ToString(dr["grauAtividade"]),
                            altura = dr["altura"] == DBNull.Value ? 0 : Convert.ToDouble(dr["altura"]),
                            temGrauAtividade = dr["temGrauAtividade"] == DBNull.Value ? 0 : Convert.ToInt32(dr["temGrauAtividade"]),
                            temCoefAtividade = dr["temCoefAtividade"] == DBNull.Value ? 0 : Convert.ToInt32(dr["temCoefAtividade"]),
                            coefAtividade = dr["coefAtividade"] == DBNull.Value ? string.Empty : Convert.ToString(dr["coefAtividade"])
                        };
                        Paciente paciente = new Paciente
                        {
                            codPaciente = dr["codPaciente"] == DBNull.Value ? 0 : Convert.ToInt64(dr["codPaciente"]),
                            dtNasc = dr["dtNasc"] == DBNull.Value ? string.Empty : Convert.ToString(dr["dtNasc"]),
                            sexo = dr["sexo"] == DBNull.Value ? string.Empty : Convert.ToString(dr["sexo"])
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

                    antrop.altura = dr["altura"] == DBNull.Value ? 0 : (double)(dr["altura"]);
                    antrop.antebraco = dr["antebraco"] == DBNull.Value ? 0 : (double)(dr["antebraco"]);
                    antrop.braco = dr["braco"] == DBNull.Value ? 0 : (double)(dr["braco"]);
                    antrop.cintura = dr["cintura"] == DBNull.Value ? 0 : (double)(dr["cintura"]);
                    antrop.coxa = dr["coxa"] == DBNull.Value ? 0 : (double)(dr["coxa"]);
                    antrop.panturrilha = dr["panturrilha"] == DBNull.Value ? 0 : (double)(dr["panturrilha"]);
                    antrop.peso = dr["peso"] == DBNull.Value ? 0 : (double)(dr["peso"]);
                    antrop.punho = dr["punho"] == DBNull.Value ? 0 : (double)(dr["punho"]);
                    antrop.quadril = dr["quadril"] == DBNull.Value ? 0 : (double)(dr["quadril"]);
                    antrop.torax = dr["torax"] == DBNull.Value ? 0 : (double)(dr["torax"]);
                    antrop.pescoco = dr["pescoco"] == DBNull.Value ? 0 : (double)(dr["pescoco"]);
                    antrop.abdome = dr["abdome"] == DBNull.Value ? 0 : (double)(dr["abdome"]);
                    antrop.temCoefAtividade = dr["temCoefAtividade"] == DBNull.Value ? 0 : (long)(dr["temCoefAtividade"]);
                    antrop.temGrauAtividade = dr["temGrauAtividade"] == DBNull.Value ? 0 : (long)(dr["temGrauAtividade"]);
                    antrop.coefAtividade = dr["coefAtividade"] == DBNull.Value ? string.Empty : (string)(dr["coefAtividade"]);
                    antrop.grauAtividade = dr["grauAtividade"] == DBNull.Value ? string.Empty : (string)(dr["grauAtividade"]);

                    antro.Add(antrop);
                }

                db.Database.Connection.Close();
            }
            return antro;
        }

    }
}
