using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Oct_7.Controllers
{
    public class BookOperation
    {
        public void Delete(int bookid)
        {

            MyContext1 context = new MyContext1();

            // context.Procedure(bookid);
            context.SaveChanges();
        }



        public void InsertBook(BLClass1 bal)
        {
            MyContext1 context = new MyContext1();

            Book b = new Book();
            b.BookID = bal.Bookid;
            b.Bookname = bal.BookName;
            b.cost = bal.cost;
            b.Author = bal.Author;
            context.BookTable.Add(b);
            context.SaveChanges();

        }

        public void UpdateBook(BLClass1 bal)
        {
            MyContext1 context = new MyContext1();
            List<Book> customers = context.BookTable.ToList();
            Book obj = customers.Find(cust => cust.BookID == bal.Bookid);
            obj.Bookname = bal.BookName;
            obj.cost = bal.cost;

            // context.Updatebookdetails();
            context.SaveChanges();

        }

        public void Bookcount()
        {
            MyContext1 context = new MyContext1();

            Console.WriteLine("Book count : " + context.BookTable.Count());
        }
        public List<BLClass1> GetAllBooks()
        {
            MyContext1 context = new MyContext1();

            List<Book> clist = context.BookTable.ToList();
            List<BLClass1> cblist = new List<BLClass1>();
            foreach (var item in clist)
            {
                cblist.Add(new BLClass1 { Bookid = item.BookID, BookName = item.Bookname, cost = (int)item.cost, Author = item.Author });



            }
            return cblist;
        }
        public  BookOperation()
        {
            
        }
    }
    public class BLClass1
    {
        public int Bookid { get; set; }
        public string BookName { get; set; }
        public int cost { get; set; }
        public string Author { get; set; }
        public int memberid { get; set; }
    }
    public class Book
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string Bookname { get; set; }

        public string Author { get; set; }
        //1 Book---M Enrollments(members)
        public virtual ICollection<Issue> Issues { get; set; }
        //  [DataType(DataType.DateTime,ErrorMessage ="not valid date")]
        public float cost { get; set; }

    }

    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        public string MemberName { get; set; }

        //[Range(10000, 200000, ErrorMessage = "not in range")]
        public int Age { get; set; }
        //1 course---- M enrollments
        public virtual ICollection<Issue> Issues { get; set; }

    }

    public class Issue
    {
        [Key]
        public int IssueID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }

        [ForeignKey("BookID")]
        public virtual Book bookdetails { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member mem_details { get; set; }
    }

    public class MyContext1 : DbContext
    {
        public MyContext1() : base("MyContext1")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext1>(new CreateDatabaseIfNotExists<MyContext1>());
        }

        public virtual DbSet<Book> BookTable { get; set; }
        public virtual DbSet<Member> MemberTable { get; set; }
        public virtual DbSet<Issue> IssueTable { get; set; }

    }
}