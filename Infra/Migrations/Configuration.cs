

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
            #region Perfil
            context.PerfilAcessos.AddOrUpdate(
                new PerfilAcesso { PerfilAcessoId = 1, NomeAcesso = "Presidente" },
                new PerfilAcesso { PerfilAcessoId = 2,NomeAcesso="Administrativo"},
                new PerfilAcesso { PerfilAcessoId = 3,NomeAcesso="Financeiro"},
                new PerfilAcesso { PerfilAcessoId = 4,NomeAcesso="Operador"}
            );
            #endregion
            #region Endereco
            context.Enderecos.AddOrUpdate(new Endereco { EnderecoId = 1, ClienteId = 1, Bairro = "jequitiba", CEP = "7895654", Cidade = "cuiaba", Estado = "Par�", Logradouro = "rua", Rua = "14", Referencia = "esquina" });
            #endregion
            #region Contato
            context.Contatos.AddOrUpdate(new Contato { UsuarioId = 1, Telefone1 = "65132135", OperadoraId = 1 });
            #endregion
            #region Usuario
            context.Usuarios.AddOrUpdate(
                new Usuario { UsuarioId = 0, Ativo = true, Cargo = "Gestor de Categoria", CPF = "132152305", RG = "1315480", CTPS = "120315", Nome = "eduardo", Salario = 1800, SobreNome = "pires" },
                new Usuario { UsuarioId = 1, Ativo = true, Cargo = "Programado Jr", CPF = "12548133", RG = "2548128", CTPS = "122845", Nome = "Isaias", Salario = 5800, SobreNome = "Ares" });
            #endregion
            #region Cliente
            context.Clientes.AddOrUpdate(new Cliente { ClienteId = 0, Nome = "Isaias", RG = "25148561", CPF = "20154862" });
            #endregion
            #region Operadora
            context.Operadoras.AddOrUpdate(new Operadora { Nome = "Claro", ContatoId = 1, DDD = "65" });
            #endregion
            #region Genero
            context.Generos.AddOrUpdate(
                new Livraria.Domain.Entitis.Genero { GeneroId = 1, Tipo = "Agropecuario	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 24, Tipo = "Religioso" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 2, Tipo = "Antologias" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 3, Tipo = "Auto Ajuda" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 4, Tipo = "Aventura" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 5, Tipo = "Biogr�fico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 6, Tipo = "Cientifico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 7, Tipo = "Contos	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 8, Tipo = "Cr�nica	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 9, Tipo = "Did�tico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 10, Tipo = "Epico" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 11, Tipo = "Fantasia	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 12, Tipo = "Fic�ao Cientifica" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 13, Tipo = "Fic�ao Hist�ria	" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 14, Tipo = "Guia De Viagem" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 15, Tipo = "Horror|Terror" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 16, Tipo = "Infanto Juvenis" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 17, Tipo = "Infantis" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 18, Tipo = "Jogos" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 19, Tipo = "Manuais" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 20, Tipo = "Memoria" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 21, Tipo = "Natal" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 22, Tipo = "Poesia" },
                new Livraria.Domain.Entitis.Genero { GeneroId = 23, Tipo = "Tecnologia" }
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
                    Descricao = "O recurso necess�rio para se ter um c�digo amplo",
                    Sobre = "muitos sabe Codificar, mas poucos sabem Desenvolver.",
                    Disponivel = true,
                    GeneroId = 23,
                    EditoraId = 4
                },
                 new Livro
                 {
                     LivroId = 2,
                     Titulo = "JavaScript",
                     Codigo = "7789512353",
                     Nome = "JavaScript",
                     Preco = 30,
                     Descricao = "O recurso necess�rio para se ter um c�digo amplo em java Otimizado",
                     Sobre = "Aprenda a Programar em java sem mimi.",
                     Disponivel = true,
                     GeneroId = 23,
                     EditoraId = 2
                 },
                 new Livro
                 {
                     LivroId = 3,
                     Titulo = "UML",
                     Codigo = "0783568452",
                     Nome = "Modelagem No Padrao Uml",
                     Preco = 300,
                     Descricao = "O recurso necess�rio para fazer uma modelagem mais sofisticada",
                     Sobre = "Aprenda a  Levantar Requisitos.",
                     Disponivel = true,
                     GeneroId = 23,
                     EditoraId = 3
                 },
                 new Livro
                 {
                     LivroId = 4,
                     Titulo = "C#",
                     Codigo = "7894521568",
                     Nome = "c# Para Leigos",
                     Preco = 1000,
                     Descricao = "O recurso necess�rio para Aprender a Programar em c#",
                     Sobre = "Aprenda a Programar em C# Rapido e Pratico.",
                     Disponivel = true,
                     GeneroId = 23,
                     EditoraId = 1
                 }
                );
            #endregion
        }
    }
}

