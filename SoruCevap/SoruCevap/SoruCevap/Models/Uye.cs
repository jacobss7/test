//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoruCevap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uye()
        {
            this.Soru = new HashSet<Soru>();
        }
    
        public string userId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string rol { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Soru> Soru { get; set; }
    }
}