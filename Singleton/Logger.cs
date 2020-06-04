using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    //Make a class sealed for not using this class as super class since its violatesa
    public sealed class Logger
    {
        private static Logger _instance;
        //Constructor should be private for not instantiate
        private Logger()
        {

        }

        //This propery for accessing outsider
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
            
        }
    }
}
