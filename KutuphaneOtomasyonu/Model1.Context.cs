﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kutuphaneotomasyonuEntities1 : DbContext
    {
        public kutuphaneotomasyonuEntities1()
            : base("name=kutuphaneotomasyonuEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<personel> personel { get; set; }
        public virtual DbSet<kullanicilar> kullanicilar { get; set; }
        public virtual DbSet<kaynaklar> kaynaklar { get; set; }
        public virtual DbSet<kayitlar> kayitlar { get; set; }
    }
}
