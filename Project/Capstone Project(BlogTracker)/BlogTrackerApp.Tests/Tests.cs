using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDAL;
using NUnit.Framework;

namespace BlogTrackerApp.Tests
{
    public class Tests
    {
        ValidateAdmin v = null;
        public Tests()
        {
            v = new ValidateAdmin();
        }
        [TestCase("admin@gmail.com","12345",ExpectedResult = true)]
        [TestCase("nancy@gmail.com", "123", ExpectedResult = false)]
        public bool Validate(string email,string pass)
        {
            return v.Validate(email, pass);
        }

    }
}
