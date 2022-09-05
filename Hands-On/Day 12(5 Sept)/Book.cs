using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {
		private int _bookid;

		public int BookId
		{
			get { return _bookid; }
			set { _bookid = value; }
		}
		private string _bookname;

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}

		private int _price;

		public int BookPrice
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string BookAuthor
		{
			get { return _author; }
			set { _author = value; }
		}

		private int _noOfpages;

		public int NumberOfPages
		{
			get { return _noOfpages; }
			set { _noOfpages = value; }
		}

		public Book()
		{

		}
		public Book(int id)
		{ 
			_bookid = id;
		}

		public virtual void InsertBook(int bookid,string bookname,int bookprice)
		{
			this.BookId = bookid;
			this.BookName = bookname;
			this.BookPrice = bookprice;
		}
        public void InsertBook(int bookid, string bookname, int bookprice,string author)
        {
            this.BookId = bookid;
            this.BookName = bookname;
            this.BookPrice = bookprice;
			this.BookAuthor = author;
        }
        public void InsertBook(int bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;
        }

        public class Novels : Book
        {
            public void InsertBook(int bookid, string bookname, int bookprice, int numberofpages)
            {
                this.BookId = bookid;
                this.BookName = bookname;
                this.BookPrice = bookprice;
                this.NumberOfPages = numberofpages;
            }
            public override void InsertBook(int bookid, string bookname, int bookprice)
            {
                this.BookId = bookid;
                this.BookName = bookname;
                this.BookPrice = bookprice;
            }
        }
        

    }
}
