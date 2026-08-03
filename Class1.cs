using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
         static void Main(string[] args)
         {
            //int n = 5;
            //for(int i=1; i<=n; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //int n = 1;
            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write(n);
            //        n++;
            //    }
            //    Console.WriteLine();
            //}

            int n = 15;
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=n-j+i; j++)
                {
                    Console.Write(n);
                    if (n == 1)
                    {
                        break;
                    }
                    n--;
                }
                Console.WriteLine();
            }
         }
    }
}
