using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents.Models
{
    enum BookStatus : byte { Busy, Free }

    internal class Book : IdentifyClass
    {
        public string Name { get; }
        public DateTime PublicationDate{ get; }
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public IList<Author> Authors { get; } = new List<Author>();

        public int HowOldIs () => DateTime.Now.Year - PublicationDate.Year; 

        public Book(Author author, string bookName, DateTime publicationDate, string description = "")
        {
            Authors.Add(author);

            Name = bookName;
            PublicationDate = publicationDate;
            Description = description;
            Status = BookStatus.Free;
        }


        public override string ToString()
        {
            StringBuilder authors = new StringBuilder();
            foreach (var author in Authors) authors.Append(author + ", ");

            return string.Format($"\nBook name: {Name}\nPublication year: {PublicationDate.Year}\nAuthors: {authors}\nDescription: {Description}\nHow Old: {HowOldIs()}");
        }
    }
}