using System;
using System.Collections.Generic;
using HRLibrary;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Categories c1=new Categories();
            c1.CategoryId = 1;
            c1.CategoryName = "Beverages";
            c1.Description = "Softdrinks";

            Products p1=new Products();
            p1.ProductId = 1;
            p1.ProductName = "Tea";
            p1.QuantitySold = 4;
            p1.UnitPrice = 10;
            p1.UnitofMeasurement= "litre";
            p1.QuantityInHand = 2;
            p1.ReorderLevel = "5 litre";

            Products p2 = new Products();
            p2.ProductId = 2;
            p2.ProductName = "Coffee";
            p2.QuantitySold = 3;
            p2.UnitPrice = 10;
            p2.UnitofMeasurement = "litre";
            p2.QuantityInHand = 4;
            p2.ReorderLevel = "5 litre";

            Products p3 = new Products();
            p3.AddProduct(3,"Milk");

            List<Products> prodlist = new List<Products>();
            prodlist.Add(p1);
            prodlist.Add(p2);
            prodlist.Add(p3);
            c1.ProductsList = prodlist;

            Console.WriteLine("\nCategory ID: " + c1.CategoryId);
            Console.WriteLine("Category Name: " + c1.CategoryName);
            Console.WriteLine("Category Description: " + c1.Description);
            Console.WriteLine("\n");

            foreach (var item in c1.ProductsList)
            {
                Console.WriteLine("Product ID: " + item.ProductId);
                Console.WriteLine("Product Name: " + item.ProductName);
                Console.WriteLine("Quantity Sold: " + item.QuantitySold);
                Console.WriteLine("Unit Price: " + item.UnitPrice);
                Console.WriteLine("Unit of Measurement: " + item.UnitofMeasurement);
                Console.WriteLine("Quantity in Hand: " + item.QuantityInHand);
                Console.WriteLine("Reorder Level: " + item.ReorderLevel);
                Console.WriteLine("\n");
                Categories c2 = new Categories();
                c2.ProductCount();
                Console.WriteLine("\t");
            }
            Console.WriteLine("\nDisplaying Details of Category 1\n");
            c1.DisplayDetails();

            Console.ReadLine();
        }
        
    }
}
