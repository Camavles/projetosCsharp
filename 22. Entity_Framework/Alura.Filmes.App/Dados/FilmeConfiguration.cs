using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
             .ToTable("film");

            builder
                .Property(b => b.Id)
                .HasColumnName("film_id");

            builder
                .Property(b => b.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(b => b.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

            builder
                .Property(b => b.AnoDeLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder
                .Property(b => b.Duracao)
                .HasColumnName("length");
            //.HasColumnType("smallint");

            builder
                .Property(b => b.Avaliacao)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder.Property<byte>("language_id");
            builder.Property<byte>("original_language_id");

            builder
                .HasOne(c => c.IdiomaFalado)
                .WithMany(c => c.FilmesFalados)
                .HasForeignKey("language_id");

            builder
                .HasOne(c => c.IdiomaOriginal)
                .WithMany(c => c.FilmesOriginais)
                .HasForeignKey("original_language_id");
        }
    }
}
