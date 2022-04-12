using System.Collections.Generic;
namespace Livraria.Domain.Interfece
{
    public interface IRepositorybase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int Id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);


        void Dispose();
    }
}
