using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbstractionExample
    {
        /* Data abstraction is the process of hiding certain details and showing only essential information to the user.
        Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
        Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
        */

        public abstract class Clothes
        {
            public abstract void Fabric();
            public void Price()
            {
                Console.WriteLine("Price depends on quality of fabric.");
            }
        }
        public class Shirt : Clothes
        {
            public override void Fabric()
            {
                Console.WriteLine("This shirt having cotton fabric.");
            }
        }
        public class Jeans : Clothes
        {
            public override void Fabric()
            {
                Console.WriteLine("This jeans having denim fabric.");
            }
        }

    }
}
