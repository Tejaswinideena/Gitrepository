using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class bankss
    {
        public int x, y;
        public bankss()
        {
            x = 10000;
            y = 20000;
        }


    }
    public static class curr
    {

        public static void current(this bankss obj)
        {
            Console.WriteLine("Current balance " + obj.x);
        }
        public static void deposits(this bankss obj)
        {
            Console.WriteLine("Enter the amount to deposit in current account");
            int dep = Convert.ToInt32(Console.ReadLine());
            obj.x = dep + obj.x;
            Console.WriteLine("AMOUNT DEPOSIT");
        }
        public static void withdraw(this bankss obj)
        {
            Console.WriteLine("Enter the amount to withdraw in current account");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.x)
                obj.x = obj.x - with;
            else
                Console.WriteLine("Amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");

        }
        public static void total_balc(this bankss obj)
        {
            Console.WriteLine("Total balance in Current account " + obj.x);
        }
    }
    public static class sav
    {

        public static void savings(this bankss obj)
        {
            Console.WriteLine("Saving balance" + obj.y);
        }
        public static void deposits1(this bankss obj)
        {
            Console.WriteLine("Enter the amount to deposit in savings account");
            int dep = Convert.ToInt32(Console.ReadLine());

            obj.y = dep + obj.y;
            Console.WriteLine("AMOUNT DEPOSIT");
        }
        public static void withdraw1(this bankss obj)
        {
            Console.WriteLine("Enter the amount to withdraw in savings account");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.y)
                obj.y = obj.y - with;
            else
                Console.WriteLine("Amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");
        }
        public static void total_balc1(this bankss obj)
        {
            Console.WriteLine("Total balance in Savings account " + obj.y);
        }
    }
}