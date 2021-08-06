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
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Cardapio = new HashSet<Cardapio>();
            this.AnamnesePaciente = new HashSet<AnamnesePaciente>();
            this.ConfiguracoesUsuarios = new HashSet<ConfiguracoesUsuarios>();
        }
    
        public long codPaciente { get; set; }
        public Nullable<long> CPF { get; set; }
        public string nome { get; set; }
        public string dtNasc { get; set; }
        public string email { get; set; }
        public Nullable<double> CEP { get; set; }
        public string endereco { get; set; }
        public Nullable<long> numero { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string UF { get; set; }
        public string complemento { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public byte[] imagem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cardapio> Cardapio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnamnesePaciente> AnamnesePaciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfiguracoesUsuarios> ConfiguracoesUsuarios { get; set; }
    }
}
