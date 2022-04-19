using Livraria.Domain.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EntityConfig
{
    public class LivroConfig : EntityTypeConfiguration<Livro>
    {
        public LivroConfig()
        {
            HasKey(k => k.LivroId);
            Property(p => p.LivroId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome).HasMaxLength(100).IsRequired();
            Property(p => p.Titulo).HasMaxLength(60).IsRequired();
            Property(p => p.Preco).HasPrecision(16, 2).IsRequired().HasColumnName("valor");
            Property(p => p.Descricao).IsRequired();
            Property(p => p.Sobre).HasMaxLength(300).IsOptional();
            Property(p => p.Disponivel).HasColumnName("ativo");
            Property(p => p.DataCadastro).HasColumnType("DateTime2");
            //relacionamento de livro
            HasMany(m => m.Autores).WithMany().Map(x => { x.MapLeftKey("LivroId"); x.MapRightKey("AutorId"); });
            //relacionamento de um  
            HasRequired(c => c.Genero).WithMany(m=>m.Livros).HasForeignKey(c => c.GeneroId);
            HasRequired(c => c.Editora).WithMany(m=>m.Livros).HasForeignKey(c => c.EditoraId);

        }
    }
}