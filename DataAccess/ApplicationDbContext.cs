﻿
using Microsoft.EntityFrameworkCore;
using TrabajoIntegrador.DataAccess.DataBaseSeeding;
using TrabajoIntegrador.Entities;

namespace Prueba.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>();
            {
                new UserSeeder();
            };

            foreach (var seeder in seeders)
            {
                seeder.SeedDataBase(modelBuilder);
            }
        }

    }
}