using DelegatesAndEvents.EventsWork;
using System;
using System.Collections.Generic;

namespace DelegatesAndEvents.Models
{
    internal class Author : IdentifyClass
    {
        public string FirstName { get; }
        public string LastName { get; }
        public IList<Book> PersonalBooks { get;  } = new List<Book>();


        //private NewBookFromAuthorEvent MyEvent = new NewBookFromAuthorEvent();
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddNewBook(Book book, Publisher<Book> MyEvent)
        {
            PersonalBooks.Add(book);
            MyEvent.PublishData(book);
        }
    }
}