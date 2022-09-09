using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    public class EmployeeData
    {
        public delegate Dept del(Dept p);
        public delegate void del1(List<Employee1> m);
        public delegate List<Employee1> numb2(int i, List<Employee1> p);
        public class Dept
        {
            public int DeptNo
            {
                get;
                set;
            }
            public string DeptName
            {
                get;
                set;
            }
            public string Location
            {
                get;
                set;
            }
            public List<Employee1> list
            {
                get;
                set;
            }

            List<Employee1> p = new List<Employee1>();
            public Dept AddDept(Dept t)
            { 
                
                if (p.Count <= 10)
                {
                    Employee1 m = new Employee1();
                    Console.WriteLine("Enter the employee no");
                    m.EmployeeNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the name");
                    m.Empname = Console.ReadLine();
                    Console.WriteLine("Enter the dept no");
                    m.DeptNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the salary");
                    m.Salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the manager");
                    m.Manager = Console.ReadLine();



                    p.Add(m);
                    t.list= p;
                    return t;
                }
                else
                {

                    Console.WriteLine("You can't add more than 10 in a dept");
                    return t;

                }
            }


        }
        public class Employee1:Dept
        {

            public int EmployeeNo
            {
                get;
                set;
            }
            public string Empname
            {
                get;
                set;
            }
            
            public int Salary
            {
                get;
                set;

            }
            public string Manager
            {
                get;
                set;
            }
            public List<Employee1> Edit(int EmpId, List<Employee1> m)
            {
                Console.WriteLine("Edit Menu\n 1.Empname\n 2.Salary\n 3.Manager");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter New name");
                                item.Empname = Console.ReadLine();

                            }
                        }

                        break;

                    case 2:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter New salary");
                                item.Salary = Convert.ToInt32(Console.ReadLine());

                            }
                        }

                        break;
                    case 3:
                        foreach (var item in m)
                        {
                            if (item.EmployeeNo == EmpId)
                            {

                                Console.WriteLine("Enter New Manager");
                                item.Manager = Console.ReadLine();
                            }
                        }

                        break;
                    default:
                        break;
                }

                return m;
            }
            public List<Employee1> Delete(int id, List<Employee1> m)
            {
                m = m.Where(m1 => m1.EmployeeNo != id).ToList();
                return m;

            }
            public void Displaybymgr(List<Employee1> m)
            {
                Console.WriteLine("Enter the Name of the Manager to know Employees who is working under him ");
                string s = Console.ReadLine();
                var mg = m.Where(m2 => m2.Manager == s).ToList();
                if (mg.Count > 0)
                {
                    foreach (var item in mg)
                        Console.WriteLine(item.Empname);
                }
                else
                {
                    Console.WriteLine("No Employee is working under him");
                }
            }
            public void Display(List<Employee1> m)
            {
                foreach (var item in m)
                {
                    Console.WriteLine($"{item.EmployeeNo} {item.Empname} {item.DeptNo} {item.Salary} {item.Manager}\n");
                }

            }

        }
    }
}