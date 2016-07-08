using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class Order : IdentifyClass
    {
        public Book Subjet { get; set; }
        public User Person { get; set; }
        public DateTime TakeDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
