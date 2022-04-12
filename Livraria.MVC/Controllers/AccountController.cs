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
        private readonly ISecurity _security;
        public AccountController(IAcessoUsuarioAppService acessoUsuarioAppService,
            ISecurity security, IAcessoClienteService acessoClienteService,
            IAutenticateService autenticate, IClienteService clienteApp)
        {
            _acessoClienteService = acessoClienteService;
            _autenticate = autenticate;
            _usuarioApp = acessoUsuarioAppService;
            _security = security;
            _clienteApp = clienteApp;
        }
        public ActionResult CreatLogin()
        {
            ViewBag.AcessoClienteId = new SelectList(_clienteApp.GetAll(),"ClienteId","Nome");
            return View();
        }
        [HttpPost]
        public ActionResult CreatLogin(AcessoClienteViewModels acessoClienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var addAcessoCliente = Mapper.Map<AcessoClienteViewModels, AcessoCliente>(acessoClienteViewModel);
                _autenticate.CreatCliente(addAcessoCliente);
                return RedirectToAction("index","home");
            }
            var listaCliente = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModels>>(_clienteApp.GetAll());
            ViewBag.ClienteId = new SelectList(listaCliente, "ClienteId", "Nome", acessoClienteViewModel.AcessoClienteId);
            return View(acessoClienteViewModel);
            
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string retunUrl)
        {
            ViewBag.RetunUrl = retunUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModels loginView, string retunUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(loginView);
            }

            if (_autenticate.LoginUser(loginView.Email, loginView.Senha) != null)
            {
                FormsAuthentication.SetAuthCookie(loginView.Email, loginView.LembrarMe);

                if (Url.IsLocalUrl(retunUrl))
                    return Redirect(retunUrl);

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
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}

