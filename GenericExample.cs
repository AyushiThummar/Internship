using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericExample
    {
        /*
         * C# allows you to define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, 
         events, delegates, and operators using the type parameter and without the specific data type. 
        * A type parameter is a placeholder for a particular type specified when creating an instance of the generic type.
        * A generic type is declared by specifying a type parameter in an angle brackets after a type name, 
        e.g. TypeName<T> where T is a type parameter.
        */

        public class DataStore<T>
        {
            private T[] _data = new T[10];
            public void AddOrUpdate(int index, T item)
            {
                if(index >= 0 && index < 10)
                {
                    _data[index] = item;
                }
            }
            public T GetData(int index)
            {
                if(index >= 0 && index < 10)
                {
                    return _data[index];
                }
                else
                {
                    return default(T)!;
                }
            }
        }

        // A non-generic class can include generic methods by specifying a type parameter in angle brackets with the method name.
        public class Printer
        {
            public void Print<T>(T data)
            {
                Console.WriteLine(data);
            }
        }

        /*
         * Advantages of Generics
            1. Generics increase the reusability of the code. You don't need to write code to handle different data types.
            2. Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.
            3. Generic has a performance advantage because it removes the possibilities of boxing and unboxing.
         */
    }
}
