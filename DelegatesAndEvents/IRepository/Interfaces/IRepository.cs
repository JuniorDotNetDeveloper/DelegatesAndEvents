using System;
using System.Collections.Generic;
using Model.Models;

namespace IRepository.Interfaces
{
    public interface IRepository<TEntity> 
        where TEntity : Entity
    {
        IEnumerable<TEntity> Collection { get; }
        void Create(TEntity entity); 
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save(TEntity entity);
        TEntity FindById(int id);
    }
}