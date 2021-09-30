﻿// <auto-generated />
using System;
using HappyPet.App.Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HappyPet.App.Persistencia.Migrations
{
    [DbContext(typeof(HappyPet.App.Persistencia.AppRepositorios.AppContext))]
    [Migration("20210929194936_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HappyPet.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoDeSalud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FrecuenciaCardiaca")
                        .HasColumnType("float");

                    b.Property<double>("FrecuenciaRespiratoria")
                        .HasColumnType("float");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int?>("VisitaId")
                        .HasColumnType("int");

                    b.Property<double>("temperatura")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("VisitaId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaDeVisita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraDeVisita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("HappyPet.App.Dominio.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("HappyPet.App.Dominio.Visita", "Visita")
                        .WithMany()
                        .HasForeignKey("VisitaId");

                    b.Navigation("Mascota");

                    b.Navigation("Visita");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.Mascota", b =>
                {
                    b.HasOne("HappyPet.App.Dominio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("HappyPet.App.Dominio.Visita", b =>
                {
                    b.HasOne("HappyPet.App.Dominio.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("HappyPet.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Mascota");

                    b.Navigation("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
