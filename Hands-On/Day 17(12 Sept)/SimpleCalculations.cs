using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SimpleCalculations
    {
        public double _number{ get; set; }
        
        public void Cube(double Number)
        {
            Console.WriteLine("Cube of given Number");
            _number = Number;
            double ans = Number * Number * Number;
            Console.WriteLine(ans);
        }
        public void Sqrt(double num)
        {
            Console.WriteLine("Square Root of given Number");
            _number = num;
            double ans = Math.Sqrt(num);
            Console.WriteLine(ans);
        }
    }
}
