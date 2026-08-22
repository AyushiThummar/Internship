//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class2
//    {
//        //class Car
//        //{
//        //    public string model;
//        //    public string color;
//        //    public int year;
//        //    public Car(string modelName, string colorName, int Year)
//        //    {
//        //        model = modelName;
//        //        color = colorName;
//        //        year = Year;
//        //    }
//        //}


//        //class RoundValue
//        //{
//        //    public int min;
//        //    public int max;
//        //    public int num;

//        //    public RoundValue(int minValue, int maxValue, int numValue)
//        //    {
//        //        min = minValue;
//        //        max = maxValue;
//        //        num = numValue;

//        //        if (num < min || num > max)
//        //        {
//        //            Console.WriteLine("Number is not in a range.");
//        //        }
//        //        else
//        //        {
//        //            if (num >= 1 && num <= 15)
//        //            {
//        //                Console.WriteLine("Rounded value :-  15");
//        //            }
//        //            else if (num >= 16 && num <= 30)
//        //            {
//        //                Console.WriteLine("Rounded value :- 30");
//        //            }
//        //            else if (num >= 31 && num <= 45)
//        //            {
//        //                Console.WriteLine("Rounded value :- 45");
//        //            }
//        //            else if (num >= 46 && num <= 60)
//        //            {
//        //                Console.WriteLine("Rounded value :- 60");
//        //            }
//        //            else
//        //            {
//        //                Console.WriteLine("Rounded value :- 90");
//        //            }
//        //        }
//        //    }
//        //}


//        static void Main(string[] args)
//        {
//            //// Full pyramid pattern
//            //int n = 5;
//            //for(int i=1; i<=n; i++)
//            //{
//            //    for(int s=0; s<=n-i; s++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for(int j=1; j<=2*i-1; j++){
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}



//            //// Inverted full pyramid pattern
//            //int n = 5;
//            //for(int i=n; i>=1; i--){
//            //    for(int s=0; s<=n-i; s++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for(int j=1; j<=2*i-1; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}



//            //// Half-diamond star
//            //int n = 3;
//            //for(int i=1; i<=n; i++)
//            //{
//            //    for(int j=1; j<=i; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //for(int i=n-1; i>=1; i--)
//            //{
//            //    for(int j=1; j<=i; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}


//            //// Diamond star
//            //int n = 5;
//            //for(int i=1; i<=n; i++)
//            //{
//            //    for(int s=0; s<=n-i; s++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for(int j=1; j<=2*i-1; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //for(int i=n; i>=1; i--)
//            //{
//            //    for(int s=0; s<=n-i; s++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for(int j=1; j<=2*i-1; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}



//            //// alphabet "A" using stars
//            //int n = 5;
//            //for(int i=0; i<n; i++)
//            //{
//            //    for(int j=0; j<=n/2; j++)
//            //    {
//            //        if (i == 0 || j == 0 || i == n/2 || j == n/2)
//            //        {
//            //            if(i==0 && (j==0 || j == n / 2))
//            //            {
//            //                Console.Write(" ");
//            //            }
//            //            else
//            //            {
//            //                Console.Write("*");
//            //            }
//            //        }
//            //        else
//            //        {
//            //            Console.Write(" ");
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}



//            ///*
//            // Min value   | Max value  | Rounded value
//            //    1        | 15         | 15
//            //    16       | 30         | 30
//            //    31       | 45         | 45
//            //    46       | 60         | 60
//            //    61       | 99999      | 90
//            // */
//            //Console.WriteLine("Enter the minimum value : ");
//            //int min = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("Enter the maximum value : ");
//            //int max = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("Enter number between range : ");
//            //int num = Convert.ToInt32(Console.ReadLine());

//            //if (num < min || num > max)
//            //{
//            //    Console.WriteLine("Number is not in a range.");
//            //}
//            //else
//            //{
//            //    if (num >= 1 && num <= 15)
//            //    {
//            //        Console.WriteLine("Rounded value :-  15");
//            //    }
//            //    else if (num >= 16 && num <= 30)
//            //    {
//            //        Console.WriteLine("Rounded value :- 30");
//            //    }
//            //    else if (num >= 31 && num <= 45)
//            //    {
//            //        Console.WriteLine("Rounded value :- 45");
//            //    }
//            //    else if (num >= 46 && num <= 60)
//            //    {
//            //        Console.WriteLine("Rounded value :- 60");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Rounded value :- 90");
//            //    }
//            //}



//            //Car myCar = new Car("Eon", "White", 1999);
//            //Console.WriteLine($"Car Model :- {myCar.model} , Car Color :- {myCar.color}, Car year :- {myCar.year}");



//            //RoundValue v1 = new RoundValue(1, 15, 12);
//            //RoundValue v2 = new RoundValue(16, 30, 25);
//            //RoundValue v3 = new RoundValue(31, 45, 2);
//            //RoundValue v4 = new RoundValue(31, 45, 33);
//            //RoundValue v5 = new RoundValue(46, 60, 52);
//            //RoundValue v6 = new RoundValue(61, 99999, 89);
//        }
//    }
//}