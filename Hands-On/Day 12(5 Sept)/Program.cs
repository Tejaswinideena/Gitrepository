using System;
using System.Collections.Generic;
using ClassLibrary;

namespace Day12
{
    public class BookProgram
    {
        public static void Main(string[] args)
        {
           
            Cart c=new Cart();
            c.GetData();
            c.GetData();
            List<Book> booklist = new List<Book>();
            booklist = c.BookList();

            foreach (var i in booklist)
            {
                Console.WriteLine("Book ID: " + i.BookId);
                Console.WriteLine("Book Name: " + i.BookName);
                Console.WriteLine("Book Price: " + i.BookPrice);
                c.BookCount();
            }
            
            Console.ReadLine();
        }
    }
    
}
