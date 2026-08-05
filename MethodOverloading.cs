using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodOverloading
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
