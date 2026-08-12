using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class JaggedArray
    {
        // Jagged Array means array of array.
        // Jagged arrays store arrays instead of literal values.

        public int[][] jArray = new int[2][]
        {
            new int[3]{1,2,3},
            new int[4]{4,5,6,7 }
        };
        public void Display()
        {
            Console.WriteLine("Accessing array elements through index.");
            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][1]);
            Console.WriteLine(jArray[0][2]);
            Console.WriteLine(jArray[1][0]);
            Console.WriteLine(jArray[1][1]);
            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][3]);
        }

        public int[][] jArray2 = new int[2][]
        {
            new int[3]{3,2,1},
            new int[4]{7,6,5,4 }
        };
        public void Display2()
        {
            Console.WriteLine("Accessing array through for loop.");
            for(int i=0; i<jArray2.Length; i++)
            {
                for(int j=0; j<jArray2[i].Length; j++)
                {
                    Console.WriteLine(jArray2[i][j]);
                }
            }
        }
    }
}
