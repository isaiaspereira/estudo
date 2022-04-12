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

        public object LoginUser(string email,string password)
        {

            if (_acessoCliente.ClienteAutenticate(email) != null)
            {
                AcessoCliente cliente = _acessoCliente.ClienteAutenticate(email);
                if (_security.DecryptPassword(password,cliente.Senha))
                    return _acessoCliente.ClienteAutenticate(email);

                return null;
            }
            if (_acessoUsuario.UsuarioAutenticate(email) != null)
            {
                AcessoUsuario usuario = _acessoUsuario.UsuarioAutenticate(email);
                if (_security.DecryptPassword(password, usuario.Senha))
                    return _acessoUsuario.UsuarioAutenticate(email);

                return null;
            }
            return null;
        }
    }
}
