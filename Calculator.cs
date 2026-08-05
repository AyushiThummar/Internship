using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public static int Exception(string? r)
        {
            if (string.IsNullOrWhiteSpace(r))
            {
                return 0;
            }
            int num = int.Parse(r);
            return num;
        }

        //public Calculator() {
        //    Console.Write("Enter value of number 1 : ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter value of number 2 : ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("1. Addition");
        //    Console.WriteLine("2. Subtraction");
        //    Console.WriteLine("3. Multiplication");
        //    Console.WriteLine("4. Division");
        //    Console.WriteLine("Enter your choice of operation : ");
        //    int choice = Convert.ToInt32(Console.ReadLine());

        //    /*
        //    if(choice < 1 || choice > 4)
        //    {
        //        Console.WriteLine("Invalid choice. Please select a valid operation.");
        //        return;
        //    }
        //    else if (choice == 1)
        //    {
        //        Console.WriteLine($"Addition of 2 numbers is : {num1 + num2}");
        //    }
        //    else if(choice == 2)
        //    {
        //        Console.WriteLine($"Subtraction of 2 numbers is : {num1 - num2}");
        //    }
        //    else if (choice == 3)
        //    {
        //        Console.WriteLine($"Multiplication of 2 numbers is : {num1 * num2}");
        //    }
        //    else if (choice == 4)
        //    {
        //        if(num2 != 0)
        //        {
        //            Console.WriteLine($"Division of 2 numbers is : {num1 / num2}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Division by zero is not allowed.");
        //        }
        //    }
        //    */

        //    switch (choice)
        //    {
        //        case 1:
        //            Console.WriteLine($"Addition of 2 numbers is : {num1+num2}");
        //            break;
        //        case 2:
        //            Console.WriteLine($"Subtraction of 2 numbers is : {num1-num2}");
        //            break;
        //        case 3:
        //            Console.WriteLine($"Multiplication of 2 numbers is : {num1 * num2}");
        //            break;
        //        case 4:
        //            if(num2 != 0)
        //            {
        //                Console.WriteLine("$Division of 2 numbers is : {num1 / num2}");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Division by zero is not allowed.");
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice.");
        //            break;
        //    }   
        //}


        public Calculator()
        {
            Console.Write("Enter value of number 1 : ");
            int num1 = Calculator.Exception(Console.ReadLine());
            Console.Write("Enter value of number 2 : ");
            int num2 = Calculator.Exception(Console.ReadLine());

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice of operation : ");
            int choice = Calculator.Exception(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition of 2 numbers is : {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction of 2 numbers is : {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of 2 numbers is : {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("$Division of 2 numbers is : {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
