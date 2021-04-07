﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;
using TCC2;
using System.Collections.Generic;

namespace TCC2
{
    public class MedidaCaseiraDAO
    {
        public MedidaCaseiraDAO()
        {
        }

        public void Salvar(string descricao, decimal qtd, int codAlimento)
        {
            try
            {
                MedidaCaseira medCasInsert = new MedidaCaseira();

                medCasInsert.descricao = descricao;
                medCasInsert.qtd = qtd;
                medCasInsert.codAlimento = codAlimento;

                BancoDadosSingleton.Instance.MedidaCaseira.Add(medCasInsert);
                BancoDadosSingleton.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ocorreu um erro ao salvar o Alimento." + '\n' + ex.Message + '\n' + ex.InnerException, Constants.vbOKOnly, "Alerta");

            }

        }
    }
}