using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BusinessLogicLibrary;
namespace DataAccessLibrary
{
    public class Employee_DAL
    {
        public bool InsertEmployee(Employee_BAL employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into book(book_id,book_name,book_author) values(@book_id,@book_name,@book_author)", cn);
            cmdInsert.Parameters.AddWithValue("@book_id", employee.book_id);
            cmdInsert.Parameters.AddWithValue("@book_name", employee.book_name);
            cmdInsert.Parameters.AddWithValue("@book_author", employee.book_author);

            /*SqlCommand cmdInserts = new SqlCommand("insert into member(member_id,member_name) values(@member_id,@member_name)", cn);
            cmdInserts.Parameters.AddWithValue("@member_id", employee.memberid);
            cmdInserts.Parameters.AddWithValue("@member_name", employee.membername); */


            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();

            bool status = false;

            if (i == 1)
            {
                status = true;
            }

            cn.Close();//finally
            cn.Dispose();//finally
            return status;



        }
        public bool InsertEmployees(Employee_BAL employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            /*  SqlCommand cmdInsert = new SqlCommand("insert into book(book_id,book_name,book_author) values(@book_id,@book_name,@book_author)", cn);
              cmdInsert.Parameters.AddWithValue("@book_id", employee.book_id);
              cmdInsert.Parameters.AddWithValue("@book_name", employee.book_name);
              cmdInsert.Parameters.AddWithValue("@book_author", employee.book_author); */

            SqlCommand cmdInserts = new SqlCommand("insert into member(member_id,member_name) values(@member_id,@member_name)", cn);
            cmdInserts.Parameters.AddWithValue("@member_id", employee.member_id);
            cmdInserts.Parameters.AddWithValue("@member_name", employee.member_name);


            cn.Open();
            int j = cmdInserts.ExecuteNonQuery();

            bool status = false;

            if (j == 1)
            {
                status = true;
            }

            cn.Close();//finally
            cn.Dispose();//finally
            return status;



        }
        public bool UpdateEmployee(Employee_BAL employee)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[UpdateEmployeeDetails]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_id1", employee.member_id);
            cmdUpdate.Parameters.AddWithValue("@p_name1", employee.member_name);
            cn.Open();
            int s = cmdUpdate.ExecuteNonQuery();
            bool statusd = false;
            if (s == 1)
            {
                statusd = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return statusd;

        }

    }
}
