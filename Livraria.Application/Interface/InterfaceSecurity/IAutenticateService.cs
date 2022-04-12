using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface.InterfaceSecurity
{
    public interface IAutenticateService
    {
        void CreatCliente(AcessoCliente acessoCliente);
        void CreatUser(AcessoUsuario acessoUsuario);
        object LoginUser(string email,string senha);
    }
}
