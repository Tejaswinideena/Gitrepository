using System;
public class Program4
{
    public static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of Four numbers is: {4} ",number1,number2,number3,number4,result);
    }
}
