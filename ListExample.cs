using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListExample
    {
        public void DisplayListInt()
        {
            var primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("List of integer : ");
            foreach (int i in primeNumbers)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        public void DisplayListString()
        {
            var food = new List<string>();
            food.Add("Pizza");
            food.Add("Pani Puri");
            food.Add("Pav Bhaji");
            food.Add("Potato Fries");
            //food.Add(null);

            Console.WriteLine("List of string : ");
            foreach(string str in food)
            {
                Console.Write(str + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Count :- " + food.Count);
        }

        public void DisplayCities()
        {
            // adding elements using collection initializer syntax
            var cities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };
            Console.WriteLine("List of cities : ");
            foreach(string c in cities)
            {
                Console.Write(c + ", ");
            }
            Console.WriteLine();
        }

        public void DisplayInsert()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };
            Console.WriteLine("Inserting value : ");
            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.
            foreach (var num in numbers)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }

        public void DisplayRemove()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 50 };
            numbers.Remove(40);
            numbers.RemoveAt(0);
            Console.WriteLine("Removing values : ");
            foreach (var num in numbers)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Check 30 is in list or not :- " + numbers.Contains(20));
        }
    }
}
