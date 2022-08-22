using System;

public class Program11
{
  public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter first number: ");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");

        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Check if both are positive:");

        Console.WriteLine((x > 0 && y > 0));
    }
}
    