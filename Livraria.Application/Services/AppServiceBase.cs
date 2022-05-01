using Livraria.Application.Interface;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppSeriveBase<TEntity> where TEntity : class
    {
        private readonly IServicebase<TEntity> _Servicebase;
        public AppServiceBase(IServicebase<TEntity> servicebase)
        {
            _Servicebase = servicebase;
        }
        public void Add(TEntity obj)
        {
            _Servicebase.Add(obj);
        }

        public void Dispose()
        {
            _Servicebase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Servicebase.GetAll().ToList();
        }

        public TEntity GetById(int Id)
        {
            return _Servicebase.GetById(Id);
        }

        public void Remove(TEntity obj)
        {
            _Servicebase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _Servicebase.Update(obj);
        }
    }
}
