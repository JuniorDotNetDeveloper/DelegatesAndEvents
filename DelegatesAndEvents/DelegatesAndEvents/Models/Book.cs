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
        public BookStatus Status { get; set; } = BookStatus.Free;
        public IList<Author> Authors { get; } = new List<Author>();

        public int HowOldIs => DateTime.Now.Year - PublicationDate.Year;


        //private Book(string bookName, DateTime publicationDate)
        //{
        //    if (string.IsNullOrEmpty(bookName))
        //        throw new ArgumentNullException($"Next field named: {nameof(bookName)} is null or empty");
        //    if (publicationDate == null)
        //        throw new ArgumentNullException($"{nameof(publicationDate)} is requared");

        //    Name = bookName;
        //    PublicationDate = publicationDate;
        //}

        //public Book(Author author, string bookName, DateTime publicationDate, string description)
        //{
        //    ValidateInput(bookName, publicationDate, description);
        //    if (author == null) throw new ArgumentNullException($"{nameof(author)} is requared");

        //    Authors.Add(author);
        //    Name = bookName;
        //    PublicationDate = publicationDate;
            
        //}

       
        public Book(List<Author> authors, string bookName, DateTime publicationDate, string description)
        {
            ValidateInput(authors, bookName, publicationDate, description);
            
            Authors = authors;
            Name = bookName;
            PublicationDate = publicationDate;
        }

        private void ValidateInput(List<Author> authors, string bookName, DateTime publicationDate, string description)
        {
            if (string.IsNullOrEmpty(bookName))
                throw new ArgumentNullException($"Next field named: {nameof(bookName)} is null or empty");
            if (publicationDate == null)
                throw new ArgumentNullException($"{nameof(publicationDate)} is requared");
            if (authors == null) throw new ArgumentNullException($"{nameof(authors)} is requared");

            Description = description?.ToString() ?? "Without description";
        }

        public override string ToString()
        {
            StringBuilder authors = new StringBuilder();
            foreach (var author in Authors) authors.Append(author + ", ");

            return $"\nBook name: {Name}\nPublication year: {PublicationDate.Year}\nAuthors: {authors}\nDescription: {Description}\nHow Old: {HowOldIs}";
        }
    }
}