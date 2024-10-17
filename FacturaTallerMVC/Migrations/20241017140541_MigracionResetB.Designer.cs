﻿// <auto-generated />
using System;
using FacturaTallerMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacturaTallerMVC.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241017140541_MigracionResetB")]
    partial class MigracionResetB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FacturaTallerMVC.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Coche", b =>
                {
                    b.Property<int>("IdCoche")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Combustible")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Kilometros")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdCoche");

                    b.HasIndex("ClienteId");

                    b.ToTable("Coches");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MatriculaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pvp")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecambioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TotalRecambio")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TotalTrabajo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Trabajo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UnidadesRecambio")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UnidadesTrabajo")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdFactura");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MatriculaId");

                    b.HasIndex("RecambioId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Recambio", b =>
                {
                    b.Property<int>("IdRecambio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("IdRecambio");

                    b.ToTable("Recambios");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Coche", b =>
                {
                    b.HasOne("FacturaTallerMVC.Models.Cliente", "Cliente")
                        .WithMany("Coches")
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Factura", b =>
                {
                    b.HasOne("FacturaTallerMVC.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("FacturaTallerMVC.Models.Coche", "Matricula")
                        .WithMany()
                        .HasForeignKey("MatriculaId");

                    b.HasOne("FacturaTallerMVC.Models.Recambio", "Recambio")
                        .WithMany("Facturas")
                        .HasForeignKey("RecambioId");

                    b.Navigation("Cliente");

                    b.Navigation("Matricula");

                    b.Navigation("Recambio");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Cliente", b =>
                {
                    b.Navigation("Coches");
                });

            modelBuilder.Entity("FacturaTallerMVC.Models.Recambio", b =>
                {
                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
