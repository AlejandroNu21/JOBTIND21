﻿// <auto-generated />
using System;
using JOBTIND21.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JOBTIND21.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211011193848_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JOBTIND21.Dominio.Anuncio", b =>
                {
                    b.Property<int>("Id_Anuncio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anuncios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId_Empresa")
                        .HasColumnType("int");

                    b.Property<int>("Id_Empresa")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId_Usuario")
                        .HasColumnType("int");

                    b.HasKey("Id_Anuncio");

                    b.HasIndex("EmpresaId_Empresa");

                    b.HasIndex("UsuarioId_Usuario");

                    b.ToTable("Anuncio");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Empresa", b =>
                {
                    b.Property<int>("Id_Empresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("Vacante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Empresa");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Anuncio", b =>
                {
                    b.HasOne("JOBTIND21.Dominio.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId_Empresa");

                    b.HasOne("JOBTIND21.Dominio.Usuario", "Usuario")
                        .WithMany("Anuncios")
                        .HasForeignKey("UsuarioId_Usuario");

                    b.Navigation("Empresa");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Usuario", b =>
                {
                    b.Navigation("Anuncios");
                });
#pragma warning restore 612, 618
        }
    }
}
