using System;
public class Program2
{
    public static void Main()
    {
        int i, n;
        int[] a = new int[100];

        Console.Write("Enter the Number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter {0} number of elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element a[{0}] : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nThe values in the array are : \n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", a[i]);
        }

        Console.Write("\n\nThe values in the array in reverse order :\n");
        for (i = n - 1; i >= 0; i--)
        {
            Console.Write("{0}  ", a[i]);
        }
        Console.Write("\n\n");
    }
}