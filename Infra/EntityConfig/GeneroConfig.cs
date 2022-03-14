using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Context
{
    class GeneroConfig : EntityTypeConfiguration<Genero>
    {
        public GeneroConfig()
        {
            HasKey(k => k.GeneroId);
            Property(p => p.GeneroId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Tipo).HasMaxLength(60).IsRequired();
        }
    }
}
