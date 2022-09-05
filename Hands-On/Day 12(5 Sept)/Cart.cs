using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cart:Book
    {
		private int _custid;

		public int CustomerId
		{
			get { return _custid; }
			set { _custid = value; }
		}
		private int _bookingid;

		public int BookingID
		{
			get { return _bookingid; }
			set { _bookingid = value; }
		}

		static int bookcount;
        public void BookCount()
        {
            bookcount = bookcount + 1;
            Console.WriteLine("Count of Books in Cart: " + bookcount);
        }

        public void AddToCart(int custid,int bookid,int price)
		{
			this.CustomerId = custid;
			this.BookingID = bookid;
			this.BookPrice = price;
		}
       
        int _bid; 
        int _p;
        private string _bname;
        public static List<Book> blist = new List<Book>();
        public void InsertBook(Book bookdata)
        {
            blist.Add(bookdata);
            
        }
        public List<Book> BookList()
        {
            return blist;
        }
        public void DisplayBook()
        {
            _bid = base.BookId;
            _bname = base.BookName;
            _p = base.BookPrice;
            Console.WriteLine(_bid);
            Console.WriteLine(_bname);
            Console.WriteLine(_p);
        }
        public void GetData()
        {
            Book p = new Book();

            Console.WriteLine("Enter Book ID: ");
            p.BookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Name: ");
            p.BookName = Console.ReadLine();

            Console.WriteLine("Enter Book Price: ");
            p.BookPrice =Convert.ToInt32(Console.ReadLine());

            InsertBook(p);
            Console.WriteLine("Book added to cart");
        }
    }
}
