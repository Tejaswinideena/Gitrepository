using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sept9
{
    public class Program5
    {
        //Mutex with Release & Semaphore Program

        static Mutex m = new Mutex();
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);
        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            Console.WriteLine("Mutex is Released");
            sem.Release();
        }
        static void UseCode()
        {
            m.WaitOne();
            Console.WriteLine(" has entered in the code" + Thread.CurrentThread.Name);
            Thread.Sleep(500);    
            Console.WriteLine("{0} is leaving the code",Thread.CurrentThread.Name);
            m.ReleaseMutex(); 
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(M1);
                threads[i].Name = "Thread " + i;
                threads[i].Start();
            }
            Console.ReadLine();
        }
    }
}