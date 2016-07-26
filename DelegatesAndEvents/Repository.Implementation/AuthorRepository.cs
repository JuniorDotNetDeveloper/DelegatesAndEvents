using System;
using System.Collections.Generic;
using System.Linq;
using Model.Models;
using Repository.Implementation.Contexts;
using IRepository.Interfaces;

namespace Repository.Implementation
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly ModelContext<Author> _authorRepository;


        public AuthorRepository()
        {
            _authorRepository = new ModelContext<Author>();
            Initializer();
        }
        public IEnumerable<Author> Collection { get { return  _authorRepository.Objects.ToList(); } }
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

        private void Initializer()
        {
            List<Author> authorList = new List<Author>()
            {
                new Author("Alexandr", "Pushkin"),
                new Author("Lev", "Tolstoi"),
                new Author("Maxin", "Gorikii"),
                new Author("Alexei", "Tolstoi"),
                new Author("Nikolai", "Gogoli"),
                new Author("Mihail", "Lermontov"),
                new Author("Fedor", "Tiutchev"),
                new Author("Ivan", "Turgenev"),
                new Author("Afanasii", "Fet"),
                new Author("Fedor", "Dostoevskii"),
                new Author("Appolon", "Maikov"),
                new Author("Alexandr", "Ostrovskii"),
                new Author("Mihail", "Saltikov-Shedrin"),
                new Author("Nikolai", "Leskov"),
                new Author("Gleb", "Uspenskii"),
                new Author("NoBook", "Author")
            };
            _authorRepository.Objects = authorList;
        }
    }
}
