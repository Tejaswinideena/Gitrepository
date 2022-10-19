using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBasicDemo
{
    public class CalculatorApplication
    {
        public int Add(int i,int j)
        {
            return i + j;
        }
        public int Substract(int i, int j)
        {
            return i - j;
        }
        public int Multiply(int i, int j)
        {
            return i * j;
        }
        public int Divide(int i, int j)
        {
            return j != 0 ? i / j: 0;
        }
        public int Sqrt(double i)
        {
            return i != 0 ? (int)Math.Sqrt(i) : 0;
        }
    }
}
