using Livraria.MVC.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;
using WebActivator;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initializer")]
namespace Livraria.MVC.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initializer()
        {
            //Chamada dos Modulos do Simple Injector
            var container = new Container();
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(CrossCutting.IoC.DIContainer.RegisterDependencies(container)));
        }
    }
}