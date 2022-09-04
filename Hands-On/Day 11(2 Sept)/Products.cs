using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Products
    {
		private int _prodid;

		public int ProductId
		{
			get { return _prodid; }
			set { _prodid = value; }
		}
		private string _prodname;

		public string ProductName
		{
			get { return _prodname; }
			set { _prodname = value; }
		}
		private int _qtysold;

		public int QuantitySold
		{
			get { return _qtysold; }
			set { _qtysold = value; }
		}
		private int _unitprice;

		public int UnitPrice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}
		private string _unitmeasure;

		public string UnitofMeasurement
		{
			get { return _unitmeasure; }
			set { _unitmeasure = value; }
		}
		private int _qtyinhand;

		public int QuantityInHand
		{
			get { return _qtyinhand; }
			set { _qtyinhand = value; }
		}
		private string _reorder;

		public string ReorderLevel
		{
			get { return _reorder; }
			set { _reorder = value; }
		}
        public void AddProduct(int _prodid, string _prodname)
        {
            this.ProductId = _prodid;
            this.ProductName = _prodname;
        }


    }
}
