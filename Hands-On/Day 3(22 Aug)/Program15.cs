using System;
using System.Collections.Generic;
  
public class Program15
{
  
    public static void printFirstRepeating(int[] arr)
    {
       
        int min = -1;

        HashSet<int> set = new HashSet<int>();

      
        for (int i = arr.Length - 1; i >= 0; i--)
        {
           
            if (set.Contains(arr[i]))
            {
                min = i;
            }

            else 
            {
                set.Add(arr[i]);
            }
        }

       
        if (min != -1)
        {
            Console.WriteLine("The first repeating element is " + arr[min]);
        }
        else
        {
            Console.WriteLine("There are no repeating elements");
        }
    }

  
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 11, 5, 7, 8, 2, 7, 6 };
        printFirstRepeating(arr);
    }
}