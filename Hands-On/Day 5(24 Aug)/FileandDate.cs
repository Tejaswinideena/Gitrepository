using System;
using System.IO;

namespace ReusableCodeLibrary
{
    public class FileandDate
    {
        public static void Makefile()
        {
            //Program 6
            string path = @"C:\Users\new\Documents\Demo\demo.txt";
            File.Create(path);
        }
        public static void Datedetails()
        {
            //Program 7
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("\n");
            Console.WriteLine("Year= " + dt.Year);
            Console.WriteLine("Month= " + dt.Month);
            Console.WriteLine("Day= " + dt.Day);
            Console.WriteLine("Hour= " + dt.Hour);
            Console.WriteLine("Minute= " + dt.Minute);
            Console.WriteLine("Seconds= " + dt.Second);
            Console.WriteLine("Milliseconds= " + dt.Millisecond);
          
        }
    }
}
