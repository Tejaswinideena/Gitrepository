using System;
public class Program3
{
    public static void Main()
    {
        int[] a = new int[100];
        int i, n, sum = 0;


        Console.Write("\nEnter the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element a[{0}] : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            sum += a[i];
        }

        Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
    }
}