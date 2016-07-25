using System;
using System.Collections.Generic;
using Model.Helper;
using NUnit.Framework;
using Model.Models;
using Moq;

namespace DelegatesAndEvents.UnitTest
{
    [TestFixture]
    public class UserFixture
    {
        private Mock<User> _userMock;
        private Book _book;
        private Claim _claim;
        private Author _author;
        
        [SetUp]
        public void Setup()
        {
            _author = new Author("firstName", "lastName", new List<Book>());
            _userMock = new Mock<User>("FirstName", "lastName");
            _book = new Book(new List<Author> {_author}, "bookName", new DateTime(2012,02,01), "description");
        }
        [Test]
        public void When_GiveTheBook_IsCalled()
        {
            //act
            _userMock.Object.TakeTheBook(_book);

            //Assert
            Assert.AreEqual(true, _userMock.Object.CurrentBooks.Contains(_book));
        }
    }
}
