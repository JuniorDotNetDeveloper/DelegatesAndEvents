using System;
using System.Collections.Generic;
using Model.Helper;
using NUnit.Framework;
using Model.Models;

namespace DelegatesAndEvents.UnitTest
{
    
    [TestFixture]
    public class ClaimFixture
    {
        private Book _book;
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _book = new Book(new List<Author> { new Author(firstName: "fName", lastName: "lName") }, "bookName", DateTime.Now, String.Empty);
            _user = new User("fName", "lName");
        }

        [TestCase(false, BookStatus.Busy)]
        [TestCase(true, BookStatus.Free)]
        public void GiveTheBookBookConditionals(bool value, BookStatus bStatus)
        {
            // Arange
            _book.Status = bStatus;

            // Act
            var claim = new Claim(_user, _book).GiveTheBook();
            
            //Assert
            Assert.AreEqual(value, claim);
        }

        [Test]
        public void GiveTheBookUserHaveLessThan3()
        {
            //Arrange
            _user.CurrentBooks.Add(_book);
            _user.CurrentBooks.Add(_book);
            

            //Act
            var claim = new Claim(_user, _book).GiveTheBook();

            //Arrange
            Assert.AreEqual(true, claim);
        }

        [Test]
        public void GiveTheBookUserHaveMoreThan3Books()
        {
            //Arrange
            _user.CurrentBooks.Add(_book);
            _user.CurrentBooks.Add(_book);
            _user.CurrentBooks.Add(_book);
            _user.CurrentBooks.Add(_book);

            //Act
            var claim = new Claim(_user, _book).GiveTheBook();

            //Arrange
            Assert.AreEqual(false, claim);
        }

       
    }
}
