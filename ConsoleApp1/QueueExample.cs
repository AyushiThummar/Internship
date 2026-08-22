using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QueueExample
    {
        public void DisplayQueue()
        {
            Queue<int> qe = new Queue<int>();
            qe.Enqueue(1);
            qe.Enqueue(2);
            qe.Enqueue(3);
            qe.Enqueue(4);

            Console.WriteLine("Queue : ");
            foreach(int i in qe)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
            Console.WriteLine(qe.Contains(2));
            Console.WriteLine(qe.Contains(10));
        }
    }
}
