

using System.Collections.Generic;

namespace AgiliBlueFood.Domain.Interfaces
{
    //classe de crud
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        //adiciona registros
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();


    }
}
