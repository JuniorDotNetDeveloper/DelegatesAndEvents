using System;
using System.Collections.Generic;
using Model.Models;

namespace IRepository.Interfaces
{
    public interface IBookRepository<Book> : IRepository<Book> where Book : Entity
    {
        void ModifyBook(long id, string description);
        void AddNewBook(Book book);
    }
}
