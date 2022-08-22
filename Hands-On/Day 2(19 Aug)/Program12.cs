using System;
public class Program12
{
    public static void Main(string[] args)
    {
        int i,sum = 0;

        Console.Write("Numbers between 100 and 200, divisible by 9 are : \n");
        for (i = 101; i < 200; i++)
        {

            if (i % 9 == 0)

            {
                Console.Write("{0} ", i);
                sum += i;
            }
        }
        Console.Write("\n\nThe sum: {0} \n", sum);
    }
}
