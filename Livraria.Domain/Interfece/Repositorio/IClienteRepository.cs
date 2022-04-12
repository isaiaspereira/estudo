﻿using Livraria.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfece.Repositorio
{
  public  interface IClienteRepository:IRepositorybase<Cliente>
    {
        IEnumerable<Cliente> BuscaPorNome(string nome);
    }
}