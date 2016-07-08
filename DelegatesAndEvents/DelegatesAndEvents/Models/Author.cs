using DelegatesAndEvents.EventsWork;
using System;
using System.Collections.Generic;

namespace DelegatesAndEvents.Models
{
    internal class Author : IdentifyClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Book> PersonalBooks { get; private set; }


        //private NewBookFromAuthorEvent MyEvent = new NewBookFromAuthorEvent();
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalBooks = new List<Book>();
        }

        public void AddNewBook(Book book, NewBookFromAuthorEvent MyEvent)
        {
            PersonalBooks.Add(book);
            MyEvent.DoOnNewBook(book);
        }
    }
}