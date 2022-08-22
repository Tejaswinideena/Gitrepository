using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program1
    {
        public static void Main(string[] args)
        {
            int a,b;
            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swap a=" + a + " b=" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("after swap a=" + a + "  b=" + b);
            
        }
    }

