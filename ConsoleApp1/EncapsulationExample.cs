using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EncapsulationExample
    {
        /*
         * The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
            declare fields/variables as private
            provide public get and set methods, through properties, to access and update the value of a private field
         */

        public class Student
        {
            private int marks;
            public int Marks
            {
                get { return marks; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        marks = value;
                    }
                }
            }
        }

        public class Student1
        {
            public string Name { get; set; } = string.Empty; // Initialize with a default value to avoid CS8618
        }

        public class User
        {
            private string username = "";
            public string Username
            {
                get
                {
                    return username;
                }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        username = value;
                    }
                }
            }
        }
    }
}
