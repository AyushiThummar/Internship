using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DisplayCalculator
    {
        public static int Exception(string? input, int defaultValue)
        {
            input = string.IsNullOrWhiteSpace(input)? defaultValue.ToString(): input;
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Environment.Exit(0);
                return 0;
            }
        }
        public static int Calculate(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if(num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divide by zero is not allowed.");
                        return 0;
                    }
                default:
                    Console.WriteLine("Invalid choice.");
                    return 0;
            }
        }
        public static void Display(int num1, int num2, string op)
        {
            int result = Calculate(num1, num2, op);
            Console.WriteLine($"Result of Number 1 {num1} & Number 2 {num2} with Operator {op} is {result}.");
        }
    }
}
