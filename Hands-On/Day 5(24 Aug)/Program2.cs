using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Program2
    {
        public static void Copy()
        {
            Console.WriteLine("Enter a string: ");
            string s1 = Console.ReadLine();
            var s = string.Copy(s1);
            Console.WriteLine("Copy of String: \n" + s);
            Console.ReadLine();
        }
    }
}
