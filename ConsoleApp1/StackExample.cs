using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StackExample
    {
        public void DisplayStack()
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);

            Console.WriteLine("Stack : ");
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void DisplayStack2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Stack<int> arrInt = new Stack<int>(arr);
            Console.WriteLine("Stack with array : ");
            foreach(int i in arrInt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void PopStack()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
            while(myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
        }

        public void PeekStack()
        {
            Stack<int> ps = new Stack<int>();
            ps.Push(1);
            ps.Push(2);
            ps.Push(3);

            Console.WriteLine("Number of elements in Stack: {0}", ps.Count);// prints 3
            if (ps.Count > 0)
            {
                Console.WriteLine(ps.Peek()); // prints 3
                Console.WriteLine(ps.Peek()); // prints 3
            }
            Console.WriteLine("Number of elements in Stack: {0}", ps.Count);// prints 3
            Console.WriteLine(ps.Contains(2));
            Console.WriteLine(ps.Contains(5));
        }
    }
}
