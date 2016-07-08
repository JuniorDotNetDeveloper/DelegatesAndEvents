using System;
using System.Collections.Generic;

namespace DelegatesAndEvents.Models
{
    enum BookStatus : byte { Busy, Free }

    internal class Book : IdentifyClass
    {
        public string Name { get; set; }
        public DateTime PublicationDate{ get; private set; }
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(Author author, string bookName, DateTime publicationDate)
        {
            Authors = new List<Author>();
            Authors.Add(author);

            Name = bookName;
            PublicationDate = publicationDate;
            Status = BookStatus.Free;
        }
        
    }
}