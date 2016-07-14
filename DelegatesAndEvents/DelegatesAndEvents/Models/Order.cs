using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class Order : IdentifyClass
    {
        
        public Book Subject { get; }
        public User Person { get; }
        public DateTime TakeDate { get; } = DateTime.Now;
        public DateTime EndDate { get; private set; } 
        public int DayLeft => (EndDate - DateTime.Now).Days;

        public Order(User user, Book book)
        {
            Person = user;
            Subject = book;
            Subject.Status = BookStatus.Busy;
            EndDate = TakeDate.AddDays(21);
        }
    }
}
