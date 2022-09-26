using BusinessLogicLibrary;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class HelperClass
    {
        public List<BL_products> Get_products()
        {
            DAL_product pro = new DAL_product();
            List<BL_products> productsList = new List<BL_products>();
            productsList = pro.ShowAllproducts();
            return productsList;
        }
    }
}
