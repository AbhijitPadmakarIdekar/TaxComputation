using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaxComputation.Domain.Entities;

namespace TaxComputation.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
            .HasMany(p => p.Products)
            .WithOne(c => c.Company)
            .HasForeignKey(c => c.CompanyId);
        }
    }
}
