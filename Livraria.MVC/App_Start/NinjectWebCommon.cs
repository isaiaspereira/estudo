[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Livraria.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Livraria.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Livraria.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Domain.Interfece;
    using Livraria.Application;
    using Livraria.Application.Interface;
    using Livraria.Domain.Interfece.Servico;
    using Livraria.Domain.Servico;
    using Infra.Repositories;
    using Livraria.Domain.Entitis;
    using Livraria.MVC.ViewModels;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppSeriveBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAutorAppService>().To<AutorAppService>();
            kernel.Bind<ILivroAppService>().To<LivroAppService>();
            kernel.Bind<IGeneroAppService>().To<GeneroAppService>();
            kernel.Bind<IEditoraAppService>().To<EditoraAppService>();

            kernel.Bind(typeof(IServicebase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IAutorService>().To<AutorService>();
            kernel.Bind<ILivroService>().To<LivroService>();
            kernel.Bind<IGeneroService>().To<GeneroService>();
            kernel.Bind<IEditoraService>().To<EditoraService>();

            kernel.Bind(typeof(IRepositorybase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IAutorRepository>().To<AutorRepository>();
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
            kernel.Bind<IGeneroRepository>().To<GeneroRepository>();
            kernel.Bind<IEditoraRepository>().To<EditoraRepository>();
            kernel.Bind<Autor, AutorViewModels>();
            kernel.Bind<Livro, LivroViewModels>();
            kernel.Bind<Genero, GeneroViewModels>();
            kernel.Bind<Editora, EditoraViewModels>();
        }
    }
}
