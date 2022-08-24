using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Program3
    {
        public static void Indexof()
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter character to show index: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int indexofch = s.IndexOf(ch);
            Console.WriteLine("Index of given character is: " + indexofch);

        }
    }
}
