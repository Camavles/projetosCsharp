﻿// <auto-generated />
using Alura.Filmes.App.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Alura.Filmes.App.Migrations
{
    [DbContext(typeof(AluraFilmesContexto))]
    [Migration("20230905190957_DateTime")]
    partial class DateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Filmes.App.Negocio.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("actor_Id");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("actor");
                });
#pragma warning restore 612, 618
        }
    }
}
