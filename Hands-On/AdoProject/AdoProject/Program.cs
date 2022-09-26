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
            Console.WriteLine("List of Products");
            List<BL_products> po = new List<BL_products>();
            HelperClass c = new HelperClass();
            po = c.Get_products();
            foreach (var item in po)
            {
                Console.Write($"{item.ProductId},{item.Product_Name},{item.SupplierIds},{item.Categoryid},{item.QuantityPerunits},{item.Unitcost},{item.Unitsonorders},{item.ReorderLevel},{item.Discontinued}\n");
            }
            Console.Read();
        }
    }
}
