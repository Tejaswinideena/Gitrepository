using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    public class Products
    {
        private int id;

        public int Pid
        {
            get { return id; }
            set { id = value; }
        }
        private string pname;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}