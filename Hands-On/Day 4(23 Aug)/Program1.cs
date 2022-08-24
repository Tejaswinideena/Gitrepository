using System;

namespace Program
{
    public class Program1
    {
        public static void Main()
        {
            int a, b;
            
            int sum;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            addition(a, b,out sum);
            Console.WriteLine("Sum is: "+sum);
            Console.ReadLine();
        }
        public static void addition(int a, int b,out int sum)
        {
            sum = a + b;
        }
    }
}
