using AutoMapper;
using Livraria.Application.Interface;
using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Domain.Entitis;
using Livraria.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Livraria.MVC.Controllers
{
    public class ClienteController : Controller
    {
        IClienteAppService _clienteApp;
        IAutenticateService _autenticate;
        IAcessoClienteAppService _acessoCliente;
        public ClienteController(IClienteAppService clienteApp, IAutenticateService autenticate, IAcessoClienteAppService acessoCliente)
        {
            _clienteApp = clienteApp;
            _autenticate = autenticate;
            _acessoCliente = acessoCliente;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            var ListaDeClientes = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModels>>(_clienteApp.GetAll());
            return View(ListaDeClientes);
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(ClienteViewModels clienteView)
        {
            if (ModelState.IsValid)
            {

                var ClienteAdd = Mapper.Map<ClienteViewModels, Cliente>(clienteView);
                _clienteApp.Add(ClienteAdd);
                var AcessoClienteAdd = new AcessoCliente { Email = clienteView.AcessoClienteView.Email, Senha = clienteView.AcessoClienteView.Senha, LembrarMe = false };
                _autenticate.CreatCliente(AcessoClienteAdd, clienteView.Nome);
                return RedirectToAction("Index", "Cliente");
            }

            return View(clienteView);
        }
    }
}