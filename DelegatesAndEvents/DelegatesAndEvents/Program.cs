﻿using DelegatesAndEvents.Factory;
using DelegatesAndEvents.Models;
using System;
using System.Collections.Generic;

namespace TestOut
{
    class Program
    {
        static void Main(string[] args)
        {

            //Publisher<Book> pubBook = new Publisher<Book>();
            //Publisher<Author> authorPublisher = new Publisher<Author>();
            //User testUser = new User("Vladimir", "Pozner");

            //Store store = new Store();
            //Author a1 = new Author("John", "White");
            //Book b1 = new Book(a1, "C# for Dumms", new DateTime(2012, 2, 15), description: "sdf") { Description = "This book is good for beginers" };

            //Order testOrder = new Order(testUser, b1);

   
            
            try
            {
                var factoryInstance = BookFactory.Instance;
                
                //var author2 = factoryInstance.("Alexandr", "Nemoi");
                
                
                //Console.WriteLine(author2);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }
    }
}
