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
                AnamnesePaciente anamneseInsert = new AnamnesePaciente();

                anamneseInsert.codPaciente = codPaciente;
                anamneseInsert.descAnamnese = anamnese;
                anamneseInsert.Data = DateTime.Now.ToString("dd/MM/yyyy");

                BancoDadosSingleton.Instance.AnamnesePaciente.Add(anamneseInsert);
                BancoDadosSingleton.Instance.SaveChanges();
                nMensagemAviso("Anamnese salva!");
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
            nMensagemAviso("Os dados de Anamnese foram excluídos!");
        }
    }
}
