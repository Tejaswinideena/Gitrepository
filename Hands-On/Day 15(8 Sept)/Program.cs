using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static Handson.EmployeeData;

namespace Sept8
{
    public class Program
    {
        static void Main(string[] args)
        {
        user:
            Console.WriteLine("Enter the username");
            string u = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string p = Console.ReadLine();
            var data = Tuple.Create<string, string>(u, p);
            Predicate<Tuple<string, string>> s = (data1) => {
                if (data1.Item1 == "FirstUser" && data1.Item2 == "hello123")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (s(data))
            {
                List<Employee1> emplist = new List<Employee1>();
            dis:
                Console.WriteLine("Menu\n 1.Add\n 2.Delete\n 3.Edit");
                int a= Convert.ToInt32(Console.ReadLine());

                Dept D = new Dept();
                switch(a)
                {
                    case 1:

                    Console.WriteLine("Enter deptno");
                    D.DeptNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DeptName");
                    D.DeptName = Console.ReadLine();
                    Console.WriteLine("Location of department");
                    D.Location = Console.ReadLine();
                add:
                    del d1 = new del(D.AddDept);
                    D = d1(D);
                    foreach (Employee1 e in D.list)
                    {
                        if (!emplist.Contains(e))
                            emplist.Add(e);

                    }
                    Console.WriteLine("Enter Yes to add further,No to Display Details");
                    string i = Console.ReadLine();
                    if (i== "Yes")
                    {
                        goto add;
                    }
                    break;
                    case 2:

                    Employee1 emp = new Employee1();
                    Console.WriteLine("Enter employee id to delete");
                    int t = Convert.ToInt32(Console.ReadLine());
                    emplist = emp.Delete(t, emplist);
                    emp.Display(emplist);
                    break;
                    case 3:
                    Console.WriteLine("Enter employee id to edit");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Employee1 emp1 = new Employee1();
                    emplist = emp1.Edit(k, emplist);
                    emp1.Display(emplist);

                    break;
                }

                Employee1 emp2 = new Employee1();
                Console.WriteLine("Display all Employee names");
                del1 d2 = new del1(emp2.Display);
                d2(emplist);
                del1 d3 = new del1(emp2.Displaybymgr);
                d3(emplist);
                Console.WriteLine("Enter Yes to Menu");
                string pass = Console.ReadLine();
                if (pass == "Yes")
                {
                    goto dis;
                }
            }
            else
            {
                Console.WriteLine("Try again");
                goto user;
            }
            Console.ReadLine();
        }
    }
}