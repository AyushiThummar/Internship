using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        public static void Main(string[] args)
        {
            /*
                        // Min value   | Max value  | Rounded value
                        //    1        | 15         | 15
                        //    16       | 30         | 30
                        //    31       | 45         | 45
                        //    46       | 60         | 60
                        //    61       | 99999      | 90
                        // 
            */

            /*
            Console.Write("Enter value for loop : ");
            int loop = Class3.Exception(Console.ReadLine());
            int[] min = new int[loop];
            int[] max = new int[loop];
            int[] round = new int[loop];

            for (int i = 0; i < loop; i++)
            {
                Console.Write("Enter minimum value : ");
                min[i] = Class3.Exception(Console.ReadLine());
                Console.Write("Enter maximum value : ");
                max[i] = Class3.Exception(Console.ReadLine());
                Console.Write("Enter rounded value : ");
                round[i] = Class3.Exception(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("Enter number to check :- ");
            int num = Class3.Exception(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                if (num >= min[i] && num <= max[i])
                {
                    Console.WriteLine("Rounded value :- " + round[i]);
                }
            }
            */

            Console.Write("Enter value for loop : ");
            int loop = Constructor.Exception(Console.ReadLine());
            int min, max, round, i;
            Constructor[] arr = new Constructor[loop];

            for (i = 0; i < loop; i++)
            {
                Console.Write("Enter minimum value : ");
                min = Constructor.Exception(Console.ReadLine());
                Console.Write("Enter maximum value : ");
                max = Constructor.Exception(Console.ReadLine());
                Console.Write("Enter rounded value : ");
                round = Constructor.Exception(Console.ReadLine());
                Console.WriteLine();
                arr[i] = new Constructor(min, max, round);
            }

            Console.Write("Enter number to check :- ");
            int num = Constructor.Exception(Console.ReadLine());
            Class3 obj = new Class3();
            for (i = 0; i < loop; i++)
            {
                var j = arr[i];
                if (num >= j.min && num <= j.max)
                {
                    Console.WriteLine("Rounded value :- " + j.round);
                }
            }

        }
    }
}
