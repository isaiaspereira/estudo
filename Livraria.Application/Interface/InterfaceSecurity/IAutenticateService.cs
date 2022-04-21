﻿using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interface.InterfaceSecurity
{
    public interface IAutenticateService
    {
        void CreatCliente(AcessoCliente acessoCliente,string NomeClienteAdd);
        void CreatUser(AcessoUsuario acessoUsuario,string NomeUsuarioAdd);
        object LoginUser(string email,string senha,bool lembrarMe);
        bool Logoff(string emailForLogoff);
    }
}
