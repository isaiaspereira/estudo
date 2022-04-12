

namespace Infra.Migrations
{
    using Livraria.Domain.Entitis;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.LivrariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.LivrariaContext context)
        {
            //context.Enderecos.AddOrUpdate(new Endereco { EnderecoId = 1, ClienteId = 2, Bairro = "jequitiba", CEP = "7895654", Cidade = "cuiaba", Estado = "para", Logradouro = "rua", Rua = "14", Referencia = "esquina"});
            //context.Contatos.AddOrUpdate(new Contato { UsuarioId = 1, Telefone1 = "65132135", OperadoraId = 1});
            context.Usuarios.AddOrUpdate(new Usuario { Ativo = true, Cargo = "Gestor de Categoria", CPF = "132152305", RG = "1315480", CTPS = "120315", Nome = "eduardo", Salario = 1800, SobreNome = "pires" });
            context.Clientes.AddOrUpdate(new Cliente { Nome = "Isaias", RG = "25148561", CPF = "20154862" });
            context.Operadoras.AddOrUpdate(new Operadora { Nome = "Claro", ContatoId = 1, DDD = "65" });
            #region Genero
            context.Generos.AddOrUpdate(
                new Livraria.Domain.Entitis.Genero { GeneroId = 1, Tipo = "Agropecuario	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 23, Tipo = "Tecnologia" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 24, Tipo = "Religioso" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 2, Tipo = "Antologias" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 3, Tipo = "Auto Ajuda" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 4, Tipo = "Aventura" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 5, Tipo = "Biográfico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 6, Tipo = "Cientifico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 7, Tipo = "Contos	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 8, Tipo = "Crônica	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 9, Tipo = "Didático" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 10, Tipo = "Epico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 11, Tipo = "Fantasia	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 12, Tipo = "Ficçao Cientifica" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 13, Tipo = "Ficçao História	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 14, Tipo = "Guia De Viagem" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 15, Tipo = "Horror|Terror" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 16, Tipo = "Infanto Juvenis" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 17, Tipo = "Infantis" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 18, Tipo = "Jogos" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 19, Tipo = "Manuais" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 20, Tipo = "Memoria" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 21, Tipo = "Natal" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 22, Tipo = "Poesia" }
                );
            #endregion
            #region Editora
            context.Editoras.AddOrUpdate(
                new Livraria.Domain.Entitis.Editora { EditoraId = 1, Nome = "Wonner Bross", Sigla = "WB" },
                new Livraria.Domain.Entitis.Editora { EditoraId = 2, Nome = "Pixel", Sigla = "PX" },
                new Livraria.Domain.Entitis.Editora { EditoraId = 3, Nome = "Janinna", Sigla = "JN" },
                new Livraria.Domain.Entitis.Editora { EditoraId = 4, Nome = "Prime Amazon", Sigla = "PA" }
                );
            #endregion
            #region Autor
            context.Autores.AddOrUpdate(
                new Livraria.Domain.Entitis.Autor { AutorId = 0, Nome = "Algust Curry", SobreNome = "Almeida", Email = "Curry@Gmail.com" },
                new Livraria.Domain.Entitis.Autor { AutorId = 1, Nome = "David Killan", SobreNome = "Kingston", Email = "Kingston@Gmail.com", },
                new Livraria.Domain.Entitis.Autor { AutorId = 2, Nome = "Donnal Trump", SobreNome = "Trumping", Email = "Donnald@Hotmail.com", }
                );
            #endregion
            #region Livro
            context.Livros.AddOrUpdate(
                new Livro
                {
                    LivroId = 1,
                    Titulo = "Codigo Limpo",
                    Codigo = "78925486321",
                    Nome = "Codigo Limpo",
                    Preco = 120,
                    Descricao = "O recurso necessário para se ter um código amplo",
                    Sobre = "muitos sabe Codificar, mas poucos sabem Desenvolver.",
                    Disponivel = true,
                    GeneroId = 23,
                    EditoraId = 4
                }
                );
            #endregion
        }
    }
}
