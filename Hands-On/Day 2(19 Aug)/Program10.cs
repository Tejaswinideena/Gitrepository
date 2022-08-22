using System;
public class Program10
{
    public static void Main()
    {
        int num, s, sum = 0, m;

        Console.Write("Display the number in reverse order \n");
       
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (m = num;m != 0; m = m / 10)
        {
            s = m % 10;
            sum = sum * 10 + s;
        }
        Console.Write("The number in reverse order is : {0} \n", sum);
    }
}