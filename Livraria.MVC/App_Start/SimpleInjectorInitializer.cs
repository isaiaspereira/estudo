using Livraria.MVC.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;
using WebActivator;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initializer")]
namespace Livraria.MVC.App_Start
{
    public static class SimpleInjectorInitializer
    {
        //public static void Initializer()
        //{
        //    var container = new Container();
           
        //    //Chamada dos Modulos do Simple Injector
        //    InitializeContainer(container);
        //    container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
        //    container.Dispose();
        //    container.Verify();
        //    DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
           
            
        //}
        //private static void InitializeContainer(Container container)
        //{
        //    CrossCutting.IoC.DIContainer.Start(container);
        //}
    }
}