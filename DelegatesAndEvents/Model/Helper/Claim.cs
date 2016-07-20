using System;
using Model.Models;

namespace Model.Helper
{
    internal class Claim : IdentifyClass
    {
        
        public Book Subject { get; }
        public User Person { get; } 
        public DateTime TakeDate { get; } = DateTime.Now;
        public DateTime EndDate { get; private set; } 
        public int DayLeft => (EndDate - DateTime.Today).Days;

        public Claim(User person, Book book)
        {
            if (person == null)
                throw new ArgumentNullException($"{nameof(person)} is null");
            if (book == null)
                throw new ArgumentNullException($"{nameof(book)} is null");

            Person = person;
            Subject = book;
            Subject.Status = BookStatus.Busy;
            EndDate = TakeDate.AddDays(21);
        }

        public bool GiveTheBook(Book book)
        {
            
            if (Person?.CurrentBooks.Count > 3 | book?.Status == BookStatus.Busy)
                return false;
            return true;
        }

        void TermExtend()
        {
            throw new NotImplementedException();
        }
    }
}
