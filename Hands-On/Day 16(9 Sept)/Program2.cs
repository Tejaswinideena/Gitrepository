using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Sept9
{
    public class Program2
    {
        static void M1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);

        }

        static void M2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Print  {0} ", i);
                Console.WriteLine("Thread name " + Thread.CurrentThread.Name);
                Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);

                Thread.Sleep(200);
            }

        }
        static void Main(string[] args)
        {
            ThreadAliveAndStates();


            Thread t1 = new Thread(new ThreadStart(M2));
            t1.Name = "Thread 1";
            Thread t2 = new Thread(M2);
            t2.Name = "Thread 2";
            Thread t3 = new Thread(M2);
            t3.Name = "Thread 3";
  
            t1.Start();
            t2.Start();
            t3.Start();



            Console.ReadLine();



        }

        private static void ThreadAliveAndStates()
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M1);
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Abort();
            t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
        }
    }
}