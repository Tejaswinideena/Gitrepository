using System;
using System.Collections.Generic;
using Handson;

namespace Sept13
{
    public class Program
    {
        static void Main(string[] args)
        {
        user:
            Console.WriteLine("Enter the username");
            string p = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string ps = Console.ReadLine();
            Tuple<string, string> t = Tuple.Create<string, string>(p, ps);

            Predicate<Tuple<string, string>> pt = (i) =>
            {
                if (i.Item1 == "user1" && i.Item2 == "password")
                {

                    return true;
                }
                else
                {
                    return false;
                }

            };
            bool b = pt.Invoke(t);
            if (b)
            {
                Console.WriteLine("Logged in successfully");
                User u = new User();
                Console.WriteLine("Enter user");
                p = Console.ReadLine();
                u.Username = p;
                Console.WriteLine("Enter type");
                u.Type = Console.ReadLine();
                u.initiate();
                List<Movie> s = new List<Movie>();
                double total = 0;
                int Count1 = 0;
            add:
                Console.WriteLine("Adding");
                s = u.adding(s, u.Type);
                Count1++;
                u.rented = s;
                if (s.Count == Count1)
                {
                    Console.WriteLine("Enter the rental year");
                    int yr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental month");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental date");
                    int dt = Convert.ToInt32(Console.ReadLine());
                    DateTime top = new DateTime(yr, mon, dt);
                    u.rentaldate = top;
                    Console.WriteLine("Enter the releasing year");
                    int ryr= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing month");
                    int rmon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing date");
                    int rdt= Convert.ToInt32(Console.ReadLine());
                    DateTime pot = new DateTime(ryr, rmon, rdt);
                    u.releasingdate = pot;
                    Console.WriteLine("Enter the cost");
                    u.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total cost for this movie", +u.TotalCost());
                    total += u.TotalCost();
                    Console.WriteLine("Enter Yes to further rental");
                    string str = Console.ReadLine();
                    if (str == "Yes")
                    {
                        goto add;
                    }
                }
                Console.WriteLine("Stocks after rented");

                foreach (var item in u.dbmovies)
                {
                    Console.WriteLine($"{item.Name} {item.stock}");
                }

                s = u.releasing(s);
                u.rented = s;
                Console.WriteLine("Total cost" + total);
                foreach (var item in u.rented)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Try again");
                goto user;
            }
        }
    }
}