using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boolean
    {
        //// Boolean data type which will only accept true or false as input from the user and will print the output accordingly.
        //public Boolean()
        //{
        //    Console.WriteLine("Did you take the chocolate? (true/false)");
        //    bool tookChocolate = bool.Parse(Console.ReadLine());
        //    if(tookChocolate)
        //    {
        //        Console.WriteLine("You took the chocolate.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You did not take the chocolate.");
        //    }
        //}

        // Boolean data type with:- True,False,true,false,Yes,No,yes,no,1,0 as input from the user and will print the output accordingly.
        public Boolean()
        {
            Console.WriteLine("Have you completed your homework? ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter true, false, yes, no, 1, or 0.");
                return;
            }

            bool status;
            if (input == "True" || input == "true" || input == "T" || input == "t" || input == "Yes" || input == "yes" || input == "Y" || input == "y" || input == "1")
            {
                status = true;
                Console.WriteLine("I have completed my homework.  " + status);
            }
            else if (input == "False" || input == "false" || input == "F" || input == "f" || input == "No" || input == "no" || input == "N" || input == "n" || input == "0")
            {
                status = false;
                Console.WriteLine("I have not completed my homework.  " + status);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter true, false, yes, no, 1, or 0.");
            }
        }
    }
}
