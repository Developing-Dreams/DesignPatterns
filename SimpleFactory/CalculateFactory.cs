using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
 public    class CalculateFactory
    {
        //Alway program to interface
        /// <summary>
        ///  Object creation should be decided in factory class.
        ///  It should be easy when we defined new one we fix one place.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICalculate GetCalculate(string type)
        {
            ICalculate obj = null;
            if(type.ToLower().Equals("add"))
            {
                obj = new Addition(); 
            }
            else if(type.ToLower().Equals("subtract"))
            {
                obj = new Subtraction();

            }
            else if (type.ToLower().Equals("division"))
            {
                obj = new Division();
            }
            return obj;
        }
    }
}
