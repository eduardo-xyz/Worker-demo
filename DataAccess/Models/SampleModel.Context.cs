﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SGA_EntrenamientoEntities : DbContext
    {
        public SGA_EntrenamientoEntities()
            : base("name=SGA_EntrenamientoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<A_Entrevistadores> A_Entrevistadores { get; set; }
        public DbSet<A_Giras> A_Giras { get; set; }
    }
}
