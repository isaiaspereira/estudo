using CrossCutting.IoC;
using Livraria.MVC.AutoMapper;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;



namespace Livraria.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutomapperConfig.RegisterMappings();

            var container = new Container();
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            container.Dispose();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(DIContainer.RegisterDependencies(container)));

        }
    }
}
