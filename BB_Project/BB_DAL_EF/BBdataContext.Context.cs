﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BB_DAL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BBdataContext : DbContext
    {
        public BBdataContext()
            : base("name=BBdataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blood_Group> Blood_Group { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Doctor_Donor> Doctor_Donor { get; set; }
        public virtual DbSet<Doctor_Receiver> Doctor_Receiver { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Receiver> Receivers { get; set; }
    }
}
