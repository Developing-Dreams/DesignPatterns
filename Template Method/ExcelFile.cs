using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ExcelFile:DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read Data from excel file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Data from excel file");
        }
       
    }
}
