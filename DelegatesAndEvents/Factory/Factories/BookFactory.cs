using System;
using System.Collections.Generic;
using Model.Models;

namespace Factory.Factories
{
    sealed class BookFactory
    {
//        private static readonly Lazy<BookFactory> lazyInstance = new Lazy<BookFactory>(() => new BookFactory(), true);
//        public static BookFactory Instance { get { return lazyInstance.Value; } }


        //Private Constructor 

        public Book CreateNewBook_WithSingleAuthor(Author author, string bookName, DateTime publicationDate, string optionalDescription = null)
        {
            if (string.IsNullOrWhiteSpace(optionalDescription))
                optionalDescription = "This book is without Description";
            if (author == null)
                throw new ArgumentNullException($"{nameof(author)} is requared");

            var listAuthors = new List<Author>();
            listAuthors.Add(author);
            var book = new Book(listAuthors, bookName, publicationDate, optionalDescription);
            return book;
        }

        public Book CreateNewBook_WithListAuthors(List<Author> authors, string bookName, DateTime publicationDate, string optionalDescription = null)
        {
            if (string.IsNullOrWhiteSpace(optionalDescription))
                optionalDescription = "This book is without Description";

            var book = new Book(authors, bookName, publicationDate, optionalDescription);
            return book;
        }
    }
}
