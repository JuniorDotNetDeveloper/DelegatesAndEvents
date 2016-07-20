using System;
using Model.Interfaces;

namespace Model.Models
{
    internal class Claim : IdentifyClass
    {
        
        public Book Subject { get; }
        public ICustomer Customer { get; } 
        public DateTime TakeDate { get; } = DateTime.Now;
        public DateTime EndDate { get; private set; } 
        public int DayLeft => (EndDate - DateTime.Today).Days;

        public Claim(ICustomer customer, Book book)
        {
            if (customer == null)
                throw new ArgumentNullException($"{nameof(customer)} is null");
            if (book == null)
                throw new ArgumentNullException($"{nameof(book)} is null");

            Customer = customer;
            Subject = book;
            Subject.Status = BookStatus.Busy;
            EndDate = TakeDate.AddDays(21);
        }

        public bool GiveTheBook(Book book)
        {
            var u = Customer as User;
            if (u?.CurrentBooks.Count > 3 | book?.Status == BookStatus.Busy)
                return false;
            return true;
        }

        void TermExtend()
        {
            throw new NotImplementedException();
        }
    }
}
