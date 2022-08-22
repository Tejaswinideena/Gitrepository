using System;
public class Program13
{
        public static void Main(string[] args)
        {
            int[] arr = new int[] 
            {
            1,3,5,200,22,2244,213,111
            };

            Console.WriteLine("Elements Larger than 100 are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 100)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
 }