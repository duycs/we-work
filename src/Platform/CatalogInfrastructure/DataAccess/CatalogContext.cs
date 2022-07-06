﻿using AppShareServices.DataAccess.Persistences;
using CatalogDomain.AgreegateModels.CatalogAgreegate;
using Microsoft.EntityFrameworkCore;

namespace CatalogInfrastructure.DataAccess
{
    public class ProductContext : DbContext, IDatabaseService
    {
        public DbSet<Addon> Addons { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<CatalogAddon> CatalogAddons { get; set; }

        DbSet<T> IDatabaseService.GetDbSet<T>()
        {
            return Set<T>();
        }

        Task IDatabaseService.SaveChanges()
        {
            return Task.FromResult(base.SaveChanges());
        }

        public ProductContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO: Move to out side
                optionsBuilder.UseMySql("Server=localhost;port=3306;Database=ProductDb;user=root;password=abc@1234;CharSet=utf8;", new MySqlServerVersion(new Version(8, 0, 21)));
            }
        }

        /// <summary>
        /// ref: https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Products-Addons
            modelBuilder.Entity<Catalog>()
           .HasMany(i => i.Addons)
           .WithMany(i => i.Catalogs)
           .UsingEntity<CatalogAddon>(
               j => j
                   .HasOne(w => w.Addon)
                   .WithMany(w => w.CatalogAddons)
                   .HasForeignKey(w => w.AddonId)
                   .OnDelete(DeleteBehavior.Cascade),
               j => j
                   .HasOne(w => w.Catalog)
                   .WithMany(w => w.CatalogAddons)
                   .HasForeignKey(w => w.CatalogId)
                   .OnDelete(DeleteBehavior.Cascade),
               j =>
               {
                   j.Ignore(w => w.Id).HasKey(w => new { w.CatalogId, w.AddonId });
               });


        }

    }
}