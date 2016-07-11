using DelegatesAndEvents.EventsWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class Store
    {
        //public IPublisher<Book> BookPublisher { get; set; }
        //public IPublisher<Author> AuthorPublisher { get; set; }

        public IList<Book> BooksInStore { get; set; }
        public IList<Author> AuthorsInStore { get; set; }


        public Store()
        {
            BooksInStore = new List<Book>();
            AuthorsInStore = new List<Author>();
        }
        //public Store(IPublisher<Book> e)
        //{
        //    BooksInStore = new List<Book>();
        //    AuthorsInStore = new List<Author>();
        //    e.DataPublisher += ExtendStoreLists;
        //}

        //public Store(IPublisher<Author> e)
        //{
        //    BooksInStore = new List<Book>();
        //    AuthorsInStore = new List<Author>();
        //    e.DataPublisher += ExtendStoreLists;
        //}


        public void ExtendStoreLists(object sender, EventArguments<Book> newBook)
        {
            BooksInStore.Add(newBook._Object);
            Console.WriteLine("New book added");
        }

        public void ExtendStoreLists(object sender, EventArguments<Author> newAuthor)
        {
            AuthorsInStore.Add(newAuthor._Object);
            Console.WriteLine("new author added");
        }
    }
}
