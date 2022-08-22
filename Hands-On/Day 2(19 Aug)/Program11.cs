using System;
public class Program11
{
    public static void Main(string[] args)
    {
        int i, sum = 0;

        Console.Write("The sum of all integers between 100 and 200: \n");
        for (i = 101; i <200; i++)
        {
            Console.Write("{0} ", i);
            sum += i;
            
        }
        Console.Write("\n\nThe Sum: {0} \n", sum);
    }
}