using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface Transaction
    {

        void print_balance();
        void calc_interest();
    }
    public class bank : Transaction
    {

        public double amount;

        public bank()
        {

            amount = 0;
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public void NoOfDays()
        {
            TimeSpan t = DateTime.Now - Date;
            Console.WriteLine("No of Days: " + t.TotalDays);
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            int r;
            Console.WriteLine("Enter the interest to calculate");
            r = Convert.ToInt32(Console.ReadLine());
            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    }
}