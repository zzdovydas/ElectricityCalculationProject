﻿// <auto-generated />
using System;
using ElectricityCalculationProject.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectricityCalculationProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220913062315_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ElectricityCalculationProject.Models.ElectricityData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OBJ_GV_TIPAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OBJ_NUMERIS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OBT_PAVADINIMAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PL_T")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("P_Diff")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("P_minus")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("P_plus")
                        .HasColumnType("TEXT");

                    b.Property<string>("TINKLAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ElectricityData");
                });
#pragma warning restore 612, 618
        }
    }
}
