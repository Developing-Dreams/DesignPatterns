using DesignPatterns.Factory;
using DesignPatterns.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Startup
    {
        static void Main(string[] args)
        {
            //Singleton
            //////Logger logger = Logger.Instance;
            //////Logger logger1 = Logger.Instance;
            //////Console.WriteLine(logger.GetHashCode());
            //////Console.WriteLine(logger1.GetHashCode());
            //////ThreadSafetyLogger tlogger= ThreadSafetyLogger.Instance;
            //////Console.WriteLine(tlogger.GetHashCode());
            //////EagerLogger eagerLogger = EagerLogger.Instance;
            //////Console.WriteLine(eagerLogger.GetHashCode());
            //////LazyLogger lazyLogger = LazyLogger.Instance;
            //////Console.WriteLine(lazyLogger.GetHashCode());
            ///

            ///Factory

            //////Console.WriteLine("Enter 1st number");
            //////double num1;
            //////var res = Double.TryParse(Console.ReadLine(),out num1);
            //////Console.WriteLine("Enter 2nd number");
            //////double num2;
            //////var res2 = Double.TryParse(Console.ReadLine(), out num2);
            //////Console.WriteLine("Enter Add ,Subtract,Division");
            //////CalculateFactory calculateFactory = new CalculateFactory();
            //////ICalculate calculate=calculateFactory.GetCalculate(Console.ReadLine());

            //////calculate.Calculate(num1, num2);
            ///

            ///Template method pattern
            ///
            DataProcessor excel = new ExcelFile();
            excel.ReadProceeAndSave();
            DataProcessor text = new TextFile();
            text.ReadProceeAndSave();
            Console.ReadLine();
        }
    }
}
