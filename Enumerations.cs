using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Enumerations
    {
        // By default, the first item of an enum has the value 0. The second has the value 1, and so on.
        public enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // You can also assign your own enum values, and the next items will update their numbers accordingly.
        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June=10,
            July,
            August,
            September,
            October,
            November,
            December
        }

        // switch case
        public enum Level
        {
            Low,
            Medium,
            High
        }
        public void DisplayLevel()
        {
            Level l = Level.High;
            switch (l)
            {
                case Level.Low:
                    Console.WriteLine("Low Level.");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level.");
                    break;
                case Level.High:
                    Console.WriteLine("High Level.");
                    break;
            }
        }
    }
}
