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
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException($"{nameof(firstName)} is null or empty");
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException($"{nameof(lastName)} is null or empty");
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddNewBook(Book book, Publisher<Book> MyEvent)
        {
            if (book == null) throw new ArgumentNullException($"{nameof(book)} is null");
            PersonalBooks.Add(book);
            MyEvent.PublishData(book);
        }
    }
}