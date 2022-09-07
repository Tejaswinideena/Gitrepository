using ReusableCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AccountType a = new AccountType();
            a.ShowMenu();
            Savings s=new Savings();
            s.Withdraw();
            s.Deposit();
            Current c=new Current();
            c.Withdraw();
            c.Deposit();
        }
    }
}
