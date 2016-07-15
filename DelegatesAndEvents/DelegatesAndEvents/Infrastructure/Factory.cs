using DelegatesAndEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndEvents.Factory
{
    class SingltoneFactory
    {
        private static readonly Lazy<SingltoneFactory> lazyInstance = new Lazy<SingltoneFactory>(() => new SingltoneFactory(), true);
        public static SingltoneFactory Instance { get { return lazyInstance.Value; } }

        //Private Constructor 
        private SingltoneFactory() { }

        
        public Author CreateNewAuthor(string firstName, string lastName, IList<Book> personalBooks = null)
        {
            var author = new Author(firstName, lastName, personalBooks);
            return author;
        }

        public Book CreateNewBook(Author author, string bookName, DateTime publicationDate, string optionalDescription = null)
        {
            if (string.IsNullOrWhiteSpace(optionalDescription))
                optionalDescription = "This book is without Description";

            var book = new Book(author, bookName, publicationDate, optionalDescription);
            return book;
        }

        public Order CreateNewOrder(User user, Book book)
        {
            var order = new Order(user, book);
            return order;
        }

        public Store CreateNewStore()
        {
            var store = new Store();
            return store;
        }
    }
}
