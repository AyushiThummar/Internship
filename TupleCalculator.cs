using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TupleCalculator
    {
        public static (int Result, string Operation) Calculate()
        {
            Console.Write("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice of operation : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return (num1 + num2, "Addition");
                case 2:
                    return (num1 - num2, "Subtraction");
                case 3:
                    return (num1 * num2, "Multiplication");
                case 4:
                    if(num2 != 0)
                    {
                        return (num1 / num2, "Division");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not possible.");
                        return (0, "Division by zero");
                    }
                default:
                    return (0, "Invalid choice");
            }
        }
    }
}
