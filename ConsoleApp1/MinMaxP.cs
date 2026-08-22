using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MinMaxP
    {
        /*
         min          max      %
        0           400000     0
        400001      800000     5
        800001      1200000    10
        1200001     1600000    15
        1600001     2000000    20
        2000001     2400000    25
        2400001     3000000    30
        cess => 4%
         */
        
        public static void CalculateSalary(double salary)
        {
            int[] min_salary = { 0, 400001, 800001, 1200001, 1600001, 2000001, 2400001 };
            int[] max_salary = { 400000, 800000, 1200000, 1600000, 2000000, 2400000, int.MaxValue };
            int[] percentage = { 0, 5, 10, 15, 20, 25, 30 };

            double tax = 0;
            
            for (int i = 0; i < min_salary.Length; i++)
            {
                if(salary > min_salary[i])
                {
                    //tax = salary * percentage[i] / 100;
                    // Salary should count previous tax rate also.
                    // If user enters 900000 then count 5% tax also.
                    double temp = Math.Min(salary, max_salary[i]) - min_salary[i] + 1;
                    tax += (temp * percentage[i] / 100);
                    //break;
                }
            }
            double cess = tax * 4 / 100;
            double total_tax = tax + cess;
            double income = salary - total_tax;

            Console.WriteLine("Tax : " + tax);
            Console.WriteLine("Cess Tax : " + cess);
            Console.WriteLine("Total Tax : " + total_tax);
            Console.WriteLine("Income : " + income);
        }
    }
}
