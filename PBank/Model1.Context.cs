﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBank
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankowoscEntities : DbContext
    {
        public BankowoscEntities()
            : base("name=BankowoscEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Karta> Karta { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
    }
}
