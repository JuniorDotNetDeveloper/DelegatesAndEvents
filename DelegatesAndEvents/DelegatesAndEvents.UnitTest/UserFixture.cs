using System;
using System.Collections.Generic;
using System.Linq;
using Model.Helper;
using NUnit.Framework;
using Model.Models;
using Moq;

namespace DelegatesAndEvents.UnitTest
{
    [TestFixture]
    public class UserFixture
    {
        private User _user;
        private Book _book;
        //private Claim _claim;
        private Author _author;
        
        [SetUp]
        public void Setup()
        {
            _author = new Author("firstName", "lastName", new List<Book>());
            _user = new User("FirstName", "lastName");
            _book = new Book(new List<Author> {_author}, "bookName", new DateTime(2012,02,01), "description");
        }
        [Test]
        public void When_GiveTheBook_IsCalled()
        {
            //act
            _user.TakeTheBook(_book);

            //Assert
            Assert.AreEqual(true, _user.CurrentBooks.Contains(_book));
        }

        [TestCase("","")]
        [TestCase(" ", "")]
        public void CreateUserWithoutName(string fname, string lname)
        {
            //Assert
            Assert.Throws<ArgumentNullException>(() => new User(fname, lname));
        }

        //[Test]
        //public void TakeTheBook_AddNewBookInCurrentBooks()
        //{
        //   //Act
        //    _user.TakeTheBook(_book);

        //    //Assert
        //    Assert.Contains(_book, _user.CurrentBooks.ToList());
        //}
    }
}
