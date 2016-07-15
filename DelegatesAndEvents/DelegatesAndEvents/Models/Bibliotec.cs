using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    class Bibliotec
    {
        public Book AllBook { get; }
        public Author AllAuthor{ get; }
        public int BookCount { get; private set; }
        public DateTime AddDate { get; } = DateTime.Now;


    }
}
