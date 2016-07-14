using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Factory
{
    class SingltoneFactory
    {
        private static readonly Lazy<SingltoneFactory> lazyInstance = new Lazy<SingltoneFactory>(() => new SingltoneFactory(), true);
        public static SingltoneFactory Instance { get { return lazyInstance.Value; } }

        //Private Constructor 
        private SingltoneFactory() { }

        
    }
}
