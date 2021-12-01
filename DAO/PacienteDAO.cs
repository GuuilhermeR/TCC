using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using NutriEz;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity.SqlServer;
using NutriEz.Banco_de_Dados;
using System.Data.Entity;

namespace ProjetoTCC
{
    public class PacienteDAO
    {
        public PacienteDAO()
        {
        }

        public SQLiteConnection objConexao;

        public void Salvar( Paciente paciente, byte[] vetorIMG)
        {
            //if (VerificarPacienteExiste(Convert.ToInt64(paciente.codPaciente)))
            if (paciente.codPaciente != 0)
            {
                var pacienteUpdate = (from c in BancoDadosSingleton.Instance.Paciente where c.codPaciente == paciente.codPaciente select c).Single();

                pacienteUpdate.nome = paciente.nome;
                pacienteUpdate.CPF = paciente.CPF;
                pacienteUpdate.dtNasc = paciente.dtNasc;
                pacienteUpdate.email = paciente.email;
                pacienteUpdate.CEP = paciente.CEP;
                pacienteUpdate.endereco = paciente.endereco;
                pacienteUpdate.numero = paciente.numero;
                pacienteUpdate.bairro = paciente.bairro;
                pacienteUpdate.municipio = paciente.municipio;
                pacienteUpdate.UF = paciente.UF;
                pacienteUpdate.complemento = paciente.complemento;
                pacienteUpdate.telefone = paciente.telefone;
                pacienteUpdate.celular = paciente.celular;
                pacienteUpdate.sexo = paciente.sexo;
                if (vetorIMG != null)
                    pacienteUpdate.imagem = vetorIMG;

                BancoDadosSingleton.Instance.SaveChanges();
            }
            else
            {
                try
                {
                    Paciente pacienteInsert = new Paciente();

                    pacienteInsert.nome = paciente.nome;
                    pacienteInsert.CPF = paciente.CPF;
                    pacienteInsert.dtNasc = paciente.dtNasc;
                    pacienteInsert.email = paciente.email;
                    pacienteInsert.CEP = paciente.CEP;
                    pacienteInsert.endereco = paciente.endereco;
                    pacienteInsert.numero = paciente.numero;
                    pacienteInsert.bairro = paciente.bairro;
                    pacienteInsert.municipio = paciente.municipio;
                    pacienteInsert.UF = paciente.UF;
                    pacienteInsert.complemento = paciente.complemento;
                    pacienteInsert.telefone = paciente.telefone;
                    pacienteInsert.celular = paciente.celular;
                    pacienteInsert.sexo = paciente.sexo;
                    if (vetorIMG != null)
                        pacienteInsert.imagem = vetorIMG;

                    BancoDadosSingleton.Instance.Paciente.Add(pacienteInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show($"{ve.PropertyName} - {ve.ErrorMessage}");
                        }
                    }
                    throw;
                }
                
            }

        }

        public bool VerificarPacienteExiste(long pacienteBuscar)
        {
            var paciente = string.Empty;
            try
            {
                paciente = (from a in BancoDadosSingleton.Instance.Paciente where a.codPaciente == pacienteBuscar select a.nome).Single();
            }
            catch
            {
                return false;
            }

            if (paciente != string.Empty)
            {
                return true;
            }

            return false;
        }

        public void Deletar(double codPaciente)
        {
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Paciente WHERE codPaciente IN ({codPaciente})";
                db.Database.Connection.Open();
                delete.ExecuteNonQuery();
                db.Database.Connection.Close();
            }
        }

        public List<Paciente> Buscar(string nomePaciente)
        {
            List<Paciente> paciente = new List<Paciente>();
            try
            {
                if (nomePaciente != string.Empty)
                {
                    var pacienteBuscar = (from p in BancoDadosSingleton.Instance.Paciente where (p.nome.ToUpper()).Contains(nomePaciente.ToUpper()) select p).ToList();
                    paciente = pacienteBuscar;
                }
                else
                {
                    var pacienteBuscar = (from p in BancoDadosSingleton.Instance.Paciente select p).ToList();
                    paciente = pacienteBuscar;
                }
                if (paciente.Count > 0)
                {
                    return paciente;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<Paciente> GetEmail(int codPaciente)
        {
            try
            {
                var pacienteBuscar = (from p in BancoDadosSingleton.Instance.Paciente where p.codPaciente == codPaciente select p).ToList();

                if (pacienteBuscar.Count > 0)
                {
                    return pacienteBuscar;
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