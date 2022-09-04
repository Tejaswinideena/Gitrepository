using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Categories
    {
		static int prodcount;

		private int _catid;

		public int CategoryId
		{
			get { return _catid; }
			set { _catid = value; }
		}
		private string _catname;

		public string CategoryName
		{
			get { return _catname; }
			set { _catname = value; }
		}
		private string _description;
		public string Description
		{
			get { return _description; }
			set { _description= value; }
		}
        private List<Products> _prodlist;

        public List<Products> ProductsList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }
		
		public  void ProductCount()
		{
			prodcount = prodcount + 1;
			Console.WriteLine("Count of Products: "+prodcount);
		}
        public void AddCategory(int _catid, string _catname, string _desc)
        {
            this.CategoryId = _catid;
            this.CategoryName = _catname;
            this.Description = _desc;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Category ID: " + CategoryId);
            Console.WriteLine("Category Name: " + CategoryName);
            Console.WriteLine("Description: " + Description);

            foreach (var i in ProductsList)
            {
                Console.WriteLine("Product ID: " + i.ProductId);
                Console.WriteLine("Product Name: " + i.ProductName);
            }
        }
    }
}
