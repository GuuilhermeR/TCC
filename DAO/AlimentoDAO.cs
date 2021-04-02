﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace ProjetoTCC
{
    public class AlimentoDAO
    {
        public AlimentoDAO()
        {
        }

        public void Salvar(string alimento, decimal qtd, decimal kCal, decimal proteina, decimal carboidrato, decimal lipidio, string nomeTabela)
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
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");

            }

        }

        public void Update(int codAlimento, string alimento, decimal qtd, decimal kCal, decimal proteina, decimal carboidrato, decimal lipidio)
        {
            try
            {
                var aliUpdate = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.codAlimento == codAlimento select ali).Single();

                aliUpdate.nomeAlimento = alimento;
                aliUpdate.qtd = qtd;
                aliUpdate.kcal = kCal;
                aliUpdate.prot = proteina;
                aliUpdate.carbo = carboidrato;
                aliUpdate.lipidio = lipidio;

                BancoDadosSingleton.Instance.Alimentos.Add(aliUpdate);
                BancoDadosSingleton.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");

            }

        }
        public bool VerificarAlimento(string alimentoVerificar)
        {
            var alimentoRetorno = "";
            try
            {
                var Alimentos = (from ali in BancoDadosSingleton.Instance.Alimentos where ali.nomeAlimento == alimentoVerificar select ali).Single();
                alimentoRetorno = Alimentos.ToString();
            }
            catch
            {
                return false;
            }

            if (alimentoRetorno != "")
            {
                return true;
            }

            return false;
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

        }

        public List<Alimentos> Buscar (string nomeAlimento, string nomeTabela)
        {
            try
            {
                List<Alimentos> agenda = new List<Alimentos>();
                if (nomeAlimento == "") {
                    agenda = ((from a in BancoDadosSingleton.Instance.Alimentos where a.nomeTabela == nomeTabela select a).Distinct()).ToList();
                }
                else
                {
                    agenda = ((from a in BancoDadosSingleton.Instance.Alimentos where a.nomeAlimento == nomeAlimento && a.nomeTabela == nomeTabela select a).Distinct()).ToList();
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
            List<Alimentos> teste= new List<Alimentos>();
            try
            {
                var agenda = ((from a in BancoDadosSingleton.Instance.Alimentos select a).Distinct()).ToList();
                teste = agenda;
                return teste;
            }
            catch
            {
                return null;
            }
        }
    }
}