//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.ClienteProduto = new HashSet<ClienteProduto>();
        }
    
        public int cli_cod { get; set; }
        public string cli_nome { get; set; }
        public string cli_cpfcnpj { get; set; }
        public string cli_rgie { get; set; }
        public string cli_rsocial { get; set; }
        public string cli_tipo { get; set; }
        public string cli_cep { get; set; }
        public string cli_endereco { get; set; }
        public string cli_bairro { get; set; }
        public string cli_fone { get; set; }
        public string cli_cel { get; set; }
        public string cli_email { get; set; }
        public string cli_endnumero { get; set; }
        public string cli_cidade { get; set; }
        public string cli_estado { get; set; }
        public string cli_observacao { get; set; }
        public Nullable<System.DateTime> cli_cadastro { get; set; }
        public string cli_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteProduto> ClienteProduto { get; set; }
    }
}
