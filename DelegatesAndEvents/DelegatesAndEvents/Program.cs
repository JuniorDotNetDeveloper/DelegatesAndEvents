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

            Author a1 = new Author("John", "White");
            Book b1 = new Book(a1, "C# for Dumms", new DateTime(2012, 2, 15));

            Store amazone = new Store(evnt);

            a1.AddNewBook(b1, evnt);


            Console.ReadLine();
        }
    }
}
