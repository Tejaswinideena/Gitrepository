using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Handson
{
    public class Class1
    {
        public struct Student
        {
            public int Regno;
            public string Name;
            public int Finalmark;
            public char Grade;

            public void setStudent(int reg, string name, int mark, char grade)
            {
                this.Regno = reg;
                this.Name = name;
                this.Finalmark = mark;
                this.Grade = grade;
            }
            public void DisplayStudent()
            {

                Console.WriteLine("Register Number: " + Regno);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Mark Obtained: " + Finalmark);
                Console.WriteLine("Grade: " + Grade);

            }
        }
    }
}
