using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace ProjetoTCC
{
    public class PacienteDAO
    {
        public PacienteDAO()
        {
        }

        public SQLiteConnection objConexao;

        public void Salvar(string nome, long cpf, string dtNasc, string email, string peso, string altura, double cep, long num, string telefone, string celular, string endereco, string bairro, string municipio, string uf, string complemento)
        {
            if (VerificarPacienteExiste(nome))
            {
                var pacienteUpdate = (from c in BancoDadosSingleton.Instance.Paciente where c.nome == nome select c).Single();

                pacienteUpdate.nome = nome;
                pacienteUpdate.CPF = cpf;
                pacienteUpdate.dtNasc = dtNasc;
                pacienteUpdate.email = email;
                pacienteUpdate.CEP = cep;
                pacienteUpdate.endereco = endereco;
                pacienteUpdate.numero = num;
                pacienteUpdate.bairro = bairro;
                pacienteUpdate.municipio = municipio;
                pacienteUpdate.UF = uf;
                pacienteUpdate.complemento = complemento;
                pacienteUpdate.telefone = telefone;

                BancoDadosSingleton.Instance.SaveChanges();
            }
            else
            {
                Paciente pacienteInsert = new Paciente();

                pacienteInsert.nome = nome;
                pacienteInsert.CPF = cpf;
                pacienteInsert.dtNasc = dtNasc;
                pacienteInsert.email = email;
                pacienteInsert.CEP = cep;
                pacienteInsert.endereco = endereco;
                pacienteInsert.numero = num;
                pacienteInsert.bairro = bairro;
                pacienteInsert.municipio = municipio;
                pacienteInsert.UF = uf;
                pacienteInsert.complemento = complemento;
                pacienteInsert.telefone = telefone;
                

                BancoDadosSingleton.Instance.Paciente.Add(pacienteInsert);
                BancoDadosSingleton.Instance.SaveChanges();
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
                if(nomePaciente != "")
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