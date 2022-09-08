using System;
using Handson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    public class Program
    {
        public delegate string Concat(string i, string j);
        static void Main(string[] args)
        {
            Console.WriteLine("1.String Length");
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            stroperation s1 = new stroperation();
            stringOp s2 = new stringOp(s1.stringlen);
            s2(str);

            Console.WriteLine("\n2.Greet User");
            Console.WriteLine("Enter username");
            string greet1 = Console.ReadLine();
            stringOp s3 = new stringOp(s1.greet);
            s3(greet1);

            Console.WriteLine("\n3.Math Operations");
            Console.WriteLine("Enter the two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            integer math= new integer();
            MathOp[] d3 = new MathOp[3] { math.Add, math.Sub, math.Multiply };
            MathOp d4 = (MathOp)MulticastDelegate.Combine(d3);
            d4(x, y);

            Console.WriteLine("\n4.Display Products");
            Console.WriteLine("Enter productId and product name");
            Products1 p1 = new Products1();
            p1.PId = Convert.ToInt32(Console.ReadLine());
            p1.Name = Console.ReadLine();
            Productdel prod = new Productdel(p1.Display);
            prod(p1);

            Console.WriteLine("\n5.Calculate experience year");
            Console.WriteLine("Enter the year,Month,date");
            int yr = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int dt = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(yr, month, dt);
            emp.JoiningDate = t;
            Joindate s4 = new Joindate(emp.Expyrs);
            int exp = s4(emp.JoiningDate);
            Console.WriteLine("Years of experience is "+exp);

            Console.WriteLine("\n6.Concatenate two strings");
            Console.WriteLine("Enter strings to Concatenate");
            string m = Console.ReadLine();
            string n = Console.ReadLine();
            Concat con = delegate (string sm, string sn)
            {
                return sm + sn;
            };
            string str1 = con(m, n);
            Console.WriteLine("Concatenated string is "+str1);

            Console.WriteLine("\n7.Capitilize first letter in string");
            Capitalize cap = new Capitalize();
            Cap c1 = new Cap(cap.FirstCharToUpper);
            c1(cap);

            Console.ReadLine();
        }
    }
}
