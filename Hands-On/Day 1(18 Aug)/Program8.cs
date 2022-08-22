using System;
public class Program8
{
    public static void Main()
    {
        int n;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}", n);
        Console.WriteLine("{0} {0}", n);
        Console.WriteLine("{0} {0}", n);
        Console.WriteLine("{0} {0}", n);
        Console.WriteLine("{0}{0}{0}", n);
    }
}