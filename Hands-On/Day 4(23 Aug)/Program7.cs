using System;

namespace Program
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter first number");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int j = Convert.ToInt32(Console.ReadLine());
                int k = i / j;
                Console.WriteLine(k);


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception");
                Console.WriteLine(e.Message);

            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("\nPrinted");

            }
            Console.ReadLine();
        }
    }
}