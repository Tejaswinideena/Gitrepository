using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sept9
{
    public class Program
    {
        public static void PrintNum()
        {
            Console.WriteLine("Printing Numbers 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
        }
        public static void PrintNumbers()
        {
            Console.WriteLine("Printing Numbers 1 to 5");
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(j);

            }
        }
        static void Main(string[] args)
        {
            //Program 1 and 3

            //  1.call method using thread

            Thread t1 = new Thread(PrintNum);     //without using Threadstart Delegate

            Thread t2 = new Thread(new ThreadStart(PrintNumbers));    //using Threadstart Delegate

            //  3.using priority with Threads

            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Normal;

            t2.Start();
            t1.Start();

            Console.ReadLine();
        }
    }
}
