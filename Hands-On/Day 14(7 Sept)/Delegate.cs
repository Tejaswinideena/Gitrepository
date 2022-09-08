using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
        public delegate void stringOp(string s);
        public delegate void MathOp(int i, int j);
        public delegate void Productdel(Products1 p);
        public delegate int Joindate(DateTime t);
        public delegate void Cap(Capitalize c);
        public class stroperation
        {
            public void stringlen(string s)
            {
                Console.WriteLine(s.Length);

            }
            public void greet(string s)
            {
                Console.WriteLine("Hello "+s);
            }
        }
        public class integer
        {
            public void Add(int i, int j)
            {
                Console.WriteLine($"Addition is { i + j}");
            }
            public void Sub(int i, int j)
            {
                if (i > j)
                {
                    Console.WriteLine($"Subtraction is {i - j}");
                }
                else
                {
                    Console.WriteLine($"Subtraction is {j - i}");
                }
            }
            public void Multiply(int i, int j)
            {
                Console.WriteLine($"Multiplication is {j * i}");
            }

        }
        public class Products1
        {
            public int PId
            {
                get;
                set;
            }
            public string Name
            {
                get;
                set;
            }
            public void Display(Products1 p)
            {
                Console.WriteLine("Product id is "+p.PId + " and Product Name is "+p.Name);
            }
        }
        public class Employee
        {
            private DateTime _joiningdate;
            public DateTime JoiningDate
            {
                get { return _joiningdate; }
                set { _joiningdate = value; }

            }
            public int Expyrs(DateTime ji)
            {
                int p = DateTime.Now.Year - ji.Year;
                return p;
            }
        }
        public class Capitalize
        {
            public void FirstCharToUpper(Capitalize c)
            {
                string str = "first";

                if (str.Length == 0)
                {
                    Console.WriteLine("Empty String");
                }
                else if (str.Length == 1)
                {
                    Console.WriteLine(char.ToUpper(str[0]));
                }
                else
                {
                    Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
                }
            }
        }
    
}
