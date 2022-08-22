using System;
public class Program13
{
    public static bool isEven(int n)
    {
        return (n % 2 == 0);
    }

    public static void Main()
    {
        int n ;
        Console.Write("Enter a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        if (isEven(n) == true)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
        if(n == 0)
        {
            Console.WriteLine("Please enter valid number");
        }
        if (n % 10 == 0)
        {
            Console.WriteLine("Its Multiple of 10");
        }
        if(n>100)
        {
            Console.WriteLine("Too large");
        }
    }
}