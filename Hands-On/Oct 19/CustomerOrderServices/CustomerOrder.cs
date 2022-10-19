using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CustomerOrderServices.Customer;

namespace CustomerOrderServices
{
    public class CustomerOrder
    {
        public void Discount(Customer c, Order o)
        {
            if (c.customerType == CustomerType.Premium)
            {
                o.Amount = o.Amount - ((o.Amount * 10) / 100);
            }
            else if (c.customerType == CustomerType.Gold)
            {
                o.Amount = o.Amount - ((o.Amount * 20) / 100);
            }
        }
        public void GetCustomersList(Customer c1)
        {
            SqlConnection sql = new SqlConnection("Data Source=DESKTOP-DNKKBPP\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Customers",sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Customer> custList = new List<Customer>();
            // Customer c = new Customer();
            while (dr.Read())
            {
                Customer cust = new Customer();
                cust.CustName = dr["ContactName"].ToString();
                cust.CustId= dr[0].ToString();

                // cust.CustID = dr[0].ToString();
                custList.Add(cust);

            }
            sql.Close();
            c1.Customers = custList;
        }
    }
}
