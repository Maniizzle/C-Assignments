using System;


    class Program
    {
        static void Main(string[] args)
        {
        string check = OddEven();
        Console.WriteLine("It is an {0}",check);
        Console.ReadLine();
        }
        
        static string OddEven()
    {   Restart:
        Console.WriteLine("Input an Integer");
        bool success = int.TryParse(Console.ReadLine(), out int a);
        if (success)
        {
            return (a / 2 == 0) ? "Even Number" : "Odd Number";
        }
        else
        {
            goto Restart;
        }
    }
    }
