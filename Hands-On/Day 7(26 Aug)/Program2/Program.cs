using System;
using Handson;


namespace Program2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Class1.Student[] stu = {new Class1.Student(),new Class1.Student(),new Class1.Student()};
            stu[0].setStudent(1, "virat",88,'O');
            stu[1].setStudent(2,"hanah",99, 'O');
            stu[2].setStudent(3, "Watson", 77, 'A');

            stu[0].DisplayStudent();
            Console.WriteLine("\t");
            stu[1].DisplayStudent();
            Console.WriteLine("\t");
            stu[2].DisplayStudent();
            Console.ReadLine();
        }
    }
}
