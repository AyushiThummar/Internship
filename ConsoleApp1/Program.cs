////// See https://aka.ms/new-console-template for more information

//using ConsoleApp1;
//using System;
//using static ConsoleApp1.DelegateExample;
//using static ConsoleApp1.GenericExample;

//public class Program
//{
//    /*static(int, string, double) Student()
//    {
//        int rollno = 101;
//        string name = "John Doe";
//        double marks = 85.5;
//        return (rollno, name, marks);
//    }*/
//    public static void Main(string[] args)
//    {

//        Console.WriteLine("Hello, World!");


//        //// Calculator.cs
//        //Calculator calculator = new Calculator();


//        //// MethodOverloading.cs
//        //Console.WriteLine("Addition of int a,b : " + MethodOverloading.Addition(10, 20));
//        //Console.WriteLine("Addition of int a,b,c : " + MethodOverloading.Addition(10, 20, 30));
//        //Console.WriteLine("Addition of double a,b : " + MethodOverloading.Addition(10.5, 20.5));


//        //// Inheritance.cs
//        //Inheritance.Chocolate c1 = new Inheritance.Chocolate();
//        //Console.WriteLine("Taste of Chocolate: " + c1.Taste);
//        //c1.Price();
//        //Inheritance.DarkChocolate dc1 = new Inheritance.DarkChocolate();
//        //Console.WriteLine("Name of Dark Chocolate: " + dc1.name);

//        //// Tuple.cs
//        //var s1 = ConsoleApp1.Tuple.Student();
//        //Console.WriteLine($"Roll No: {s1.Item1}, Name: {s1.Item2}, CGPA: {s1.Item3}");
//        //var s2 = ConsoleApp1.Tuple.Student1();
//        //Console.WriteLine($"Roll No: {s2.Item1}, Name: {s2.Item2}, CGPA: {s2.Item3}");
//        //var c1 = ConsoleApp1.Tuple.Chocolate();
//        //Console.WriteLine($"Chocolate Name: {c1.Item1}, Price: {c1.Item2}");


//        //// TupleCalculator.cs
//        //var tc1 = TupleCalculator.Calculate();
//        //Console.WriteLine($"Result: {tc1.Result}, Operation: {tc1.Operation}");


//        //// Boolean.cs
//        //ConsoleApp1.Boolean b1 = new ConsoleApp1.Boolean();


//        //// DisplayCalculator.cs
//        //Console.WriteLine("Enter value of number 1 : ");
//        //int num1 = DisplayCalculator.Exception(Console.ReadLine(),20);
//        //Console.WriteLine("Enter value of number 2 : ");
//        //int num2 = DisplayCalculator.Exception(Console.ReadLine(),5);
//        //Console.WriteLine("Enter your choice of operation (+,-,*,/)");
//        //string opInput = Console.ReadLine() ?? "";
//        //string op = string.IsNullOrWhiteSpace(opInput) ? "+" : opInput;
//        //DisplayCalculator.Display(num1, num2, op);


//        // RefOut.cs
//        int x = 10;
//        Console.WriteLine("Before calling the method, x = " + x);
//        RefOut.RefExample(ref x);
//        Console.WriteLine("After calling the method, x = " + x);
//        int y;
//        RefOut.OutExample(out y);
//        Console.WriteLine("After calling the method, y = " + y);


//        //// MinMaxP.cs
//        //Console.WriteLine("Enter your salary : ");
//        //double salary = DisplayCalculator.Exception(Console.ReadLine(), 500000);
//        //MinMaxP.CalculateSalary(salary);


//        //// InterfaceExample.cs
//        //InterfaceExample.College c1 = new InterfaceExample.College();
//        //c1.Event();
//        //InterfaceExample.Admin a1 = new InterfaceExample.Admin();
//        //a1.Event();


//        //// PolymorphismExample.cs
//        //PolymorphismExample.Fruit f1 = new PolymorphismExample.Fruit();
//        //f1.Color();
//        //PolymorphismExample.Banana b1 = new PolymorphismExample.Banana();
//        //b1.Color();
//        //PolymorphismExample.Apple a1 = new PolymorphismExample.Apple();
//        //a1.Color();


//        //// AbstractionExample.cs
//        ////AbstractionExample.Clothes c1 = new AbstractionExample.Clothes(); // We can't create instance of abstract class.
//        //AbstractionExample.Shirt s1 = new AbstractionExample.Shirt();
//        //s1.Fabric();
//        //s1.Price();
//        //AbstractionExample.Jeans j1 = new AbstractionExample.Jeans();
//        //j1.Fabric();
//        //j1.Price();


//        //// MultipleInterface.cs
//        //MultipleInterface.ImplementInterface i1 = new MultipleInterface.ImplementInterface();
//        //i1.FirstMethod();
//        //i1.SecondMethod();


//        //// EncapsulationExample.cs
//        //EncapsulationExample.Student s1 = new EncapsulationExample.Student();
//        //s1.Marks = 99;
//        //Console.WriteLine("Marks :- " + s1.Marks);
//        //EncapsulationExample.Student1 n1 = new EncapsulationExample.Student1();
//        //n1.Name = "Ayushi";
//        //Console.WriteLine("Name :- " + n1.Name);
//        //EncapsulationExample.User u1 = new EncapsulationExample.User();
//        //u1.Username = "abc";
//        //Console.WriteLine("Username :- " + u1.Username);


//        //// Enumerations.cs
//        //Enumerations.WeekDays e1 = Enumerations.WeekDays.Sunday;
//        //Console.WriteLine("My favorite day is " + e1);
//        //int day = (int) Enumerations.WeekDays.Sunday;
//        //Console.WriteLine("Sunday is on day number " + day);
//        //int mon = (int) Enumerations.Months.August;
//        //Console.WriteLine("August with value assign by me " + mon);
//        //Enumerations l1 = new Enumerations();
//        //l1.DisplayLevel();


//        //// Exceptions.cs
//        ////Exceptions.Divide();
//        ////Exceptions.CheckAge(15);
//        //Exceptions.CheckAge(20);


//        //// JaggedArray.cs
//        //JaggedArray j1 = new JaggedArray();
//        //j1.Display();
//        //JaggedArray j2 = new JaggedArray();
//        //j2.Display2();


//        //// GenericExample.cs
//        //GenericExample.DataStore<string> cities = new GenericExample.DataStore<string>();
//        //cities.AddOrUpdate(0, "Mumbai");
//        //cities.AddOrUpdate(1, "Taiwan");
//        //cities.AddOrUpdate(2, "London");
//        ////Console.WriteLine(cities.GetData(100));
//        //Console.WriteLine(cities.GetData(1) + " is on index 1.");
//        //GenericExample.DataStore<int> empIds = new GenericExample.DataStore<int>();
//        //empIds.AddOrUpdate(0, 50);
//        //empIds.AddOrUpdate(1, 565);
//        //empIds.AddOrUpdate(2, 4689);
//        //Console.WriteLine(empIds.GetData(0) + " is on index 0.");
//        //GenericExample.Printer p1 = new GenericExample.Printer();
//        //p1.Print<int>(100);
//        //p1.Print<int>(100);
//        //p1.Print(200); // type infer from the specified value
//        //p1.Print<string>("Hello");
//        //p1.Print("World!"); // type infer from the specified value


//        //// ArrayListExample.cs
//        //ArrayListExample a1 = new ArrayListExample();
//        //a1.Display();
//        //a1.DisplayInsert();
//        //a1.DisplayInsertRange();
//        //a1.DisplayRemove();


//        //// ListExample.cs
//        //ListExample l1 = new ListExample();
//        //l1.DisplayListInt();
//        //l1.DisplayListString();
//        //l1.DisplayCities();
//        //l1.DisplayInsert();
//        //l1.DisplayRemove();


//        //// DictionaryExample.cs
//        //DictionaryExample d1 = new DictionaryExample();
//        //d1.DisplayDictionary();
//        //d1.DisplayCities();
//        //d1.UpdateDictionary();
//        //d1.RemoveDictionary();


//        //// StackExample.cs
//        //StackExample s1 = new StackExample();
//        //s1.DisplayStack();
//        //s1.DisplayStack2();
//        //s1.PopStack();
//        //s1.PeekStack();


//        //// QueueExample.cs
//        //QueueExample q1 = new QueueExample();
//        //q1.DisplayQueue();


//        //// DelegateExample.cs
//        //MyDelegate del = ClassA.MethodA;
//        //del("Hello World! ClassA");
//        //del = ClassB.MethodB;
//        //del("Hello World! ClassB");
//        //del=(string msg) => Console.WriteLine("Called lambda function. "+msg);
//        //del("Hello World!");

//        //MyDelegateInt del1 = ClassAI.MethodA;
//        //MyDelegateInt del2 = ClassBI.MethodB;
//        //MyDelegateInt deli = del1 + del2;
//        //Console.WriteLine(deli());


//        //// FuncDelegate.cs
//        //Func<int, int, int> add = FuncDelegate.Sum;
//        //int result = add(10, 10);
//        //Console.WriteLine(result);
//        //Console.WriteLine(FuncDelegate.getRandomNumber());
//        //Console.WriteLine(FuncDelegate.Add(10, 20));

//        //Action<int> printActionDel = FuncDelegate.ConsolePrint;
//        //printActionDel(10);

//        //Predicate<string> isUpper = FuncDelegate.IsUpperCase;
//        //bool result = isUpper("hello world!!");
//        //Console.WriteLine(result);


//        //// EventExample.cs

//        //// Basic Event
//        //static void b1_MoneyWithdrawn()
//        //{
//        //    Console.WriteLine("Notification : Withdrawal completed!");
//        //}
//        //EventExample.BankAccount b1 = new EventExample.BankAccount();
//        //b1.MoneyWithdrawn += b1_MoneyWithdrawn;
//        //b1.Withdraw();

//        //// EventHandler
//        //static void b1_MoneyWithdrawn(object? sender, EventArgs e)
//        //{
//        //    Console.WriteLine("Notification : Withdrawal completed!");
//        //}
//        //EventExample.BankAccount b1 = new EventExample.BankAccount();
//        //b1.MoneyWithdrawn += b1_MoneyWithdrawn;
//        //b1.Withdraw();

//        //// Event Data
//        //static void b1_MoneyWithdrawn(object? sender, bool isSuccessful)
//        //{
//        //    if (isSuccessful)
//        //    {
//        //        Console.WriteLine("Notification: Withdrawal completed successfully!");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("Notification: Withdrawal failed!");
//        //    }
//        //}
//        //EventExample.BankAccount b1 = new EventExample.BankAccount();
//        //b1.MoneyWithdrawn += b1_MoneyWithdrawn;
//        //b1.Withdraw();

//        //// Custom EventArgs
//        //static void b1_MoneyWithdrawn(object? sender, EventExample.ProcessEventArgs e)
//        //{
//        //    if (e.IsSuccessful)
//        //    {
//        //        Console.WriteLine("Notification: Withdrawal completed successfully!");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("Notification: Withdrawal failed!");
//        //    }
//        //    Console.WriteLine("Completion Time: " + e.CompletionTime);
//        //}
//        //EventExample.BankAccount b1 = new EventExample.BankAccount();
//        //b1.MoneyWithdrawn += b1_MoneyWithdrawn;
//        //b1.Withdraw();


//        //// FileExample.cs
//        //FileExample f1 = new FileExample();
//        //f1.CreateFile();
//        //f1.WriteFile();
//        //f1.AppendFile();
//        //f1.ReadFile();
//        //f1.ReadAllLines();
//        //f1.CheckFile();
//        //f1.CopyFile();
//        //f1.MoveFile();
//        //f1.DeleteFile();


//        //// FileInfoExample.cs
//        //FileInfoExample fileInfo = new FileInfoExample();
//        //fileInfo.CreateFile();
//        //fileInfo.WriteFile();
//        //fileInfo.AppendFile();
//        //fileInfo.ReadFile();
//        //fileInfo.CheckFile();
//        //fileInfo.CopyFile();
//        //fileInfo.MoveFile();
//        //fileInfo.DeleteFile();
//        //fileInfo.GetFileInfo();
//    }
//}