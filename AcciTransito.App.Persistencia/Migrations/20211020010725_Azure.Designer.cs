﻿// <auto-generated />
using System;
using AcciTransito.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcciTransito.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211020010725_Azure")]
    partial class Azure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Accidentes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AgenteTransitoId")
                        .HasColumnType("int");

                    b.Property<string>("Barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Coordenadasid")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroAccidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peritaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAccidente")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AgenteTransitoId");

                    b.HasIndex("Coordenadasid");

                    b.ToTable("Accidentes");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.AgenteTransito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Grupo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroAgente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgenteTransito");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Coordenadas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Coordenadas");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Personas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ContactoAlterno")
                        .HasColumnType("bigint");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NumeroCelular")
                        .HasColumnType("bigint");

                    b.Property<string>("NumeroIdentificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Personas_Accidente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Accidenteid")
                        .HasColumnType("int");

                    b.Property<int?>("Personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Accidenteid");

                    b.HasIndex("Personaid");

                    b.ToTable("Personas_Accidente");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Vehiculos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LicenciaTransito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Personaid")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoVehiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Personaid");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Vehiculos_Accidente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Accidenteid")
                        .HasColumnType("int");

                    b.Property<int?>("Vehiculoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Accidenteid");

                    b.HasIndex("Vehiculoid");

                    b.ToTable("Vehiculos_Accidente");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Accidentes", b =>
                {
                    b.HasOne("AcciTransito.App.Dominio.Entidades.AgenteTransito", "AgenteTransito")
                        .WithMany()
                        .HasForeignKey("AgenteTransitoId");

                    b.HasOne("AcciTransito.App.Dominio.Entidades.Coordenadas", "Coordenadas")
                        .WithMany()
                        .HasForeignKey("Coordenadasid");

                    b.Navigation("AgenteTransito");

                    b.Navigation("Coordenadas");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Personas_Accidente", b =>
                {
                    b.HasOne("AcciTransito.App.Dominio.Entidades.Accidentes", "Accidente")
                        .WithMany()
                        .HasForeignKey("Accidenteid");

                    b.HasOne("AcciTransito.App.Dominio.Entidades.Personas", "Persona")
                        .WithMany()
                        .HasForeignKey("Personaid");

                    b.Navigation("Accidente");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Vehiculos", b =>
                {
                    b.HasOne("AcciTransito.App.Dominio.Entidades.Personas", "Persona")
                        .WithMany()
                        .HasForeignKey("Personaid");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcciTransito.App.Dominio.Entidades.Vehiculos_Accidente", b =>
                {
                    b.HasOne("AcciTransito.App.Dominio.Entidades.Accidentes", "Accidente")
                        .WithMany()
                        .HasForeignKey("Accidenteid");

                    b.HasOne("AcciTransito.App.Dominio.Entidades.Vehiculos", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("Vehiculoid");

                    b.Navigation("Accidente");

                    b.Navigation("Vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
