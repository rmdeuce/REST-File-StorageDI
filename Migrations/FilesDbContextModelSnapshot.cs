﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestApiFiles.Data;

namespace RestApiFiles.Migrations
{
    [DbContext(typeof(FilesDbContext))]
    partial class FilesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RestApiFiles.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Creadt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilesPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("develop.Services.Dev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppEnv")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devs");
                });

            modelBuilder.Entity("develop.Services.Prod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppEnv")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prods");
                });
#pragma warning restore 612, 618
        }
    }
}