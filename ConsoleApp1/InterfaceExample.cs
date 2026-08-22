using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InterfaceExample
    {
        interface University
        {
            void Event();
        }
        public class College : University
        {
            public void Event()
            {
                Console.WriteLine("Techno Planet event is going to happen soon.");
            }
        }
        public class Admin : University
        {
            public void Event()
            {
                Console.WriteLine("Admin will manage all the registration process.");
            }
        }
    }
}
