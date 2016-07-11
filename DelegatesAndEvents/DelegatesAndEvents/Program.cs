using DelegatesAndEvents.EventsWork;
using DelegatesAndEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOut
{
    class Program
    {
        static void Main(string[] args)
        {

            Publisher<Book> pubBook = new Publisher<Book>();
            Publisher<Author> authorPublisher = new Publisher<Author>();

            Store store = new Store();
            Author a1 = new Author("John", "White");
            Book b1 = new Book(a1, "C# for Dumms", new DateTime(2012, 2, 15));

            Subscribe<Author> authorSubscriber = new Subscribe<Author>(authorPublisher);
            Subscribe<Book> bookSubscriber = new Subscribe<Book>(pubBook);

            bookSubscriber.Publisher.DataPublisher += store.ExtendStoreLists;
            authorSubscriber.Publisher.DataPublisher += store.ExtendStoreLists;

            //a1.AddNewBook(b1, pubBook);
            pubBook.PublishData(b1);
            authorPublisher.PublishData(a1);
            
            


            Console.ReadLine();
        }
    }
}
