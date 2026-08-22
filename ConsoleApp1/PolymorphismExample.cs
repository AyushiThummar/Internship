using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PolymorphismExample
    {
        /*
         * virtual keyword to the method inside the base class.
         * override keyword for each derived class methods
         */
        public class Fruit
        {
            public virtual void Color()
            {
                Console.WriteLine("Every fruit has its own beautiful color.");
            }
        }
        public class Banana : Fruit
        {
            public override void Color()
            {
                Console.WriteLine("Banana is yellow.");
            }
        }
        public class Apple : Fruit
        {
            public override void Color()
            {
                Console.WriteLine("Apple is red.");
            }
        }
    }
}
