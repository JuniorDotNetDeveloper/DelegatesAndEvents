using System;
using System.Collections.Generic;

namespace IRepository.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> Collection { get; }
        void Create(T item); 
        void Update(T item);
        void Delete(int id);
        T FindById(int id);
    }
}