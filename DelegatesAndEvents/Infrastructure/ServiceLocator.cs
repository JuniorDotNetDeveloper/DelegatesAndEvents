using EventsRealisation.EventsWork;
using Model.Interfaces;
using Model.Models;
using Ninject;

namespace Infrastructure
{
    internal static class ServiceLocator
    {
        private static readonly IKernel _kernel = new StandardKernel();

        public static void RegisterAll()
        {
            _kernel.Bind<IPublisher<Book>>().To<Publisher<Book>>();
            _kernel.Bind<IPublisher<Author>>().To<Publisher<Author>>();
            _kernel.Bind<ICustomer>().To<User>();
        }


        /// <summary>
        /// Resolver method, which return first created in container object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>a <see cref="T"/></returns>
        public static T Resolver<T>() => _kernel.Get<T>();
    }
}
