using System;
using System.Collections.Generic;

namespace Model.Models
{
    internal class User : IdentifyClass
    {
        public string FirstName { get; }
        public string LastName { get; }
        public IList<Book> CurrentBooks { get; } = new List<Book>();

        public User(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException($"{nameof(firstName)} is null or empty");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentNullException($"{nameof(lastName)} is null or empty");

            FirstName = firstName;
            LastName = lastName;
        }

        public void TakeTheBook(Book book, Claim claim)
        {
            if (claim.GiveTheBook(book))
                CurrentBooks.Add(book);
        }
    }
}
