using System;

namespace Model.Models
{
    class Bibliotec
    {
        public Book AllBook { get; }
        public Author AllAuthor{ get; }
        public int BookCount { get; private set; }
        public DateTime AddDate { get; } = DateTime.Now;


    }
}
