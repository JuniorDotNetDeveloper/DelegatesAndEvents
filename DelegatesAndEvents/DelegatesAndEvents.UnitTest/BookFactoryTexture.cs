using System;
using System.Collections.Generic;
using Factory.Factories;
using Model.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;

namespace DelegatesAndEvents.UnitTest
{
    [TestFixture]
    class BookFactoryTexture
    {
        private Author _author;
        private BookFactory _bookFactory;
        [SetUp]
        public void Initialization()
        {
            _author = new Author("FirstName", "LastName");
            _bookFactory = new BookFactory();
        }

        [TestCase(null, "This book is without Description")]
        [TestCase("", "This book is without Description")]
        [TestCase(" ", "This book is without Description")]
        [TestCase("With Description", "With Description")]
        public void CreateBookWithDescription(string InValue, string outerValue)
        {
            //act
            var book = _bookFactory.CreateNewBook_WithSingleAuthor(_author, "Bookname", DateTime.Now, InValue);

            //Assert
            Assert.AreEqual(book.Description, outerValue);
        }
        [Test]
        public void CreateBook_AuthorIsNull()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(() => _bookFactory.CreateNewBook_WithSingleAuthor(null, "Bookname", DateTime.Now));
        }

        [Test]
        public void CreateBook_TestAuthor()
        {
            //Arange
            List<Author> list = new List<Author> {_author};
            Book bookBook = new Book(list, "bookName", new DateTime(2001, 12, 12), "description");

            //Act
            var book = _bookFactory.CreateNewBook_WithSingleAuthor(_author, "bookName", new DateTime(2001, 12, 12), "description");
            
            //Assert
            Assert.AreEqual(bookBook.Authors, book.Authors); // error
        }
    }
}
