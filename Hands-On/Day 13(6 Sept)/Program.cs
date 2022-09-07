using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Day13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p;
            p = new Employees();
            p.Work();
            p = new Manager();
            p.Work();
            p = new Clerk();
            p.Work();    
            Console.WriteLine("\n");
            bank b1 = new bank();
            b1.print_balance();
            b1.calc_interest();   
            Console.WriteLine("\n");
            Console.WriteLine("Savings Account");
            IBank b = new savi();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("Current Account");
            IBank b2 = new current();
            b2.print_balance();
            b2.calc_interest();
            Console.WriteLine("\n");
           
            bankss g = new bankss();
            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();           

            Console.WriteLine("\n");

            bank d1 = new bank();
            Console.WriteLine("Enter deposit year, month, date: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            DateTime n = new DateTime(y, m, d);
            d1.Date = n;
            d1.NoOfDays();

        }
    }
}
