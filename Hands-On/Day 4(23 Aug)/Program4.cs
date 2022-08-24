using System;

namespace Exercise4
{

    struct Employee
    {
        public int id;
        public string name;
        public int salary;
        public int deptno;

        
        public void display()
        {
            Console.WriteLine("Employee Id: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Employee Deptno: " + deptno);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;
            Employee emp2;

            emp1.id = 1;
            emp1.name = "Rakesh";
            emp1.salary = 20000;
            emp1.deptno = 9;

            emp2.id = 2;
            emp2.name = "Rajesh";
            emp2.salary = 15000;
            emp2.deptno = 10; 

            emp1.display();
            Console.WriteLine("\n");
            emp2.display();
            Console.ReadLine();
        }
        
    }
}