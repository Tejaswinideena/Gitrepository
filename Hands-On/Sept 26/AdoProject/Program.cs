using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using HelperLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("--------------------------------");
            Employee_Helper helper = new Employee_Helper();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add book details \n2.add member details\n3.update member details");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Employee_BAL emp = new Employee_BAL();
            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter book id");
                    emp.book_id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter bookname");
                    emp.book_name = Console.ReadLine().Trim();
                    Console.WriteLine("Enter book author");
                    emp.book_author = Console.ReadLine().Trim();


                    bool queryStatus = helper.AddEmployee(emp);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter member id");
                    emp.member_id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter member name");
                    emp.member_name = Console.ReadLine().Trim();



                    bool queryStatuss = helper.AddEmployees(emp);
                    if (queryStatuss)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter member id ");
                    emp.member_id = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter member name");
                    emp.member_name = Console.ReadLine().Trim();


                    bool queryStatuse = helper.EditEmployee(emp);
                    if (queryStatuse)
                    {
                        Console.WriteLine("Members detail updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }


                    break;
            }
        }

    }
}
