using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Subtraction : ICalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("Subtraction of Num1-Num2 is {0}", num1 - num2);
        }
    }
}
