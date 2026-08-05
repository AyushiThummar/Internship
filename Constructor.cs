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
        public static int Exception(string? r)
        {
            if (string.IsNullOrWhiteSpace(r))
            {
                return 0;
            }
            int num = int.Parse(r);
            return num;
        }
    }
}
