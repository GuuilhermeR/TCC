﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC2.Banco_de_Dados
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NutreasyEntities : DbContext
    {
        public NutreasyEntities()
            : base("name=NutreasyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Alimentos> Alimentos { get; set; }
        public virtual DbSet<AnamneseConfig> AnamneseConfig { get; set; }
        public virtual DbSet<AnamnesePaciente> AnamnesePaciente { get; set; }
        public virtual DbSet<Cardapio> Cardapio { get; set; }
        public virtual DbSet<ConfiguracoesUsuarios> ConfiguracoesUsuarios { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MedidaCaseira> MedidaCaseira { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<Antropometria> Antropometria { get; set; }
    }
}
