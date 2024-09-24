﻿// <auto-generated />
using System;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Data.Migrations
{
    [DbContext(typeof(MeuContext))]
    partial class MeuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Model.UmPraUm.Carro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DataAtualizacao")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DataCriacao")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Domain.Model.UmPraUm.Chassi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DataAtualizacao")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DataCriacao")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("NumeroDeSerie")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CarroId")
                        .IsUnique();

                    b.ToTable("Chassi");
                });

            modelBuilder.Entity("Domain.Model.UmPraUm.Chassi", b =>
                {
                    b.HasOne("Domain.Model.UmPraUm.Carro", "Carro")
                        .WithOne("Chassi")
                        .HasForeignKey("Domain.Model.UmPraUm.Chassi", "CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");
                });

            modelBuilder.Entity("Domain.Model.UmPraUm.Carro", b =>
                {
                    b.Navigation("Chassi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}