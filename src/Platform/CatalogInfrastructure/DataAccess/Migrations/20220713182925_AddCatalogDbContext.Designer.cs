﻿// <auto-generated />
using System;
using CatalogInfrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatalogInfrastructure.DataAccess.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20220713182925_AddCatalogDbContext")]
    partial class AddCatalogDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Addon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Addons");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal?>("PriceStandar")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<int?>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.CatalogAddon", b =>
                {
                    b.Property<int>("CatalogId")
                        .HasColumnType("int");

                    b.Property<int>("AddonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CatalogId", "AddonId");

                    b.HasIndex("AddonId");

                    b.ToTable("CatalogAddons");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Currency", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Currencies", (string)null);
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Addon", b =>
                {
                    b.HasOne("CatalogDomain.AgreegateModels.CatalogAgreegate.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Catalog", b =>
                {
                    b.HasOne("CatalogDomain.AgreegateModels.CatalogAgreegate.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.CatalogAddon", b =>
                {
                    b.HasOne("CatalogDomain.AgreegateModels.CatalogAgreegate.Addon", "Addon")
                        .WithMany("CatalogAddons")
                        .HasForeignKey("AddonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogDomain.AgreegateModels.CatalogAgreegate.Catalog", "Catalog")
                        .WithMany("CatalogAddons")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Addon");

                    b.Navigation("Catalog");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Addon", b =>
                {
                    b.Navigation("CatalogAddons");
                });

            modelBuilder.Entity("CatalogDomain.AgreegateModels.CatalogAgreegate.Catalog", b =>
                {
                    b.Navigation("CatalogAddons");
                });
#pragma warning restore 612, 618
        }
    }
}
