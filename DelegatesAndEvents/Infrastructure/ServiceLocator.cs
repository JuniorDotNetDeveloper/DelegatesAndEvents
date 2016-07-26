using Model.Models;
using Ninject;
using Publisher.Abstraction.Interfaces;
using EventsRealisation.EventsWork;
using IRepository.Interfaces;
using Repository.Implementation;

namespace Infrastructure
{
    internal static class ServiceLocator
    {
        private static readonly IKernel _kernel = new StandardKernel();

        public static void RegisterAll()
        {
            _kernel.Bind<IPublisher<Book>>().To<Publisher<Book>>();
            _kernel.Bind<IPublisher<Author>>().To<Publisher<Author>>();
            _kernel.Bind<IRepository<Book>>().To<BookRepository>();
            _kernel.Bind<IRepository<Author>>().To<AuthorRepository>();
        }


        
        public static T Resolver<T>() => _kernel.Get<T>();
    }
}
