﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi.millerdcjr.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class webapiEntities : DbContext
    {
        public webapiEntities()
            : base("name=webapiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryZone> CountryZones { get; set; }
        public virtual DbSet<Gig> Gigs { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }
}
