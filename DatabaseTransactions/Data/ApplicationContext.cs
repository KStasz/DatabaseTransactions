using DatabaseTransactions.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTransactions.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected ApplicationContext()
        {
        }

        public DbSet<People> Peoples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
                        .Property(p => p.IsActive)
                        .HasDefaultValue(true);
            modelBuilder.Entity<People>()
                        .Property(p => p.CreationDate)
                        .HasDefaultValue(DateTime.Now);
        }
    }
}
