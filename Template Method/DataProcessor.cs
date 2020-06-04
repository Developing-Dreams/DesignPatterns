using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// sub classes decide how to implement steps in algorithm
    /// Avoid repeatation
    /// Put common method in abstract class and derived class 
    /// </summary>
    public abstract class DataProcessor
    {
        public void ReadProceeAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }
        public abstract void ReadData();
        public abstract void ProcessData();
        private void SaveData()
        {
            Console.WriteLine("Save data into DB");
        }
    }
}
