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
            NewBookFromAuthorEvent evnt = new NewBookFromAuthorEvent();
            Store amazone = new Store(evnt);

            Author a1 = new Author("John", "White");
            Book b1 = new Book(a1, "C# for Dumms", new DateTime(2012, 2, 15));

            Publisher<Author> pub = new Publisher<Author>();
            Subscribe<Store> sub = new Subscribe<Store>(pub);

            //a1.AddNewBook(new Book(a1, "C# for Dumms", new DateTime(2012, 2, 15)), evnt);


            Console.ReadLine();
        }
    }
}
