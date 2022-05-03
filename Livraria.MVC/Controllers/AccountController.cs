using Livraria.Application.Interface;
using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Domain.Interfece.Servico;
using Livraria.MVC.ViewModels;
using System;
using System.ComponentModel;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Livraria.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAutenticateService _autenticate;
        private readonly IAcessoClienteService _acessoClienteService;
        private readonly IAcessoUsuarioService _usuarioApp;
        private readonly IClienteService _clienteApp;

        public AccountController(
            IAcessoUsuarioService acessoUsuarioService,
            IAcessoClienteService acessoClienteService,
            IAutenticateService autenticate,
            IClienteService clienteApp)
        {
            _acessoClienteService = acessoClienteService;
            _autenticate = autenticate;
            _usuarioApp = acessoUsuarioService;
            _clienteApp = clienteApp;
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {

            ViewBag.RetunUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModels loginView, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(loginView);
            }

            if (_autenticate.LoginUser(loginView.Email, loginView.Senha, loginView.LembrarMe) != null)
            {
                string nameOfCliente = _acessoClienteService.ClienteOfAccess(loginView.Email).Nome.ToString();
                var nameOfPerfilAcessos =string.Join(";",_acessoClienteService.GetNamePerfilAcesso(loginView.Email));
                var ticketAutenticate =
                     FormsAuthentication.Encrypt(new FormsAuthenticationTicket
                     (1, nameOfCliente, DateTime.Now, DateTime.Now.AddHours(12), loginView.LembrarMe, nameOfPerfilAcessos));
                var cookieAutentication = new HttpCookie(FormsAuthentication.FormsCookieName, ticketAutenticate);
                Response.Cookies.Add(cookieAutentication);

                if (Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "home");
            }
            else
            {
                ModelState.AddModelError("", "Usuario ou Senha Inválido");
            }
            return View(loginView);
        }
        [HttpGet]
        public ActionResult Logoff()
        {
            var emailForLogoff = User.Identity.Name;
            _autenticate.Logoff(emailForLogoff);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }

    }
}

