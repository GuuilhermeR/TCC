﻿using System;
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

namespace ProjetoTCC
{
    public class AlimentoDAO
    {
        public AlimentoDAO()
        {
        }

        public void Salvar(string alimento, double qtd, double kCal, double proteina, double carboidrato, double lipidio, string nomeTabela)
        {
            try
            {
                Alimentos alimentosInsert = new Alimentos();

                alimentosInsert.nomeAlimento = alimento;
                alimentosInsert.qtd = qtd;
                alimentosInsert.kcal = kCal;
                alimentosInsert.prot = proteina;
                alimentosInsert.carbo = carboidrato;
                alimentosInsert.lipidio = lipidio;
                alimentosInsert.nomeTabela = nomeTabela;

                BancoDadosSingleton.Instance.Alimentos.Add(alimentosInsert);
                BancoDadosSingleton.Instance.SaveChanges();                
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }

        public void Update(int codAlimento, string alimento, double qtd, double kCal, double proteina, double carboidrato, double lipidio, string nomeTabela)
        {
            try
            {
                //var aliUpdate = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.codAlimento == codAlimento  && ali.nomeTabela == nomeTabela select ali).Single();

                //aliUpdate.codAlimento = codAlimento;
                //aliUpdate.nomeAlimento = alimento;
                //aliUpdate.qtd = qtd;
                //aliUpdate.kcal = kCal;
                //aliUpdate.prot = proteina;
                //aliUpdate.carbo = carboidrato;
                //aliUpdate.lipidio = lipidio;
                //aliUpdate.nomeTabela = nomeTabela;

                //BancoDadosSingleton.Instance.Alimentos.Add(aliUpdate);
                //BancoDadosSingleton.Instance.SaveChanges();

                using (var db = new NutreasyEntities())
                {
                    var update = db.Database.Connection.CreateCommand();
                    update.CommandText = $"UPDATE Alimentos SET kcal={kCal.ToString().Replace(",", ".")}, prot={proteina.ToString().Replace(",", ".")}, carbo={carboidrato.ToString().Replace(",", ".")}" +
                        $", lipidio={lipidio.ToString().Replace(",", ".")}, qtd={qtd.ToString().Replace(",", ".")}, nomeAlimento='{alimento}', nomeTabela='{nomeTabela}'  WHERE codAlimento = {codAlimento}";
                    db.Database.Connection.Open();
                    update.ExecuteNonQuery();
                    db.SaveChanges();
                    BancoDadosSingleton.Instance.SaveChanges();
                    db.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                nMensagemErro("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException);
            }
        }
        public bool VerificarAlimento(string alimentoVerificar)
        {
            var alimentoRetorno = string.Empty;
            try
            {
                var Alimentos = (from ali in BancoDadosSingleton.Instance.Alimentos where (ali.nomeAlimento.ToUpper()).Contains(alimentoVerificar.ToUpper()) select ali).Single();
                alimentoRetorno = Alimentos.ToString();
            }
            catch
            {
                return false;
            }

            if (alimentoRetorno != string.Empty)
            {
                return true;
            }

            return false;
        }

        public bool ExisteAlimento(string nomeAlimento, string nomeTabela)
        {
            try
            {
                var Alimentos = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.nomeAlimento.ToUpper() == nomeAlimento.ToUpper() && ali.nomeTabela.ToUpper() == nomeTabela.ToUpper() select ali).ToList();
                if (Alimentos.Count > 0)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public List<long> RetornaCodAlimentoExistente(string nomeAlimento, string nomeTabela)
        {
            try
            {
                var Alimentos = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.nomeAlimento.ToUpper() == nomeAlimento.ToUpper() && ali.nomeTabela.ToUpper() == nomeTabela.ToUpper() select ali.codAlimento).ToList();
                if (Alimentos.Count > 0)
                {
                    return Alimentos;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public void Deletar(double codAlimento)
        {
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Alimentos WHERE codAlimento = {codAlimento}";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
            nMensagemErro("Alimento foi excluído");
        }

        public void DeletarTableImportError(string tabela)
        {
            loadStart();
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Alimentos WHERE nomeTabela = {tabela}";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
            loadStop();
        }

        public List<Alimentos> Buscar(string nomeAlimento, string nomeTabela)
        {
            try
            {
                List<Alimentos> agenda = new List<Alimentos>();
                if (nomeAlimento == string.Empty && nomeTabela == string.Empty)
                {
                    agenda = ((from a in BancoDadosSingleton.Instance.Alimentos select a).Distinct()).ToList();
                }
                else if (nomeAlimento != string.Empty && nomeTabela != string.Empty)
                {
                    agenda = ((from a in BancoDadosSingleton.Instance.Alimentos where (a.nomeAlimento.ToUpper()).Contains(nomeAlimento.ToUpper()) && (a.nomeTabela.ToUpper()).Contains(nomeTabela.ToUpper()) select a).Distinct()).ToList();
                }
                else
                {
                    agenda = ((from a in BancoDadosSingleton.Instance.Alimentos where (a.nomeTabela.ToUpper()).Contains(nomeTabela.ToUpper()) select a).Distinct()).ToList();
                }
                return agenda;
            }
            catch
            {
                return null;
            }
        }

        public List<Alimentos> BuscarTabelas()
        {
            List<Alimentos> teste = new List<Alimentos>();
            try
            {
                var agenda = ((from a in BancoDadosSingleton.Instance.Alimentos select a).Distinct()).ToList();
                teste = agenda;
                return teste;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}