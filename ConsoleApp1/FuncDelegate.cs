using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FuncDelegate
    {
        /*
         * Func is built-in delegate type.
         * Func delegate type must return a value.
         * Func delegate type can have zero to 16 input parameters.
         * Func delegate does not allow ref and out parameters.
         * Func delegate type can be used with an anonymous method or lambda expression.
         */

        static Func<int, int, int> operation = Sum;
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static Func<int> getRandomNumber = () => new Random().Next(1, 100);
        public static Func<int, int, int> Add = (x, y) => x + y;

        //  An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value.
        //  In other words, an Action delegate can be used with a method that has a void return type.

        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        /*
         * Action delegate is same as func delegate except that it does not return anything. Return type must be void.
         * Action delegate can have 0 to 16 input parameters.
         * Action delegate can be used with anonymous methods or lambda expressions.
         */

        /*
         * Predicate is the delegate like Func and Action delegates. 
         * It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria. 
         * A predicate delegate methods must take one input parameter and return a boolean - true or false.
         */
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
