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
    
    public partial class venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venda()
        {
            this.itensvenda = new HashSet<itensvenda>();
        }
    
        public int ven_cod { get; set; }
        public Nullable<System.DateTime> ven_data { get; set; }
        public Nullable<int> ven_nfiscal { get; set; }
        public Nullable<decimal> ven_total { get; set; }
        public string ven_status { get; set; }
        public Nullable<int> cli_cod { get; set; }
        public Nullable<int> ven_nparcelas { get; set; }
        public Nullable<int> tpa_cod { get; set; }
        public Nullable<int> ven_avista { get; set; }
        public Nullable<System.DateTime> ven_data_entrada { get; set; }
        public Nullable<System.DateTime> ven_data_saida { get; set; }
        public Nullable<System.DateTime> ven_hora_entrada { get; set; }
        public Nullable<System.DateTime> ven_hora_saida { get; set; }
        public string ven_defeito_apresentado { get; set; }
        public string ven_servico_efetuado { get; set; }
        public string ven_lembrete { get; set; }
        public Nullable<int> ven_diasProximaRevisao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itensvenda> itensvenda { get; set; }
    }
}
