using System;
public class Program2
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("Largest of three numbers");
        Console.Write(" \n\n");
        Console.Write("Enter the first number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the  second number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third  number :");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("First Number is the greatest. \n\n");
            }
            else
            {
                Console.Write("Third Number is the greatest. \n\n");
            }
        }
        else if (num2 > num3)
            Console.Write("The Second Number is the greatest. \n\n");
        else
            Console.Write("The Third Number is the greatest\n\n");
    }
}