using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        switch (n)
        {
            case 1: Console.WriteLine("Shanbe"); break;
            case 2: Console.WriteLine("yek shanbe"); break;
            case 3: Console.WriteLine("2shanbe"); break;
            case 4: Console.WriteLine("3shanbe"); break;
            case 5: Console.WriteLine("4shanbe"); break;
            case 6: Console.WriteLine("5shanbe"); break;
            case 7: Console.WriteLine("jome "); break;
            default: Console.WriteLine("END"); break;
        }
    }
}