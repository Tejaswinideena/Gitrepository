using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {21, 42, 36, 72, 5, 99, 64, 16, 57 };
            bubbleSort(arr);
            Console.ReadLine();
        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }
}
