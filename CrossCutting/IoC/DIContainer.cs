using Infra.Repositories;
using Livraria.Application;
using Livraria.Application.Interface;
using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Application.Services;
using Livraria.Application.Services.Login;
using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using Livraria.Domain.Servico;
using SimpleInjector;

namespace CrossCutting.IoC
{
    public class DIContainer
    {
        public static Container RegisterDependencies(Container container)
        {
            #region Dependencia Do Repositorio
            container.Register(typeof(IRepositorybase<>), typeof(RepositoryBase<>), Lifestyle.Transient);
            container.Register<IAcessoClienteRepository, AcessoClienteRepository>(Lifestyle.Singleton);
            container.Register<IAcessoUsuarioRepository, AcessoUsuarioRepository>(Lifestyle.Singleton);
            container.Register<IAutorRepository, AutorRepository>(Lifestyle.Singleton);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Singleton);
            container.Register<IContatoRepository, ContatoRepository>(Lifestyle.Singleton);
            container.Register<IEditoraRepository, EditoraRepository>(Lifestyle.Singleton);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Singleton);
            container.Register<IGeneroRepository, GeneroRepository>(Lifestyle.Singleton);
            container.Register<ILivroRepository, LivroRepository>(Lifestyle.Singleton);
            container.Register<IOperadoraRepository, OperadoraRepository>(Lifestyle.Singleton);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Singleton);

            #endregion
            #region Dependencia Do Serviço
            container.Register(typeof(IServicebase<>), typeof(ServiceBase<>), Lifestyle.Transient);
            container.Register<IAcessoClienteService, AcessoClienteService>(Lifestyle.Singleton);
            container.Register<IAcessoUsuarioService, AcessoUsuarioService>(Lifestyle.Singleton);
            container.Register<IAutorService, AutorService>(Lifestyle.Singleton);
            container.Register<IClienteService, ClienteService>(Lifestyle.Singleton);
            container.Register<IContatoService, ContatoService>(Lifestyle.Singleton);
            container.Register<IEditoraService, EditoraService>(Lifestyle.Singleton);
            container.Register<IEnderecoService, EnderecoService>(Lifestyle.Singleton);
            container.Register<IGeneroService, GeneroService>(Lifestyle.Singleton);
            container.Register<ILivroService, LivroService>(Lifestyle.Singleton);
            container.Register<IOperadoraService, OperadoraService>(Lifestyle.Singleton);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Singleton);

            #endregion
            #region Dependencia Da Application
            container.Register(typeof(IAppSeriveBase<>), typeof(AppServiceBase<>), Lifestyle.Transient);
            container.Register<IAcessoClienteAppService, AcessoClienteAppService>(Lifestyle.Singleton);
            container.Register<IAcessoUsuarioAppService, AcessoUsuarioAppService>(Lifestyle.Singleton);
            container.Register<IAutorAppService, AutorAppService>(Lifestyle.Singleton);
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Singleton);
            container.Register<ILivroAppService, LivroAppService>(Lifestyle.Singleton);
            container.Register<IGeneroAppService, GeneroAppService>(Lifestyle.Singleton);
            container.Register<IEditoraAppService, EditoraAppService>(Lifestyle.Singleton);
            container.Register<IAutenticateService, AutenticateService>();
            container.Register<ISecurity, Security>();
            container.Verify();
            #endregion
            return container;
        }
    }
}
