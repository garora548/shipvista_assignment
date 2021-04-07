﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShipvistaWaterPlants.Models;

namespace ShipvistaWaterPlants.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    [Migration("20210407102941_ColumnChangeTonull")]
    partial class ColumnChangeTonull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShipvistaWaterPlants.Models.Plant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("lastWatered")
                        .HasColumnType("datetime");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}
