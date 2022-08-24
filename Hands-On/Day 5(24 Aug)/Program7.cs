using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Program7
    {
        public static void Datedetails()
        {
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
