using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BlogDAL
{
    public class ValidateAdmin
    {
        MyContext context = null;
        public ValidateAdmin()
        {
            context = new MyContext();
        }
        public bool Validate(string email, string pass)
        {
            bool ans = false;
            var find = context.AdminInfos.ToList();
            foreach (var item in find)
            {
                if(item.EmailID == email && item.Password == pass)
                {
                    ans = true;
                }
            }
            return ans;
        }
    }
}
