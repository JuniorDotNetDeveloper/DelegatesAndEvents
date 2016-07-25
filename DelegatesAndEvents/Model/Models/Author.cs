using System;
using System.Collections.Generic;
using EventsRealisation.EventsWork;

namespace Model.Models
{
    public class Author : IdentifyClass
    {
        public string Customer => $"{FirstName} {LastName}";
        public string FirstName { get; }
        public string LastName { get; }
        public IList<Book> PersonalBooks { get;  } = new List<Book>();

        //private NewBookFromAuthorEvent MyEvent = new NewBookFromAuthorEvent();
        public Author(string firstName, string lastName, IList<Book> personalBooks = null)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException($"{nameof(firstName)} is null or empty");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentNullException($"{nameof(lastName)} is null or empty");

            PersonalBooks = personalBooks ?? new List<Book>();
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddNewBook(Book book, Publisher<Book> MyEvent)
        {
            if (book == null)
                throw new ArgumentNullException($"{nameof(book)} is null");

            PersonalBooks.Add(book);
            MyEvent.PublishData(book);
        }

        public override string ToString()
        {
            return $"Author: {FirstName} {LastName}\n";
        }
    }
}