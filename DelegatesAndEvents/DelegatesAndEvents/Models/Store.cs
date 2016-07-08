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
        public IPublisher<Book> BookPublisher { get; set; }
        public IPublisher<Author> AuthorPublisher { get; set; }
        public IList<Book> BooksInStore { get; set; }
        public IList<Author> AuthorsInStore { get; set; }

        public Store(NewBookFromAuthorEvent e)
        {
            BooksInStore = new List<Book>();
            AuthorsInStore = new List<Author>();
            e.NewBook += ExtendStoreLists;   
        }

        
        public void ExtendStoreLists(object sender, Book newBook)
        {
            BooksInStore.Add(newBook);
            Console.WriteLine("New book added");
        }
        public void ExtendStoreLists(Author newAuthor)
        {
            AuthorsInStore.Add(newAuthor);
            Console.WriteLine("new author added");
        }
    }
}
