using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Program1
    {
        public static void Compare()
        {
            Console.Write("Enter a string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            string s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", s1, s2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);
        }
    }
}
