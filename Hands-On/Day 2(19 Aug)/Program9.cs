using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program9
{
    public static void Main()
    {
        int i, n, sum = 0;
       
        Console.Write("Display the sum of n odd natural number \n");

        Console.Write("Enter number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
       Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
        Console.Write("\nThe Sum of odd Natural Number upto {0} terms are : {1} \n", n, sum);
        Console.ReadLine();
    }
}
