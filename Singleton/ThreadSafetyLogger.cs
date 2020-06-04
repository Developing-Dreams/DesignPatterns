using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class ThreadSafetyLogger
    {
        private static ThreadSafetyLogger _instance;
        private static readonly object _padlock = new object();
        private ThreadSafetyLogger()
        {

        }
        public static ThreadSafetyLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)//Thread safety and avoid concurrent call
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafetyLogger(); 
                        }

                    }
                }
                return _instance;
            }
        }
    }

}

