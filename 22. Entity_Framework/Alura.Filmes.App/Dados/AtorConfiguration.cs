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
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder
                 .ToTable("actor");

            builder.Property(a => a.Id)
                .HasColumnName("actor_Id");

            builder.Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder.Property(a => a.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            // como essa prop não existe na camada de negócio, aliás, na minha classe, eu preciso passar o tipo dessa propriedade que é DateTime;
            builder.Property<DateTime>("last_update")
                .HasColumnType("datetime");
                //.HasDefaultValueSql("getdate()");
                 // com esse código, o SQL consegue pegar o datetime no momento da inclusão;

            builder.HasIndex(a => a.UltimoNome)
                .HasName("idx_actor_last_name");

            // RESTRIÇÃO UNIQUE;
            builder.HasAlternateKey(a => new { a.PrimeiroNome, a.UltimoNome });
        }
    }
}
