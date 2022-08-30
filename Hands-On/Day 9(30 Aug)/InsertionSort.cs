using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class InsertionSort
    {
        public static void Insert(int[] arr)
        {

            int i, j, temp;
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void PrintSortedArray(int[] arr)
        {

            int n = arr.Length;
            Console.WriteLine("Sorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 49,33,16,95,2,71};
            Insert(arr);
            PrintSortedArray(arr);
            Console.Read();
        }
    }
}