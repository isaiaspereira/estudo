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
                //IDA
                //Modo EASY
                //X.CreateMap(typeof(IAppServiceBase))
                X.CreateMap<Livro, LivroViewModels>();
                X.CreateMap<Autor, AutorViewModels>();
                X.CreateMap<Genero, GeneroViewModels>();
                X.CreateMap<Editora, EditoraViewModels>();
                #region ABSOLETO
                ////VOLTA
                X.CreateMap<LivroViewModels, Livro>();
                X.CreateMap<AutorViewModels, Autor>();
                X.CreateMap<GeneroViewModels, Genero>();
                X.CreateMap<EditoraViewModels, Editora>();

                //    ////X.AddProfile<>();Domain
                //    ////X.AddProfile<>();ViewModels
                    #endregion
            });
        }

    }
}