﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpecificationInfrastructure.DataAccess;

#nullable disable

namespace SpecificationInfrastructure.DataAccess.Migrations
{
    [DbContext(typeof(SpecificationContext))]
    [Migration("20220726165432_UpdateEntityBase")]
    partial class UpdateEntityBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Condition", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Conditions", (string)null);
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Operator", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Operators", (string)null);
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ConditionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsNot")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("int");

                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("OperatorId");

                    b.HasIndex("SettingId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SettingTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SettingTypeId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SettingType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("SettingTypes", (string)null);
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Instruction")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SpecificationRule", b =>
                {
                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("RuleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SpecificationId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("SpecificationRules");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SpecificationSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.Property<int?>("SkillLevelId")
                        .HasColumnType("int");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecificationId");

                    b.ToTable("SpecificationSkill");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Rule", b =>
                {
                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId");

                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Operator", "Operator")
                        .WithMany()
                        .HasForeignKey("OperatorId");

                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Setting", "Setting")
                        .WithMany("Rules")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condition");

                    b.Navigation("Operator");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Setting", b =>
                {
                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SettingType", "SettingType")
                        .WithMany()
                        .HasForeignKey("SettingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SettingType");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SpecificationRule", b =>
                {
                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Rule", "Rule")
                        .WithMany("SpecificationRules")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Specification", "Specification")
                        .WithMany("SpecificationRules")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rule");

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.SpecificationSkill", b =>
                {
                    b.HasOne("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Specification", "Specification")
                        .WithMany("SpecificationSkills")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Rule", b =>
                {
                    b.Navigation("SpecificationRules");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Setting", b =>
                {
                    b.Navigation("Rules");
                });

            modelBuilder.Entity("SpecificationDomain.AgreegateModels.SpecificationAgreegate.Specification", b =>
                {
                    b.Navigation("SpecificationRules");

                    b.Navigation("SpecificationSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
