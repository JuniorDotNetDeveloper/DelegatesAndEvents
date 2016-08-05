﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public enum BookStatus : byte { Busy, Free }

    public class Book : Entity
    {
        public virtual string Name { get; }
        public virtual DateTime PublicationDate{ get; }
        public virtual string Description { get; set; }
        public virtual BookStatus Status { get; set; } = BookStatus.Free;
        public virtual IList<Author> Authors { get; }

        public virtual int HowOldIs => DateTime.Now.Year - PublicationDate.Year;

        [Obsolete]
        protected Book() {}

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

            Description = description ?? "Without description";
        }

        public override string ToString()
        {
            StringBuilder authors = new StringBuilder();
            foreach (var author in Authors) authors.Append(author + ", ");

            return $"\nBook name: {Name}\nPublication year: {PublicationDate.Year}\nAuthors: {authors}\nDescription: {Description}\nHow Old: {HowOldIs}";
        }

        public override bool Equals(object other)
        {
            var toCompareWith = other as Book;
            if (toCompareWith == null)
                return false;
            return Name == toCompareWith.Name &&
                Authors == toCompareWith.Authors &&
                PublicationDate == toCompareWith.PublicationDate;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Authors.GetHashCode() + PublicationDate.GetHashCode();
        }
    }
}