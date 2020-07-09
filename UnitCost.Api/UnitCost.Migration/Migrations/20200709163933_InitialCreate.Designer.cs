﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitCost.DBMigrations;

namespace UnitCost.DBMigrations.Migrations
{
    [DbContext(typeof(UnitCostAppContext))]
    [Migration("20200709163933_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UnitCost.DBMigrations.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("UnitCost.DBMigrations.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Firstname")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Lastname")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Psswrd")
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
