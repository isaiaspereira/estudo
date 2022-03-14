using Infra.EntityConfig;
using Livraria.Domain.Entitis;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Infra.Context
{
    public class LivrariaContext : DbContext
    {
        //ConfigurationManager.ConnectionStrings["SuaStringDeConexao"].ConnectionString<- Setando Sua ConnectionString
        public LivrariaContext():
            base("LivrariaLTDA") 
        {

        }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Genero> Generos { get; set; }

        public DbSet<Editora> Editoras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new LivroConfig());
            modelBuilder.Configurations.Add(new AutorConfig());
            modelBuilder.Configurations.Add(new GeneroConfig());
            modelBuilder.Configurations.Add(new EditoraConfig());
            modelBuilder.Properties().Where(c => c.Name == c.PropertyType.Name + "Id").Configure(c => c.IsKey());
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(150));
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
