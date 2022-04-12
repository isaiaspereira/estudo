using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Livraria.MVC.ViewModels;
using Livraria.Domain.Entitis;
using AutoMapper;

namespace Livraria.MVC.AutoMapper
{
    public class AutomapperConfig
    {

        public static void RegisterMappings()
        {

            Mapper.Initialize(X =>
            {

                X.CreateMap<Livro, LivroViewModels>().ReverseMap();
                X.CreateMap<Autor, AutorViewModels>().ReverseMap();
                X.CreateMap<Genero, GeneroViewModels>().ReverseMap();
                X.CreateMap<Editora, EditoraViewModels>().ReverseMap();
                X.CreateMap<AcessoCliente, AcessoClienteViewModels>().ReverseMap();
                X.CreateMap<AcessoUsuario, AcessoUsuarioViewModels>().ReverseMap();
                X.CreateMap<Usuario, UsuarioViewModels>().ReverseMap();
                X.CreateMap<Cliente, ClienteViewModels>().ReverseMap();

            });
        }

    }
}