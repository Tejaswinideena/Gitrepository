using System;
using System.IO;
using System.Text;

class Program1
    {
        
        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                max = a;
            else
                max = b;

            if (a < b)
                min = a;
            else
                min = b;
            Console.WriteLine("Max number = {0}", max);
            Console.WriteLine("Min number = {0}", min);
            
            Console.ReadLine();
        }
    }
