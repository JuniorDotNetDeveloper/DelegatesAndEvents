using EventsRealisation.EventsWork;
using Model.Models;
using Moq;
using NUnit.Framework;
using Publisher.Abstraction.Interfaces;

namespace DelegatesAndEvents.UnitTest
{
    [TestFixture]
    class SubscriberTexture
    {
        [Test]
        public void CreateEvent()
        {
            Mock<IPublisher<Author>> storePubMock = new Mock<IPublisher<Author>>();
            Author authoMock = new Author("firstName", "lastName");
            Subscribe<Author> authorSubscriber = new Subscribe<Author>(storePubMock.Object);

            //  Subscribe<Store> subStore = new Subscribe<Store>(storePubMock.Object);
           // Subscribe<Author> author = new Author("sadf", "sdf");
            Store store = new Store();


            authorSubscriber.Publisher.DataPublisher += store.ExtendStoreLists;
            storePubMock.Object.PublishData(authoMock);
           
            storePubMock.Verify(x=>x.PublishData(authoMock), Times.Once());

        }

        private void Publisher_DataPublisher(object sender, Publisher.Abstraction.EventArguments<Store> e)
        {
            throw new System.NotImplementedException();
        }
    }
}
