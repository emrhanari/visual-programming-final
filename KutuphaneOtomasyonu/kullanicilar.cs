//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kullanicilar()
        {
            this.kayitlar = new HashSet<kayitlar>();
        }
    
        public int kullanici_id { get; set; }
        public string kullanici_ad { get; set; }
        public string kullanici_soyad { get; set; }
        public string kullanici_tc { get; set; }
        public string kullanici_mail { get; set; }
        public string kullanici_tel { get; set; }
        public float kullanici_ceza { get; set; }
        public string kullanici_cinsiyet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kayitlar> kayitlar { get; set; }
    }
}
