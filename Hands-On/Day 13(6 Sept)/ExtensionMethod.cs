using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public static class ExtensionMethod
    {
        static int AvailableBalance = 10000;
        public static bool Withdraw(this Savings s)
        {
            Console.WriteLine("Enter the amt to Withdraw");
            int amt = Convert.ToInt32(Console.ReadLine());

            bool status = false;
            if (amt <= AvailableBalance)
            {
                AvailableBalance = AvailableBalance - amt;
                status = true;
            }
            Console.WriteLine("After withdraw available bal=" + AvailableBalance);

            return status;
        }
        public static bool Deposit(this Savings s)
        {
            Console.WriteLine("Enter the amt to Deposit");
            int amt = Convert.ToInt32(Console.ReadLine());

            bool status = false;
            if (amt <= AvailableBalance)
            {
                AvailableBalance = AvailableBalance + amt;
                status = true;
            }
            Console.WriteLine("After Deposit available bal=" + AvailableBalance);

            return status;
        }
        public static bool Withdraw(this Current c)
        {
            Console.WriteLine("Enter the amt to Withdraw");
            int amt = Convert.ToInt32(Console.ReadLine());

            bool status = false;
            if (amt <= AvailableBalance)
            {
                AvailableBalance = AvailableBalance - amt;
                status = true;
            }
            Console.WriteLine("After withdraw available bal=" + AvailableBalance);

            return status;
        }
        public static bool Deposit(this Current c)
        {
            Console.WriteLine("Enter the amt to Deposit");
            int amt = Convert.ToInt32(Console.ReadLine());

            bool status = false;
            if (amt <= AvailableBalance)
            {
                AvailableBalance = AvailableBalance + amt;
                status = true;
            }
            Console.WriteLine("After Deposit available bal=" + AvailableBalance);

            return status;
        }
        
    }
}
