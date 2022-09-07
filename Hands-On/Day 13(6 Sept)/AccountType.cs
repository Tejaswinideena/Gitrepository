using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class AccountType
    {
        internal Type TypeOfAccount { get; set; }
        public void ShowMenu()
        {
            Console.WriteLine("Enter account type \n1 for savings \n2 for current");
            TypeOfAccount = (Type)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Selected account type= " + TypeOfAccount);
            Savings s = new Savings();
            
        }
        internal enum Type
        {
            Savings=1,
            Current=2
        }
        
    }

        public class Savings
        {
            public void CalculateInterest()
            {
                Console.WriteLine("Interest for Savings Account is 4%");
            }
        
        
        }
        public class Current
        {
            public void CalculateInterest()
            {
                Console.WriteLine("Interest for Current Account is 2%");
            }
        }
    
}
