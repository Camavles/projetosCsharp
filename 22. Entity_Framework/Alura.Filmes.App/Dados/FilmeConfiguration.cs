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
                .Property(b => b.TextoClassificacao)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime");
                //.HasDefaultValueSql("getdate()");
              

            builder.Property<byte>("language_id");
            builder.Property<byte?>("original_language_id");

            builder
                .HasOne(c => c.IdiomaFalado)
                .WithMany(c => c.FilmesFalados)
                .HasForeignKey("language_id");

            builder
                .HasOne(c => c.IdiomaOriginal)
                .WithMany(c => c.FilmesOriginais)
                .HasForeignKey("original_language_id");

            builder
                .Ignore(f => f.Classificacao); // vai ser ignorada pelo entity;


            // daria para montar uma Config só para ClassificacãoIndicativa e colocar essa setagem, pois a partir do Entity 2.1 já tem 
            // opção HasConversion
            //builder
            // .Property<ClassificacaoIndicativa>(f => f.Classificacao)
            // .HasConversion<string>(
            //     f => f.ParaString(),
            //     f => f.ParaValor()
            // )
            // .HasColumnType("varchar(10)")
            // .HasColumnName("rating");
        }
    }
}
