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
    // uma forma de fazer herança e permitir que outras classes herdem esse método
    public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(c => c.PrimeiroNome)
               .HasColumnType("varchar(45")
               .HasColumnName("first_name")
               .IsRequired();

            builder.Property(c => c.UltimoNome)
                .HasColumnType("varchar(45")
                .HasColumnName("last_name")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(50)")
                .HasColumnName("email");

            builder.Property("Ativo")
                .HasColumnName("active");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime");
                //.HasDefaultValueSql("getdate()");
        }
    }
}
