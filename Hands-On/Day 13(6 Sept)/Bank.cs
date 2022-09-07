using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public interface IBank
    {

        void print_balance();
        void calc_interest();
    }
    public class savi : IBank
    {

        public double amount;

        public savi()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.04f;

            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    }
    public class current : IBank
    {

        public double amount;

        public current()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.02f;

            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    }
}