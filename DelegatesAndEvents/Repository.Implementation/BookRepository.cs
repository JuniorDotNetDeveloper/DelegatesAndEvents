using System.Configuration;
using IRepository.Interfaces;
using Model.Models;
using NHibernate;

namespace Repository.Implementation
{
    public class BookRepository : Repository<Book>,  IBookRepository<Book>
    {
        public void ModifyBook(long id, string description)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                var book = _session.Load<Book>(id);
                book.Description = description;
                transaction.Commit();
            }
        }

        public void AddNewBook(Book book)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Save(book);
                transaction.Commit();
            }
        }
    }
}
