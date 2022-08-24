using System;

struct Employee
{
    public int id;

    public string Name;

    public int Sal;

    public int Deptno;

    public void SetEmployee(int e_id, string name, int sal, int deptno)
    {
        id = e_id;

        Name = name;

        Sal = sal;

        Deptno = deptno;

    }
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID : " + id);

        Console.WriteLine("Employee Name : " + Name);

        Console.WriteLine("Employee Salary : " + Sal);

        Console.WriteLine("Employee Deptno : " + Deptno);

        Console.WriteLine("\n");

    }
}


public class Program5
{
    public static void Main(string[] args)
    {

        Employee[] emp = {
                       new Employee(),

                       new Employee(),

                       new Employee(),

                       new Employee()
        };

        emp[0].SetEmployee(1, "Rakesh", 20000, 9);

        emp[1].SetEmployee(2, "Rajesh", 15000, 10);

        emp[2].SetEmployee(3, "Kavi", 30000, 11);

        emp[3].SetEmployee(4, "Dinesh", 10000, 12);


        emp[0].DisplayEmployee();

        emp[1].DisplayEmployee();

        emp[2].DisplayEmployee();

        emp[3].DisplayEmployee();
    }
}

