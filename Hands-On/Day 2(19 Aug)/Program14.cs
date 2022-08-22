using System;
public class Program14
{
    public static void Main(String[] args)
    {
        int n;
        Console.Write("Enter a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:

                Console.WriteLine("odd");
                break;

            case 2:
                Console.WriteLine("even");
                break;
            default:
                Console.WriteLine("enter another number");
                break;
        }
    }
}