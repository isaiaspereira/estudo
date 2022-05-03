using Livraria.Application.Interface;
using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System.Linq;

namespace Livraria.Application.Services.Login
{
    public class AutenticateService : IAutenticateService
    {
        IClienteAppService _clienteApp;
        IUsuarioService _usuarioApp;
        IAcessoClienteService _acessoCliente;
        IAcessoUsuarioService _acessoUsuario;
        ISecurity _security;
        public AutenticateService(IAcessoClienteService acessoCliente, IUsuarioService usuarioService, IAcessoUsuarioService acessoUsuario, ISecurity security, IClienteAppService ClienteApp)
        {
            _acessoCliente = acessoCliente;
            _security = security;
            _acessoUsuario = acessoUsuario;
            _clienteApp = ClienteApp;
            _usuarioApp = usuarioService;
        }

        public void CreatCliente(AcessoCliente acessoCliente, string NomeClienteAdd)
        {
            Cliente cliente = _clienteApp.GetAll().Where(c => c.Nome == NomeClienteAdd).FirstOrDefault();
            acessoCliente.AcessoClienteId = cliente.ClienteId;
            acessoCliente.Senha = _security.EncryptPassword(acessoCliente.Senha);
            _acessoCliente.Add(acessoCliente);
        }

        public void CreatUser(AcessoUsuario acessoUsuario, string NomeUsuarioAdd)
        {
            acessoUsuario.Senha = _security.EncryptPassword(acessoUsuario.Senha);
            _acessoUsuario.Add(acessoUsuario);
        }

        public object LoginUser(string email, string password, bool lembrarMe)
        {

            if (_acessoCliente.ClienteAutenticate(email) != null)
            {
                AcessoCliente cliente = _acessoCliente.ClienteAutenticate(email);
                cliente.LembrarMe = lembrarMe;
                if (_security.DecryptPassword(password, cliente.Senha))
                {
                    _acessoCliente.Update(cliente);
                    return (cliente);
                }
                return null;
            }
            if (_acessoUsuario.UsuarioAutenticate(email) != null)
            {
                AcessoUsuario usuario = _acessoUsuario.UsuarioAutenticate(email);
                usuario.LembrarMe = lembrarMe;
                if (_security.DecryptPassword(password, usuario.Senha))
                {
                    _acessoUsuario.Update(usuario);
                    return _acessoUsuario.UsuarioAutenticate(email);
                }
                return null;
            }
            return null;
        }
        public bool Logoff(string emailForLogoff)
        {
            try
            {

                if (_clienteApp.GetAll().Select(c => c.Nome.ToLower() == emailForLogoff.ToLower()).FirstOrDefault())
                {
                    AcessoCliente acessoForLogoff = _acessoCliente.GetAll().Where(c => c.Cliente.Nome.ToLower() == emailForLogoff.ToLower()).FirstOrDefault();
                    acessoForLogoff.LembrarMe = false;
                    _acessoCliente.Update(acessoForLogoff);
                    return true;
                }
                else
                {
                    AcessoUsuario usurarioForLogoff = _acessoUsuario.GetAll().Where(c => c.Usuario.Nome.ToLower() == emailForLogoff.ToLower()).FirstOrDefault();
                    usurarioForLogoff.LembrarMe = false;
                    _acessoUsuario.Update(usurarioForLogoff);
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
    }
}
