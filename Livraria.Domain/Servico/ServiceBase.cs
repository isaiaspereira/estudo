using Livraria.Domain.Interfece;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Domain.Servico
{
    public class ServiceBase<TEntity> : IDisposable, IServicebase<TEntity> where TEntity : class
    {
        private readonly IRepositorybase<TEntity> _repository;
        public ServiceBase(IRepositorybase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public TEntity GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
