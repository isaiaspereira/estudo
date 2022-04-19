using Livraria.Application.Interface.InterfaceSecurity;
using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services.Login
{
    public class AutenticateService : IAutenticateService
    {
        IAcessoClienteService _acessoCliente;
        IAcessoUsuarioService _acessoUsuario;
        ISecurity _security;
        public AutenticateService(IAcessoClienteService acessoCliente, IAcessoUsuarioService acessoUsuario, ISecurity security)
        {
            _acessoCliente = acessoCliente;
            _security = security;
            _acessoUsuario = acessoUsuario;
        }

        public void CreatCliente(AcessoCliente acessoCliente)
        {
            acessoCliente.Senha = _security.EncryptPassword(acessoCliente.Senha);
            _acessoCliente.Add(acessoCliente);
        }

        public void CreatUser(AcessoUsuario acessoUsuario)
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
            if (_acessoCliente.BuscaPorNome(emailForLogoff).Count() >= 0)
            {
                var clienteForLogoff = _acessoCliente.ClienteAutenticate(emailForLogoff);
                clienteForLogoff.LembrarMe = false;
                _acessoCliente.Update(clienteForLogoff);
                return true;
            }

            if (_acessoUsuario.BuscaPorNome(emailForLogoff).Count() >= 0)
            {
                var usurarioForLogoff = _acessoUsuario.UsuarioAutenticate(emailForLogoff);
                usurarioForLogoff.LembrarMe = false;
                _acessoUsuario.Update(usurarioForLogoff);
                return true;
            }
            return false;
        }
    }
}
