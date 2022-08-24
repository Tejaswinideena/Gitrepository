using System;
struct employee
{
    public int empno;
    public string ename;
    public int salary;
    public int deptno;
};

    public class Program3
    {
        public static void Main(string[] args)
        {
            employee emp1;
            employee emp2;

            emp1.empno = 01;
            emp1.ename = "Rakesh";
            emp1.salary = 20000;
            emp1.deptno = 9;

            emp2.empno = 02;
            emp2.ename = "Rajesh";
            emp2.salary = 15000;
            emp2.deptno = 10;

            Console.WriteLine(emp1.empno);
            Console.WriteLine(emp1.ename);
            Console.WriteLine(emp1.salary);
            Console.WriteLine(emp1.deptno);
            Console.WriteLine("\n");
            Console.WriteLine(emp2.empno);
            Console.WriteLine(emp2.ename);
            Console.WriteLine(emp2.salary);
            Console.WriteLine(emp2.deptno);



            Console.ReadKey();
        }
    }
