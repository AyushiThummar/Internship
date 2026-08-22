using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Constructor
    {
        public Constructor()
        {
        }
        public Constructor(int minValue, int maxValue, int roundValue)
        {
            min = minValue;
            max = maxValue;
            round = roundValue;
        }
        public int min { get; set; }
        public int max { get; set; }
        public int round { get; set; }

        public static int Exception(string? choice)
        {
            if (string.IsNullOrWhiteSpace(choice))
            {
                Environment.Exit(0);
            }
            //return int.Parse(choice);
            int number;
            if (int.TryParse(choice, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Environment.Exit(0);
                return 0; // This line will never be reached, but is required to satisfy the compiler.
            }
        }
        

        //public static string Exception(string? r)
        //{
        //    if (string.IsNullOrWhiteSpace(r))
        //    {
        //        return "";
        //    }
        //    return r;
        //}
    }
}
