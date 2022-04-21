using AutoMapper;
using Infra.Context;
using Livraria.Application.Interface;
using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using Livraria.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Livraria.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAutenticateService _autenticate;
        private readonly IAcessoClienteService _acessoClienteService;
        private readonly IAcessoUsuarioAppService _usuarioApp;
        private readonly IClienteService _clienteApp;

        public AccountController(IAcessoUsuarioAppService acessoUsuarioAppService, IAcessoClienteService acessoClienteService,
            IAutenticateService autenticate, IClienteService clienteApp)
        {
            _acessoClienteService = acessoClienteService;
            _autenticate = autenticate;
            _usuarioApp = acessoUsuarioAppService;
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
                var Nome = _clienteApp.GetAll().Where(c => c.AcessoCliente.Email == loginView.Email).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(loginView.Email, loginView.LembrarMe);

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

