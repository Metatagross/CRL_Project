﻿// <auto-generated />
using System;
using CRL.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRL.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRL.DataModel.Entities.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ClosenessCentralityCoefficient")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConnected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLogisticCenter")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CRL.DataModel.Entities.RouteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int?>("EndId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDirect")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EndId");

                    b.HasIndex("StartId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("CRL.DataModel.Entities.RouteEntity", b =>
                {
                    b.HasOne("CRL.DataModel.Entities.CityEntity", "End")
                        .WithMany()
                        .HasForeignKey("EndId");

                    b.HasOne("CRL.DataModel.Entities.CityEntity", "Start")
                        .WithMany()
                        .HasForeignKey("StartId");
                });
#pragma warning restore 612, 618
        }
    }
}
