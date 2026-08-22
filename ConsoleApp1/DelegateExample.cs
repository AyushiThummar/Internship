using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DelegateExample
    {
        /* 
         * Delegate is the reference type data type that defines the signature.
         * Delegate type variable can refer to any method with the same signature as the delegate.
         * Syntax: [access modifier] delegate [return type] [delegate name]([parameters])
         * A target method's signature must match with delegate signature.
         * Delegates can be invoke like a normal function or Invoke() method.
         * Multiple methods can be assigned to the delegate using "+" or "+=" operator and removed using "-" or "-=" operator. It is called multicast delegate.
         * If a multicast delegate returns a value then it returns the value from the last assigned target method.
         * Delegate is used to declare an event and anonymous methods in C#.
         */

        public delegate void MyDelegate(string msg);
        public class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }
        public class ClassB
        {
            public static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
        }

        // Int type
        public delegate int MyDelegateInt();
        public class ClassAI
        {
            public static int MethodA()
            {
                return 100;
            }
        }

        public class ClassBI
        {
            public static int MethodB()
            {
                return 200;
            }
        }
    }
}
