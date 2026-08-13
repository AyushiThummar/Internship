using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DictionaryExample
    {
        /*Dictionary<TKey, TValue> stores key-value pairs.
         * Implements IDictionary<TKey, TValue> interface.
         * Keys must be unique and cannot be null.
         * Values can be null or duplicate.
         */
        public void DisplayDictionary()
        {
            IDictionary<int,string> numName = new Dictionary<int,string>();
            numName.Add(1, "abc");
            numName.Add(2, "xyz");
            numName.Add(3, "pqr");
            numName.Add(4, "abc");  // value can be duplicate.
            Console.WriteLine("Dictionary example : ");
            foreach(KeyValuePair<int,string> kvp in numName)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();
        }

        public void DisplayCities()
        {
            // dictionary using collection-initializer syntax.
            var cities = new Dictionary<string, string>
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            Console.WriteLine("Dictionary of cities : ");
            foreach(var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Print value of India & UK : ");
            Console.WriteLine(cities["India"]);
            Console.WriteLine(cities["UK"]);

            // Use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            // Use TryGetValue() to get a value of unknown key
            string? result;
            if(cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            // use ElementAt() to retrieve key-value pair using index
            Console.WriteLine("retrieving elements using ElementAt() : ");
            for(int i=0; i<cities.Count; i++)
            {
                Console.WriteLine("Key:{0}, Value: {1}", 
                    cities.ElementAt(i).Key, 
                    cities.ElementAt(i).Value);
            }
        }

        public void UpdateDictionary()
        {
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
            //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
            Console.WriteLine("Updated dictionary : ");
            foreach(var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();
        }
        
        public void RemoveDictionary()
        {
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            Console.WriteLine("Remove Dictionary : ");
            cities.Remove("UK");
            foreach(var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // check key before removing
            if (cities.ContainsKey("France"))
            {
                cities.Remove("France");
            }

            // Remove all elements
            //cities.Clear();
            //foreach (var kvp in cities)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            //}
        }

    }
}
