﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patitas.Data;

namespace Patitas.Migrations
{
    [DbContext(typeof(MascotaContext))]
    [Migration("20190617091749_unionE")]
    partial class unionE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Patitas.Models.Adopcion", b =>
                {
                    b.Property<int>("IdAdoptante")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DNI");

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("FechaAdop");

                    b.Property<string>("Id1");

                    b.HasKey("IdAdoptante");

                    b.HasIndex("Id1");

                    b.ToTable("Adopciones");
                });

            modelBuilder.Entity("Patitas.Models.Anuncio", b =>
                {
                    b.Property<int>("IdAnuncio")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido");

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.HasKey("IdAnuncio");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("Patitas.Models.FotosMascota", b =>
                {
                    b.Property<int>("IdFotoMascota")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMascota");

                    b.Property<int>("MyProperty");

                    b.Property<string>("nombre");

                    b.HasKey("IdFotoMascota");

                    b.HasIndex("IdMascota");

                    b.ToTable("FotosMascotas");
                });

            modelBuilder.Entity("Patitas.Models.ListaEspera", b =>
                {
                    b.Property<int>("IdListaEspera")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Nombre");

                    b.Property<string>("SexoMascota");

                    b.Property<string>("Tamanio");

                    b.Property<string>("TipoMascota");

                    b.HasKey("IdListaEspera");

                    b.ToTable("ListaDeEspera");
                });

            modelBuilder.Entity("Patitas.Models.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int>("Edad");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<string>("Id1");

                    b.Property<int>("IdRefugio");

                    b.Property<int>("IdTipoMascota");

                    b.Property<string>("Nombre");

                    b.Property<string>("Personalidades");

                    b.Property<string>("PuedeEstarSolo");

                    b.Property<string>("Sexo");

                    b.Property<string>("Tamaño");

                    b.Property<string>("Ubicacion");

                    b.HasKey("IdMascota");

                    b.HasIndex("Id1");

                    b.HasIndex("IdRefugio");

                    b.HasIndex("IdTipoMascota");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("Patitas.Models.Mensaje", b =>
                {
                    b.Property<int>("IdMensaje")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Asunto");

                    b.Property<string>("Contenido");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Fecha");

                    b.Property<bool>("IsRead");

                    b.Property<string>("Nombre");

                    b.HasKey("IdMensaje");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("Patitas.Models.Pregunta", b =>
                {
                    b.Property<int>("IdPregunta")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Id1");

                    b.Property<int>("IdMascota");

                    b.HasKey("IdPregunta");

                    b.HasIndex("Id1");

                    b.HasIndex("IdMascota");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("Patitas.Models.Refugio", b =>
                {
                    b.Property<int>("IdRefugio")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaDeCreacion");

                    b.Property<string>("Id1");

                    b.Property<string>("Logo");

                    b.Property<string>("Nombre");

                    b.Property<int>("Telefono");

                    b.Property<string>("Ubicacion");

                    b.HasKey("IdRefugio");

                    b.HasIndex("Id1");

                    b.ToTable("Refugios");
                });

            modelBuilder.Entity("Patitas.Models.TipoMascota", b =>
                {
                    b.Property<int>("IdTipoMascota")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("IdTipoMascota");

                    b.ToTable("TipoMascotas");
                });

            modelBuilder.Entity("Patitas.Models.Veterinaria", b =>
                {
                    b.Property<int>("IdVeterinaria")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<string>("Logo");

                    b.Property<string>("Nombre");

                    b.Property<string>("Responsable");

                    b.Property<int>("Telefono");

                    b.HasKey("IdVeterinaria");

                    b.ToTable("Veterinarias");
                });

            modelBuilder.Entity("Patitas.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Apellidos");

                    b.Property<DateTime>("FechaDeRegistro");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Nombre");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Patitas.Models.Adopcion", b =>
                {
                    b.HasOne("Patitas.Models.ApplicationUser", "Id")
                        .WithMany("Adopcion")
                        .HasForeignKey("Id1");
                });

            modelBuilder.Entity("Patitas.Models.FotosMascota", b =>
                {
                    b.HasOne("Patitas.Models.Mascota")
                        .WithMany("FotosMascota")
                        .HasForeignKey("IdMascota")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Patitas.Models.Mascota", b =>
                {
                    b.HasOne("Patitas.Models.ApplicationUser", "Id")
                        .WithMany("Mascota")
                        .HasForeignKey("Id1");

                    b.HasOne("Patitas.Models.Refugio")
                        .WithMany("Mascota")
                        .HasForeignKey("IdRefugio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Patitas.Models.TipoMascota")
                        .WithMany("Mascota")
                        .HasForeignKey("IdTipoMascota")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Patitas.Models.Pregunta", b =>
                {
                    b.HasOne("Patitas.Models.ApplicationUser", "Id")
                        .WithMany("Pregunta")
                        .HasForeignKey("Id1");

                    b.HasOne("Patitas.Models.Mascota")
                        .WithMany("Pregunta")
                        .HasForeignKey("IdMascota")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Patitas.Models.Refugio", b =>
                {
                    b.HasOne("Patitas.Models.ApplicationUser", "Id")
                        .WithMany("Refugio")
                        .HasForeignKey("Id1");
                });
#pragma warning restore 612, 618
        }
    }
}
