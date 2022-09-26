using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class BL_products
    {
        private int product_id;
        public int ProductId
        {
            get { return product_id; }
            set { product_id = value; }
        }
        private string product_name;
        public string Product_Name
        {
            get { return product_name; }
            set
            {
                if (value.Length < 45)
                {
                    product_name = value;
                }
                else
                {
                    throw new Exception("product name is not valid");
                }
            }
        }
        private int _supplierids;
        public int SupplierIds
        {
            get
            { return _supplierids; }
            set { _supplierids = value; }
        }
        private int _Categoryid;
        public int Categoryid
        {
            get { return _Categoryid; }
            set { _Categoryid = value; }
        }
        private string quantity;
        public string QuantityPerunits
        {
            get { return quantity; }
            set
            {
                if (value.Length < 30)
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception("Quantity is not valid");
                }
            }

        }
        public Double Unitcost
        {
            get;
            set;
        }
        public int Unitsonorders
        {
            get;
            set;
        }
        public int ReorderLevel
        {
            get;
            set;
        }
        public Boolean Discontinued
        {
            get;
            set;
        }

    }
}
