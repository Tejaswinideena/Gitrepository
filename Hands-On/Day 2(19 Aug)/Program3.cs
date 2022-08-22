using System;

public class Program3
{
    public static void Main()
    {
        char a,b;

        Console.WriteLine("Enter the first character : ");
        a = Console.ReadLine()[0];

        Console.WriteLine("Enter the second character : ");
        b = Console.ReadLine()[0];

        if (a == b)
            Console.WriteLine("Equal");
        else
            Console.WriteLine("Not equal");
    }
}