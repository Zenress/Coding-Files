﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaveService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HaveserviceEntities : DbContext
    {
        public HaveserviceEntities()
            : base("name=HaveserviceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Istandsættelse> Istandsættelse { get; set; }
        public virtual DbSet<Kunder> Kunder { get; set; }
        public virtual DbSet<LejningAfUdstyr> LejningAfUdstyr { get; set; }
    }
}
