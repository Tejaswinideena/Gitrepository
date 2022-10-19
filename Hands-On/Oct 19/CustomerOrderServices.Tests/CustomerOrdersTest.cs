using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderServices;
using NUnit.Framework;


namespace CustomerOrderServices.Tests
{
    [TestFixture]
    public class CustomerOrdersTest
    {
        [TestCase]
        public void When_Premium_10percent()
        {
            Customer c = new Customer();
            c.CustId = "raj";
            c.CustName = "abc";
            c.customerType = CustomerType.Premium;
            Order order = new Order();
            order.OrderId = 1;
            order.Qty = 50;
            order.Amount = 100;
            order.ProductId = 11;
            CustomerOrder c1 = new CustomerOrder();
            c1.Discount(c, order);
            Assert.AreEqual(order.Amount, 90);
        }

        [TestCase]

        public void When_Gold_20percent()
        {
            Customer c = new Customer();
            c.CustId = "ram";
            c.CustName = "abcd";
            c.customerType = CustomerType.Gold;
            Order order = new Order();
            order.OrderId = 2;
            order.Qty = 20;
            order.Amount = 100;
            order.ProductId = 12;
            CustomerOrder c1 = new CustomerOrder();
            c1.Discount(c, order);
            Assert.AreEqual(order.Amount, 80);
        }
        [TestCase]
        public void FetchList()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();

            customerOrder.GetCustomersList(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { CustId = "rani", CustName = "sk" });
            custList1.Add(new Customer() { CustId = "vani", CustName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }
    }
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");
            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }
    [TestFixture]
    public class Test1
    {
        int s;
        [SetUp]
        public void Add()
        {
            int x = 10;
            int y = 20;
            s = x + y;
            Console.WriteLine(s);
        }
       [Test]
        public void Subtract()
        {

            int p = s - 10;
            Console.WriteLine(p);
            Assert.AreEqual(p, 20);
        }
        [Test]
        [TearDown]
        public void Multiply()
        {
            int x = 100;
            int y = 20;
            int result = x * y;
            Console.WriteLine(result);
            Assert.AreEqual(result, 30);
        }
    }
} 

