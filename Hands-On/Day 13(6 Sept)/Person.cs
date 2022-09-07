using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Person
    {
        public abstract void Work();
    }
    public class Employees : Person
    {
        public override void Work()
        {
            Console.WriteLine("Calling employee");
        }
    }
    public class Manager : Person
    {


        public override void Work()
        {
            Console.WriteLine("Calling manager");
        }
    }
    public class Clerk : Person
    {


        public override void Work()
        {
            Console.WriteLine("Calling clerk");
        }
    }
}
