using System;
using System.Collections.Generic;

namespace DelegatesAndEvents.Models
{
    enum BookStatus : byte { Busy, Free }

    internal class Book : IdentifyClass
    {
        public string Name { get; set; }
        public int PublicationYear{ get; private set; }
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(Author author, string bookName, int publicationDate)
        {
            Authors = new List<Author>();
            Authors.Add(author);

            Name = bookName;
            PublicationYear = publicationDate;
            Status = BookStatus.Free;
        }
        public override string ToString()
        {
            return string.Format($"Book name: {Name}, Autors: {Authors.ToString()}");
        }
    }
}