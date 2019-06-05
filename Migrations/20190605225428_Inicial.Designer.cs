﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MundoDePatitas.Datos;

namespace MundoDePatitas.Migrations
{
    [DbContext(typeof(MascotaContext))]
    [Migration("20190605225428_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MundoDePatitas.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Adoptado");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("TipoId");

                    b.Property<int>("edad");

                    b.Property<bool>("sexo");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MundoDePatitas.Models.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("MundoDePatitas.Models.Mascota", b =>
                {
                    b.HasOne("MundoDePatitas.Models.TipoMascota", "Tipo")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
