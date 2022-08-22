using System;
public class Program2 { 

public static void Main()
{

    int num1, num2, num3;
    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number : ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    int result = num1*num2*num3;
    Console.WriteLine("Output: {0} x {1} x {2} = {3}",
    num1, num2, num3, result);

}



}