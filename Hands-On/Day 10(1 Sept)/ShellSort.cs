using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class ShellSort
    {
        static void Main(string[] args)
        {
            Shellsort();
            Console.Read();
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static void Shellsort()
        {
            int[] arr = new int[] { 25, 13, 43, 30, 94, 37, 87, 14, 74 };
            int inner, outer, valueToInsert, interval = 1, i = 0;
            Console.WriteLine("Before Sort: ");
            printArr(arr);
            Console.WriteLine("----------------------------");
            while (interval <= ((arr.Length) / 3))
            {
                interval = interval * 3 + 1;
            }
            while (interval > 0)
            {
                for (outer = 0; outer < arr.Length; outer++)
                {
                    valueToInsert = arr[outer];
                    inner = outer;
                    while ((inner > interval - 1) && (arr[inner - interval] >= valueToInsert))
                    {
                        arr[inner] = arr[inner - interval];
                        inner = inner - interval;
                        Console.WriteLine("Item moved: " + arr[inner]);
                    }
                    arr[inner] = valueToInsert;
                    Console.WriteLine("Item inserted: " + arr[inner]);
                }
                interval = (interval - 1) / 3;
                i += 1;
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("After Sort: ");
            printArr(arr);

        }
    }
}
