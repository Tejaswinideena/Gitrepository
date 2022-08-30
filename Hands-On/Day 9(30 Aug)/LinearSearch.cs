using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LinearSearch
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Find element to search..");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                {
                    Console.WriteLine("Found it at index = " + i);
                }
                else 
                {
                    Console.WriteLine("Not found");
                }
            }
           
            Console.ReadLine();
        }
    }
}
