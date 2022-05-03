using CrossCutting.IoC;
using Livraria.MVC.AutoMapper;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Reflection;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

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


        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            var CookieAutentication = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (CookieAutentication != null && CookieAutentication.Value != string.Empty)
            {
                FormsAuthenticationTicket ticketAutentication;
                try
                {
                    ticketAutentication = FormsAuthentication.Decrypt(CookieAutentication.Value);
                }
                catch
                {

                    return;
                }

                var PerfilAcesso = ticketAutentication.UserData.Split(';');
                if (Context.User != null)
                {
                    Context.User = new GenericPrincipal(Context.User.Identity,PerfilAcesso);
                }
            }
        }
    }
}
