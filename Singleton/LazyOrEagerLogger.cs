using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public  class EagerLogger
    {
        //Eager loading -- Initialise object before it requires to use.
        //CLR automatically handles thread safety while creation of object
        private static readonly EagerLogger _instance = new EagerLogger();
        private EagerLogger()
        {

        }
        public static EagerLogger Instance
        {
            get
            {
                return _instance;
            }
        }
    }
    public sealed class LazyLogger
    {
        
        private LazyLogger()
        {

        }
        //Eager loading -- Initialise object when it requires to use.
        //CLR automatically handles thread safety while using lazy
        private static readonly Lazy<LazyLogger> _instance = new Lazy<LazyLogger>(()=>new LazyLogger());
        public static LazyLogger Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
