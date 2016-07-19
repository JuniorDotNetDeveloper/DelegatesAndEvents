using System;
using EventsRealisation.EventsWork;
using Factory;
using Factory.Factories;
using Model.Models;
using Infrastructure;

namespace DelegatesAndEvents
{
    class Program
    {
        public Program()
        {
            ServiceLocator.RegisterAll();
        }

        static void Main(string[] args)
        {
            var bookFactory = ServiceLocator.Resolver<BookFactory>();

            Publisher<Book> pubBook = new Publisher<Book>();
            Publisher<Author> authorPublisher = new Publisher<Author>();
            User testUser = new User("Vladimir", "Pozner");

            Store store = new Store();
            Author a1 = new Author("John", "White");
            Book b1 = bookFactory.CreateNewBook_WithSingleAuthor(a1, "C# for Dumms", new DateTime(2012, 2, 15), "This book is good for beginers");

            Claim testOrder = new Claim(testUser, b1);

   
            
            try
            {
                var factoryInstance = BookFactory.Instance;
                
                var author2 = new Author("Alexandr", "Nemoi");
                var book = factoryInstance.CreateNewBook_WithSingleAuthor(author2, "C# for Dumms", new DateTime(2012, 2, 15));

                Console.WriteLine(book);
                Console.WriteLine(author2);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }
    }
}
