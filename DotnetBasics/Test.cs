using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DotnetBasics
{
    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("Class  A - MA");
        }
    }
    class B:A
    {
        public override void MethodA()
        {
            Console.WriteLine("Class  B - MA");
        }
        public void MethodB()
        {
            Console.WriteLine("Class  B - MB");
        }
    }
    class Test
    {
        //static void Main()
        //{
        //    A a = new A();
        //    a.MethodA();
        //    B b = new B();
        //    b.MethodA();
        //    b.MethodB();
        //    A ab = new B();
        //    ab.MethodA();
        //    //  ((B)ab).MethodB();
        //    (ab as B).MethodB();
        //    Console.ReadLine();
        //}
    }
}
