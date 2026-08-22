using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RefOut
    {
        public static void RefExample(ref int num)
        {
            num = 20;
        }
        public static void OutExample(out int num)
        {
            num = 30;
        }
    }
}
