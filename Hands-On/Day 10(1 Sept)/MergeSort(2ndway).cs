using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class MergeSort_2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 32, 21, 15, 57, 65, 4, 62, 7, 40, 82 };
            Console.WriteLine("Before Sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            sort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nAfter sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
     
            Console.ReadLine();

        }
        static void sort(int[] arr, int low, int high)
        {
            int mid;
            if (low < high)
            {
                mid = (low + high) / 2;
                sort(arr, low, mid);
                sort(arr, mid + 1, high);
                merging(arr, low, mid, high);

            }
            else
            {
                return;
            }

        }

        private static void merging(int[] arr, int low, int mid, int high)
        {
            int[] barr = new int[10];
            int l1 = 0, l2 = 0, i;
            for (l1 = low, l2 = mid + 1, i = low; l1 <= mid && l2 <= high; i++)
            {

                if (arr[l1] <= arr[l2])
                {
                    barr[i] = arr[l1++];
                }
                else
                {
                    barr[i] = arr[l2++];
                }

            }
            while (l1 <= mid)

                barr[i++] = arr[l1++];

            while (l2 <= high)

                barr[i++] = arr[l2++];

            for (i = low; i <= high; i++)

                arr[i] = barr[i];

        }
    }
}
