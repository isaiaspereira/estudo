using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(c => c.UsuarioId);
            Property(c => c.UsuarioId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(80).IsRequired();
            Property(c => c.SobreNome).HasMaxLength(150).IsRequired();
            Property(c => c.Nome).HasMaxLength(12).IsRequired();
            Property(c => c.DataCadastro).IsRequired().HasColumnType("datetime2");
            Property(c => c.Ativo).IsRequired();
            Property(c => c.RG).IsRequired().HasMaxLength(10).HasColumnName("rg");
            Property(c => c.Cargo).HasMaxLength(80).IsRequired();
            Property(c => c.CTPS).HasMaxLength(12).IsRequired().HasColumnName("ctps");
            Property(c => c.Salario).IsRequired().HasPrecision(18, 2);

        }
    }
}
