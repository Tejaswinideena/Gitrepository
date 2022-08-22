using System;
public class Program10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("return true if one is negative and one is positive:");
        Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}