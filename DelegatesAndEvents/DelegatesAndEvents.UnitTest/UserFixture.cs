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
        private Mock<Book> _bookMock;
        private Mock<Claim> _claiMock;
        private Author _authorMock;
        
        [SetUp]
        public void Setup()
        {
            _authorMock = new Author("firstName", "lastName", new List<Book>());
            _userMock = new Mock<User>("FirstName", "lastName");
            _bookMock = new Mock<Book>(new List<Author> {_authorMock}, "bookName", new DateTime(2012,02,01), "description");
        }
        [Test]
        public void When_GiveTheBook_IsCalled()
        {
            //act
            //_userMock.TakeTheBook(_bookMock.Object);
            _userMock.Verify(x=>x.TakeTheBook(_bookMock.Object), Times.Once);
        }

        [Test]
        public void WhenTheBookIsBusy_GiveTheBook()
        {
            
        }
    }
}
