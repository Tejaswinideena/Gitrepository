using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using Dal;

namespace bal
{
    public class CustomerOperations
    {
        public List<book> GetCustomers()
        {
            NorthwindEntities1 context = new NorthwindEntities1();

            List<book> clist = context.books.ToList();
            List<book> cblists = new List<book>();
            foreach (var item in clist)
            {
                cblists.Add(new book { book_id = item.book_id, book_author = item.book_author, book_name = item.book_name });



            }
            return cblists;




        }
        public void Insertcustomer(book bal)
        {
            NorthwindEntities1 context = new NorthwindEntities1();
            book c = new book();
            c.book_id = bal.book_id;
            c.book_name = bal.book_name;
            c.book_author = bal.book_author;
            context.books.Add(c);
            context.SaveChanges();

        }
        public void UpdateCustomer(book bal)
        {
            NorthwindEntities1 context = new NorthwindEntities1();
            List<book> customers = context.books.ToList();
            book obj = customers.Find(cust => cust.book_id == bal.book_id);
            obj.book_name = bal.book_name;
            obj.book_author = bal.book_author;
            context.SaveChanges();

        }
        public void DeleteCustomer(int bookid)
        {

            NorthwindEntities1 context = new NorthwindEntities1();
            context.sp_DeleteEmployee(bookid);
            context.SaveChanges();
        }
        public void bookcounts()
        {
            NorthwindEntities1 context = new NorthwindEntities1();
            context.sp_callfun();



        }
    }
}