﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;

namespace ProjetoTCC
{
    public class UsuarioDAO
    {
        public UsuarioDAO()
        {}

        private string usuario;
        private string senha;
        private string nome;

        public void setNomeUsuario(string usuarioLogin)
        {
            var usuarioLogado = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogin select c.nome).Single();
            nome = usuarioLogado.ToString();
            return;
        }

        public object getNomeUsuario()
        {
            return nome;
        }

        public object getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string usuarioLogado)
        {
            var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogado select c.usuario).Single();
            usuario = usuarioLog.ToString();
            return;
        }

        public object getUsuarioSenha()
        {
            return senha;
        }

        public void setUsuarioSenha(string senhaatual)
        {
            senha = senhaatual;
        }

        public bool verificarUsuarioLogado(string usuarioLogado, string senha)
        {
            var usuarioLog = (from c in TCC2.BancoDadosSingleton.Instance.Login where c.usuario == usuarioLogado && c.senha == senha select c.usuario).Single();
            if (usuarioLog != "")
                return true;

            return false;
        }

        public void Buscar(string usuario, DataGridView dtgDados)
        {
            string strSQL = string.Empty;
           // var config = new frmConfiguracoes();
            strSQL = $"SELECT * FROM Login\n";
            if (usuario != "")
            {
                strSQL = $"WHERE usuario = '{usuario}'";
            }
          
        }

        public void AlterarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, bool alterarSenha)
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();

            try
            {
                
                       if (alterarSenha)
                        {
                            string strSQL = $@"UPDATE Login senha='{senha}', nome='{nome}', email='{email}', situacao='{situacao}', tipoUsuario='{tipoUsuario}' WHERE usuario='{usuario}'";
                        }
                        else
                        {
                            string strSQL = $@"UPDATE Login nome='{nome}', email='{email}', situacao='{situacao}', tipoUsuario='{tipoUsuario}' WHERE usuario='{usuario}'";
                        }
                      
                        Interaction.MsgBox("Os dados foram Salvos.", MsgBoxStyle.OkOnly, "SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar.\n\n" + ex.Message, MsgBoxStyle.OkOnly, "ERRO AO SALVAR");
            }
        }

        public void CriarUsuario(string usuario, string senha, string nome, string email, string situacao, string tipoUsuario, bool alterarSenha)
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();

            try
            {
              
                        string strSQL = $@"INSERT INTO Login (usuario, senha, nome, email, situacao, tipoUsuario) 
                                               VALUES ('{usuario}', '{senha}', '{nome}', '{email}', '{situacao}', '{tipoUsuario}')";

                       
                      
                        Interaction.MsgBox("Os dados foram Salvos.", MsgBoxStyle.OkOnly, "SALVAR");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar.\n\n" + ex.Message, MsgBoxStyle.OkOnly, "ERRO AO SALVAR");
            }
        }

        public bool VerificarExisteUsuario(string usuario)
        {
            bool retorno = false;
            string strSQL = $"SELECT COUNT(1) AS existe FROM Login WHERE usuario = '{usuario}'";

            return retorno;

        }

    }
}