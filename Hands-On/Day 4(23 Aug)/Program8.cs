using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Divide(i, j);

            Console.ReadLine();
        }
        static void Divide(int p, int q)
        {
            try
            {
                int r;
                r = p / q;
                Console.WriteLine(r);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);

            }
            finally
            {
                Console.WriteLine("anyway printed");
            }

        }
    }
}
