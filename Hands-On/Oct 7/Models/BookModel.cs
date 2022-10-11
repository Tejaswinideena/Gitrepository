using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oct_7.Models
{
    public class BookModel
    {
        public int Bookid { get; set; }
        public string BookName { get; set; }
        public int cost { get; set; }
        public string Author { get; set; }
        public int memberid { get; set; }
    }
}