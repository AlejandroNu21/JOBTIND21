﻿// <auto-generated />
using JOBTIND21.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JOBTIND21.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JOBTIND21.Dominio.Anuncio", b =>
                {
                    b.Property<int>("AnuncioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anuncios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("AnuncioId");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Anuncio");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categorias")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("ContraseñaEmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailEmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonoEmp")
                        .HasColumnType("int");

                    b.Property<string>("Vacante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaId");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DUI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Anuncio", b =>
                {
                    b.HasOne("JOBTIND21.Dominio.Empresa", "Empresa")
                        .WithMany("Anuncios")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JOBTIND21.Dominio.Usuario", "Usuario")
                        .WithMany("Anuncios")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Empresa", b =>
                {
                    b.HasOne("JOBTIND21.Dominio.Categoria", "Categoria")
                        .WithMany("Empresas")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Categoria", b =>
                {
                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Empresa", b =>
                {
                    b.Navigation("Anuncios");
                });

            modelBuilder.Entity("JOBTIND21.Dominio.Usuario", b =>
                {
                    b.Navigation("Anuncios");
                });
#pragma warning restore 612, 618
        }
    }
}
