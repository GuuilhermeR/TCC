//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Antropometria
    {
        public long codPaciente { get; set; }
        public System.DateTime Data { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<double> altura { get; set; }
        public Nullable<double> braco { get; set; }
        public Nullable<double> punho { get; set; }
        public Nullable<double> cintura { get; set; }
        public Nullable<double> torax { get; set; }
        public Nullable<double> quadril { get; set; }
        public Nullable<double> panturrilha { get; set; }
        public Nullable<double> antebraco { get; set; }
        public Nullable<double> coxa { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
