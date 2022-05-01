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
            container.Register(typeof(IRepositorybase<>), typeof(RepositoryBase<>), Lifestyle.Singleton);
            container.Register<IAcessoClienteRepository, AcessoClienteRepository>();
            container.Register<IAcessoUsuarioRepository, AcessoUsuarioRepository>();
            container.Register<IAutorRepository, AutorRepository>();
            container.Register<IClienteRepository, ClienteRepository>();
            container.Register<IContatoRepository, ContatoRepository>();
            container.Register<IEditoraRepository, EditoraRepository>();
            container.Register<IEnderecoRepository, EnderecoRepository>();
            container.Register<IGeneroRepository, GeneroRepository>();
            container.Register<ILivroRepository, LivroRepository>();
            container.Register<IOperadoraRepository, OperadoraRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
            #endregion
            #region Dependencia Do Serviço
            container.Register(typeof(IServicebase<>), typeof(ServiceBase<>), Lifestyle.Singleton);
            container.Register<IAcessoClienteService, AcessoClienteService>();
            container.Register<IAcessoUsuarioService, AcessoUsuarioService>();
            container.Register<IAutorService, AutorService>();
            container.Register<IClienteService, ClienteService>();
            container.Register<IContatoService, ContatoService>();
            container.Register<IEditoraService, EditoraService>();
            container.Register<IEnderecoService, EnderecoService>();
            container.Register<IGeneroService, GeneroService>();
            container.Register<ILivroService, LivroService>();
            container.Register<IOperadoraService, OperadoraService>();
            container.Register<IUsuarioService, UsuarioService>();
            #endregion
            #region Dependencia Da Application
            container.Register(typeof(IAppSeriveBase<>), typeof(AppServiceBase<>), Lifestyle.Singleton);
            container.Register<IAcessoClienteAppService, AcessoClienteAppService>();
            container.Register<IAcessoUsuarioAppService, AcessoUsuarioAppService>();
            container.Register<IAutorAppService, AutorAppService>();
            container.Register<IClienteAppService, ClienteAppService>();
            container.Register<ILivroAppService, LivroAppService>();
            container.Register<IGeneroAppService, GeneroAppService>();
            container.Register<IEditoraAppService, EditoraAppService>();
            container.Register<IAutenticateService, AutenticateService>();
            container.Register<ISecurity, Security>();
            container.Dispose();

            #endregion

            return container;
        }
    }
}
