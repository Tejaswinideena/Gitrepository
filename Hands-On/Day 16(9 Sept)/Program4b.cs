using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sept9
{
    public class Program4b
    {
        //Monitor

        static object l1 = new object();
        static void Print()
        {

            Thread.Sleep(800);
            WriteToFile();

        }

        static void WriteToFile()
        {
            string threadname = Thread.CurrentThread.Name;
            Console.WriteLine(threadname);
            Monitor.Enter(l1);

            try
            {

                using (FileStream fs = new FileStream("thread.txt", FileMode.Append, FileAccess.Write))
                {
                    StreamWriter wr = new StreamWriter(fs);
                    wr.WriteLine(threadname);
                    wr.Close();
                    fs.Close();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {


                Monitor.Exit(l1);
                Console.WriteLine("Releasing the thread " + threadname);

            }




        }
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = string.Concat("Thread ", i);
                thread.Start();

            }
            Console.Read();

        }
    }
}