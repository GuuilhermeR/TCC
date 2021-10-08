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
    public class AnamneseDAO
    {

        public AnamneseDAO() { }

        public void Salvar(int codPaciente, string anamnese)
        {
            try
            {
                loadStart();
                AnamnesePaciente anamneseInsert = new AnamnesePaciente();

                anamneseInsert.codPaciente = codPaciente;
                anamneseInsert.descAnamnese = anamnese;
                anamneseInsert.Data = DateTime.Now.ToString("dd/MM/yyyy");

                BancoDadosSingleton.Instance.AnamnesePaciente.Add(anamneseInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                loadStop();
                nMensagemAviso("Anamnese salva!");
            }
            catch (Exception ex)
            {
                loadStop();
                nMensagemErro("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }
        public void Deletar(int codPaciente, string data)
        {
            loadStart();
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Antropometria WHERE codPaciente = {codPaciente} AND Data = {data}";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
            loadStop();
            nMensagemAviso("Os dados de Anamnese foram excluídos!");
        }

        public List<AnamnesePaciente> CarregarAnamnese(string data)
        {
            try
            {
                var anamnese = (from a in BancoDadosSingleton.Instance.AnamnesePaciente where a.Data == data select a).ToList();
                if (anamnese.Count > 0)
                {
                    return anamnese;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<string> CarregarDataAnamnese(int codPaciente)
        {
            try
            {
                var anamnese = (from a in BancoDadosSingleton.Instance.AnamnesePaciente where a.codPaciente == codPaciente select a.Data).ToList();
                if (anamnese.Count > 0)
                {
                    return anamnese;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void SalvarConfig(string template, string texto, bool existe)
        {
            try
            {
                if (!existe)
                {
                    loadStart();
                    AnamneseConfig anamneseInsert = new AnamneseConfig();

                    anamneseInsert.Template = template;
                    anamneseInsert.Texto = texto;

                    BancoDadosSingleton.Instance.AnamneseConfig.Add(anamneseInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    loadStop();
                    nMensagemAviso("Template salvo!");
                }
                else
                {                    
                    loadStart();
                    var anamConfig = (from ali in BancoDadosSingleton.Instance.AnamneseConfig where ali.Template == template select ali).Single();

                    anamConfig.Template = template;
                    anamConfig.Texto = texto;

                    BancoDadosSingleton.Instance.AnamneseConfig.Add(anamConfig);
                    BancoDadosSingleton.Instance.SaveChanges();
                    loadStop();
                    nMensagemAviso("Template foi atualizado!");
                }
            }
            catch (Exception ex)
            {
                loadStop();
                if (ex.Message.ToLower().Contains("pk"))
                {
                    nMensagemErro("Já existe uma configuração com esse nome!");
                    return;
                }
                nMensagemErro("Ocorreu um erro ao salvar." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public List<AnamneseConfig> CarregarAnamneseConfig()
        {
            try
            {
                var anamnese = (from a in BancoDadosSingleton.Instance.AnamneseConfig select a).ToList();
                if (anamnese.Count > 0)
                {
                    return anamnese;
                }
                else
                {
                    return anamnese;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<AnamneseConfig> CarregarAnamneseTemplate(string template)
        {
            try
            {
                var anamnese = (from a in BancoDadosSingleton.Instance.AnamneseConfig where a.Template == template select a).ToList();
                if (anamnese.Count > 0)
                {
                    return anamnese;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
