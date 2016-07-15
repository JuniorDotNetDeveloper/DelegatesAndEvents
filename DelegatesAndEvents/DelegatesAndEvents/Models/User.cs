using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class User : IdentifyClass
    {
        public string FirstName { get; }
        public string LastName { get; }
        public IList<Book> CurrentBooks { get; } = new List<Book>();

        public User(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException($"{nameof(firstName)} is null or empty");
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException($"{nameof(lastName)} is null or empty");

            FirstName = firstName;
            LastName = lastName;
        }

        public void TakeTheBook(Book book)
        {
            var claim = new Claim(this, book);

            if (claim.GiveTheBook(book))
                CurrentBooks.Add(book);
        }
    }
}
