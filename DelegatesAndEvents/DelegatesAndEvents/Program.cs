using System;
using Factory.Factories;
using Model.Models;
using Infrastructure;
using IRepository.Interfaces;

namespace DelegatesAndEvents
{
    class Program
    {
        static Program()
        {
            ServiceLocator.RegisterAll();
        }

        static void Main(string[] args)
        {
            var bookRepository = ServiceLocator.Resolver<IBookRepository<Book>>();

            var _bookFactory = new BookFactory();
            var book = _bookFactory.CreateNewBook_WithSingleAuthor(new Author("john", "Vasea"), "C# Advanced", DateTime.Now);
            //bookRepository.ModifyBook(1,"add description");
            bookRepository.AddNewBook(book);

            Console.ReadLine();
        }
    }
}