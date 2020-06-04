using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    /// <summary>
    /// Order of the below method should be read ,process and save.User might call different order
    /// Avoid repeatation
    /// </summary>
    public class TextFile : DataProcessor
    {

        public override void ReadData()
        {
            Console.WriteLine("Read Data from Text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process Data from Text file");
        }
    }
}
