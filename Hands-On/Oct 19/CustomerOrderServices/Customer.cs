using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderServices
{
    public enum CustomerType
    {
        Basic, Premium, Gold
    }
    public class Customer
    {
        private string _custid;

		public string CustId
		{
			get { return _custid; }
			set { _custid = value; }
		}
		private string _custname;

		public string CustName
		{
			get { return _custname; }
			set { _custname = value; }
		}

        public CustomerType customerType { get; set; }
        public List<Customer> Customers { get; set; }
    }
	public class Order
	{
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int Qty { get; set; }
		public int Amount { get; set; }

	}
}
