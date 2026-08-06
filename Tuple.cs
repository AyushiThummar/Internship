using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tuple
    {
        // New tuple syntax introduced in C# 7.0
        public static (int, string, double) Student()
        {
            int rollno = 30;
            string name = "Ayushi";
            double cgpa = 8.75;
            return (rollno, name, cgpa);
        }

        // Old tuple syntax
        public static Tuple<int,string,double> Student1()
        {
            return new Tuple<int, string, double>(30, "Ayushi", 8.75);
        }

        public static Tuple<string,int> Chocolate()
        {
            return new Tuple<string, int>("Dairy Milk", 100);
        }
    }
}
