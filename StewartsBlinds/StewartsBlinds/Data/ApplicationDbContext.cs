using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StewartsBlinds.Models;
using StewartsBlinds.Data.Entities;

namespace StewartsBlinds.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<SalesUser> SalesUsers { get; set; }
        public DbSet<QuoteLine> QuoteLines { get; set; }
        public DbSet<ConfigurationOption> ConfigurationOptions { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
