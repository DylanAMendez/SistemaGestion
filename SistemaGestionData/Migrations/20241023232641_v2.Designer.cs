﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaGestionData.Contexts;

#nullable disable

namespace SistemaGestionData.Migrations
{
    [DbContext(typeof(CoderhouseDbContext))]
    [Migration("20241023232641_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaGestionData.Models.ProductoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasAnnotation("Relational:JsonPropertyName", "categoria");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasAnnotation("Relational:JsonPropertyName", "descripcion");

                    b.Property<decimal>("PrecioCompra")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "precioCompra");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "precioVenta");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "stock");

                    b.Property<decimal>("TotalProducto")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "totalProducto");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaGestionData.Models.ProductoVendidoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("VentaDataId")
                        .HasColumnType("int");

                    b.Property<int?>("VentaDataId")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaDataId");

                    b.ToTable("ProductosVendidos");
                });

            modelBuilder.Entity("SistemaGestionData.Models.UsuarioData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("Relational:JsonPropertyName", "apellido");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("Relational:JsonPropertyName", "contraseña");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("Relational:JsonPropertyName", "email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("Relational:JsonPropertyName", "nombre");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("Relational:JsonPropertyName", "nombreUsuario");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaGestionData.Models.VentaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("comentario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SistemaGestionData.Models.ProductoVendidoData", b =>
                {
                    b.HasOne("SistemaGestionData.Models.VentaData", null)
                        .WithMany("ProductosVendidos")
                        .HasForeignKey("VentaDataId");
                });

            modelBuilder.Entity("SistemaGestionData.Models.VentaData", b =>
                {
                    b.Navigation("ProductosVendidos");
                });
#pragma warning restore 612, 618
        }
    }
}