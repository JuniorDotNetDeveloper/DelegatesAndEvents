using System;
using System.Collections.Generic;
using Model.Models;
using Repository.Implementation.Contexts;
using IRepository.Interfaces;

namespace Repository.Implementation
{
    public class AuthorRepository : IRepository<Author>
    {
        private ModelContext<Author> _authorRepository;
        
        public IEnumerable<Author> Collection { get; }
        public void Create(Author item)
        {
            _authorRepository.Objects.Add(item);
        }

        public void Update(Author item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var author = _authorRepository.Objects.Find(a => a.Id == id);
            _authorRepository.Objects.Remove(author);
        }

        public Author FindById(int id)
        {
            return _authorRepository.Objects.Find(a => a.Id == id);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
