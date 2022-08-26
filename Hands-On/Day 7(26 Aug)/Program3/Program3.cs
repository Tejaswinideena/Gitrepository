using System;
using System.Collections.Generic;
using Handson;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Program
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            List<Products> product = new List<Products>();
            product.Add(new Products { Pid = 1, Pname = "Ball", Price = 100 });
            product.Add(new Products { Pid = 2, Pname = "Pencil", Price = 15 });
            product.Add(new Products { Pid = 3, Pname = "Earphone", Price = 200 });

            Console.WriteLine("Product Details\n");
            foreach (var item in product)
            {
                Console.WriteLine("Product ID: " + item.Pid);
                Console.WriteLine("Product Name: " + item.Pname);
                Console.WriteLine("Product Price: " + item.Price);
                Console.WriteLine("\t");
            }

            product.RemoveAt(1);
            Console.WriteLine("After Removal\n");
            foreach (var item1 in product)
            {
                Console.WriteLine("Product ID: " + item1.Pid);
                Console.WriteLine("Product Name: " + item1.Pname);
                Console.WriteLine("Product Price: " + item1.Price);
                Console.WriteLine("\t");
            }

            Console.ReadLine();
        }
    }
}