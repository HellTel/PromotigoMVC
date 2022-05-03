﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PromotigoMVC.data;

#nullable disable

namespace PromotigoMVC.Migrations
{
    [DbContext(typeof(PromotigoMVCDBContext))]
    partial class PromotigoMVCDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PromotigoMVC.Models.EntrantModel+Entrant", b =>
                {
                    b.Property<Guid>("EntrantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntrantFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntrantID");

                    b.ToTable("Entrant");
                });
#pragma warning restore 612, 618
        }
    }
}
