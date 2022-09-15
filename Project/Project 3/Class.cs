using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    public class student
    {
        public string name;
        public int classes;
        public char section;

        public virtual void gets()
        {
            Console.WriteLine("Enter the Student details\n");
            Console.WriteLine("Enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the section");
            section = Convert.ToChar(Console.ReadLine());
        }
        public virtual void prints()
        {
            Console.WriteLine("\nPrint the Student details");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
        }
    }
    public class teacher : student
    {
        public string subject;
        public override void gets()
        {
            Console.WriteLine("Enter the Teacher details\n");
            Console.WriteLine("Enter the Teacher name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the section");
            section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the subject");
            subject = Console.ReadLine();
        }
        public override void prints()
        {
            Console.WriteLine("\nPrint the Staff details");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
            Console.WriteLine(subject);
        }
    }
    public class subject : student
    {
        public string subject_code;
        public override void gets()
        {
            Console.WriteLine("Enter the subject details\n");
            Console.WriteLine("Enter the subject name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the subject code");
            subject_code = Console.ReadLine();

        }
        public override void prints()
        {
            Console.WriteLine("\nPrint the Subject details");
            Console.WriteLine(name);
            Console.WriteLine(subject_code);

        }
    }

}