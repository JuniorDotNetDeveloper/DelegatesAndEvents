using Ninject;

namespace Infrastructure
{
    internal static class ServiceLocator
    {
        private static readonly IKernel _kernel = new StandardKernel();

        public static void RegisterAll()
        {
//            _kernel.Bind<>()
        }


        /// <summary>
        /// Resolver method, which return first created in container object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>a <see cref="T"/></returns>
        public static T Resolver<T>() => _kernel.Get<T>();
    }
}
