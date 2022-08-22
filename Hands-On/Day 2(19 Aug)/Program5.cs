using System;
class Program5
{
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int max;
            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            Console.WriteLine("Maximum number is: " + max);
            Console.ReadKey();
        }
}
