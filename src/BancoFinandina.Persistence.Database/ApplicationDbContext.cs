using BancoFinandina.Domain;
using BancoFinandina.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BancoFinandina.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }
        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<User>());
        }
    }
}