using System;
public class Program5
{
    public static void Main()
    {
        int num1, num2, num3;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Result of {0}, {1} and {2} is : (a+b)·c is {3} and a·b + b·c is {4}\n\n",
            num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
    }
}