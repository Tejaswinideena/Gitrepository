using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace DataAccessLibrary
{
    public class DAL_product
    {
        public List<BL_products> ShowAllproducts()
        {
            List<BL_products> p = new List<BL_products>();
            string connstring = @"Data Source=DESKTOP-DNKKBPP\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand sq = new SqlCommand("Select * from products", conn);
            conn.Open();
            SqlDataReader sl = sq.ExecuteReader();
            while (sl.Read())
            {
                BL_products p1 = new BL_products();
                p1.ProductId = Convert.ToInt32(sl[0]);
                p1.Product_Name = sl[1].ToString();
                p1.SupplierIds = Convert.ToInt32(sl[2]);
                p1.Categoryid = Convert.ToInt32(sl[3]);
                p1.QuantityPerunits = sl[4].ToString();
                p1.Unitcost = Convert.ToDouble(sl[5]);
                p1.Unitsonorders = Convert.ToInt32(sl[6]);
                p1.ReorderLevel = Convert.ToInt32(sl[7]);
                p1.Discontinued = Convert.ToBoolean(sl[8]);
                p.Add(p1);
            }
            conn.Close();
            return p;
        }
    }
}
