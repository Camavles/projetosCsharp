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
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);

            builder.ToTable("staff");

            builder.Property(c => c.Id)
                .HasColumnName("staff_id");

            builder
                .Property(c => c.NomeUsuario)
                .HasColumnType("varchar(16)")
                .HasColumnName("username")
                .IsRequired();

            builder
                .Property(c => c.Senha)
                .HasColumnType("varchar(40)")
                .HasColumnName("password");

        }
    }
}
