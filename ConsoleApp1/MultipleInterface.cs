using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultipleInterface
    {
        interface IFirst
        {
            void FirstMethod();
        }
        interface ISecond
        {
            void SecondMethod();
        }
        public class ImplementInterface : IFirst, ISecond
        {
            public void FirstMethod()
            {
                Console.WriteLine("This line is for interface IFirst.");
            }
            public void SecondMethod()
            {
                Console.WriteLine("This line is for interface ISecond.");
            }
        }
    }
}
