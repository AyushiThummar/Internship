using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayListExample
    {
        public ArrayList arlist = new ArrayList()
        {
            1,"Bill",300,4.5f
        };
        public void Display()
        {

            /* Console.WriteLine("ArrayList : " + arlist);
             * It prints the object's type name because ArrayList doesn't automatically format its contents.
             */
            Console.WriteLine("ArrayList :");
            foreach (var item in arlist)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            int fe = (int) arlist[0]!;
            Console.WriteLine(fe);
            string se = (string)arlist[1]!;
            Console.WriteLine(se);
            arlist[0] = "Stove";
            arlist[1] = 100;
            Console.WriteLine("Updated ArrayList :");
            Console.WriteLine();
            foreach (var item in arlist)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("Check list contains Stove or not : " + arlist.Contains("Stove"));
            Console.WriteLine("Check list contains 5000 or not : " + arlist.Contains(5000));
        }

        public ArrayList arlist2 = new ArrayList()
        {
            1, "Bill", 300, 4.5f
        };
        public void DisplayInsert()
        {
            arlist2.Insert(1, "Second Item");
            Console.WriteLine("arlist2 after insertion : ");
            foreach(var item in arlist2)
            {
                Console.WriteLine(item + ",");
            }
        }
        public void DisplayInsertRange()
        {
            arlist.InsertRange(2, arlist2);

            foreach (var item in arlist)
                Console.Write(item + ", ");
        }

        ArrayList arlist3 = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };
        public void DisplayRemove()
        {
            arlist3.Remove(null); //Removes first occurrence of null
            arlist3.RemoveAt(4); //Removes element at index 4
            arlist3.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            foreach(var item in arlist3)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
