using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace ProjetoTCC
{
    public class PacienteDAO
    {
        public PacienteDAO()
        {
        }

        public SQLiteConnection objConexao;

        public void Salvar(string nome, double cpf, string dtNasc, string email, double cep, double num, string telefone, string celular, string endereco, string bairro, string municipio, string uf, string complemento, byte[] vetorIMG)
        {
            if (VerificarPacienteExiste(nome))
            {
                var pacienteUpdate = (from c in BancoDadosSingleton.Instance.Paciente where c.nome == nome select c).Single();

                pacienteUpdate.nome = nome;
                pacienteUpdate.CPF = (long)cpf;
                pacienteUpdate.dtNasc = dtNasc;
                pacienteUpdate.email = email;
                pacienteUpdate.CEP = cep;
                pacienteUpdate.endereco = endereco;
                pacienteUpdate.numero = (long?)num;
                pacienteUpdate.bairro = bairro;
                pacienteUpdate.municipio = municipio;
                pacienteUpdate.UF = uf;
                pacienteUpdate.complemento = complemento;
                pacienteUpdate.telefone = telefone;
                if (vetorIMG != null)
                    pacienteUpdate.imagem = vetorIMG;

                BancoDadosSingleton.Instance.SaveChanges();
            }
            else
            {
                try
                {
                    Paciente pacienteInsert = new Paciente();

                    pacienteInsert.nome = nome;
                    pacienteInsert.CPF = (long)cpf;
                    pacienteInsert.dtNasc = dtNasc;
                    pacienteInsert.email = email;
                    pacienteInsert.CEP = cep;
                    pacienteInsert.endereco = endereco;
                    pacienteInsert.numero = (long?)num;
                    pacienteInsert.bairro = bairro;
                    pacienteInsert.municipio = municipio;
                    pacienteInsert.UF = uf;
                    pacienteInsert.complemento = complemento;
                    pacienteInsert.telefone = telefone;
                    pacienteInsert.celular = celular;
                    if (vetorIMG != null)
                        pacienteInsert.imagem = vetorIMG;

                    BancoDadosSingleton.Instance.Paciente.Add(pacienteInsert);
                    BancoDadosSingleton.Instance.SaveChanges();
                    MessageBox.Show($"");

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

        public bool VerificarPacienteExiste(string pacienteBuscar)
        {
            var paciente = "";
            var agendado = "";
            try
            {
                paciente = (from a in BancoDadosSingleton.Instance.Agenda where a.paciente == pacienteBuscar select a.paciente).Single();
                agendado = paciente.ToString();
            }
            catch
            {
                return false;
            }

            if (agendado != "")
            {
                return true;
            }

            return false;
        }

        public void Deletar(double CPF)
        {
            using (var db = new NutreasyEntities())
            {
                var delete = db.Database.Connection.CreateCommand();
                delete.CommandText = $"DELETE FROM Paciente WHERE cpf IN ({CPF})";
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
                if (nomePaciente != "")
                {
                    var pacienteBuscar = (from p in BancoDadosSingleton.Instance.Paciente where p.nome == nomePaciente select p).ToList();
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
            catch
            {
                return null;
            }
        }
    }
}