using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using IRepository.Interfaces;
using Model.Models;
using NHibernate;

namespace Repository.Implementation
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ISession _session = SessionGenerator.Instance.GetSession();

        public IEnumerable<TEntity> Collection { get; }
        public void Create(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity FindById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
