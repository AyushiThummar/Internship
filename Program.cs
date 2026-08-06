//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp1;
using System;

public class Program
{
    /*static(int, string, double) Student()
    {
        int rollno = 101;
        string name = "John Doe";
        double marks = 85.5;
        return (rollno, name, marks);
    }*/
    public static void Main(string[] args)
    {
        //// Calculator.cs
        //Calculator calculator = new Calculator();

        //// MethodOverloading.cs
        //Console.WriteLine("Addition of int a,b : " + MethodOverloading.Addition(10, 20));
        //Console.WriteLine("Addition of int a,b,c : " + MethodOverloading.Addition(10, 20, 30));
        //Console.WriteLine("Addition of double a,b : " + MethodOverloading.Addition(10.5, 20.5));

        //// Inheritance.cs
        //Inheritance.Chocolate c1 = new Inheritance.Chocolate();
        //Console.WriteLine("Taste of Chocolate: " + c1.Taste);
        //c1.Price();
        //Inheritance.DarkChocolate dc1 = new Inheritance.DarkChocolate();
        //Console.WriteLine("Name of Dark Chocolate: " + dc1.name);

        //// Tuple.cs
        //var s1 = ConsoleApp1.Tuple.Student();
        //Console.WriteLine($"Roll No: {s1.Item1}, Name: {s1.Item2}, CGPA: {s1.Item3}");
        //var s2 = ConsoleApp1.Tuple.Student1();
        //Console.WriteLine($"Roll No: {s2.Item1}, Name: {s2.Item2}, CGPA: {s2.Item3}");
        //var c1 = ConsoleApp1.Tuple.Chocolate();
        //Console.WriteLine($"Chocolate Name: {c1.Item1}, Price: {c1.Item2}");

        // TupleCalculator.cs
        var tc1 = TupleCalculator.Calculate();
        Console.WriteLine($"Result: {tc1.Result}, Operation: {tc1.Operation}");
    }
}