using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance
    {
        public class Chocolate
        {
            public string Taste = "Sweet";
            public void Price()
            {
                Console.WriteLine("Price of chocolate is 100.");
            }
        }
        public class DarkChocolate : Chocolate
        {
            public string name = "Amul";
        }
    }
}
