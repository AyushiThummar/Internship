using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exceptions
    {
        public static void Divide()
        {
            try
            {
                Console.WriteLine("Enter number 1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result : " + result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only number is allowed.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Finally block will always run.");
            }
        }

        // The throw statement allows you to create a custom error.
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough.");
            }
        }
    }
}
