using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class Claim : IdentifyClass
    {
        
        public Book Subject { get; }
        public User Person { get; } 
        public DateTime TakeDate { get; } = DateTime.Now;
        public DateTime EndDate { get; private set; } 
        public int DayLeft => (EndDate - DateTime.Today).Days;

        public Claim(User user, Book book)
        {
            if (user == null)
                throw new ArgumentNullException($"{nameof(user)} is null");
            if (book == null)
                throw new ArgumentNullException($"{nameof(book)} is null");

            Person = user;
            Subject = book;
            Subject.Status = BookStatus.Busy;
            EndDate = TakeDate.AddDays(21);
        }

        public bool GiveTheBook(Book book)
        {
            if (Person.CurrentBooks.Count > 3) // 
                return false;
            return true;
        }

        void TermExtend()
        {
            throw new NotImplementedException();
        }
    }
}
