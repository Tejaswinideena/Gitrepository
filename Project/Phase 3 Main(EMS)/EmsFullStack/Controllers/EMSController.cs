using bal;
using Dal;
using EmsFullStack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmsFullStack.Controllers
{
    public class EMSController : ApiController
    {
        DAL obj = null;
        public EMSController()
        {
            obj = new DAL();
        }

       
        [HttpGet]
        public List<empmodel> Get()
        {
           

            List<EmpProfiles> empbal = new List<EmpProfiles>(); empbal = obj.GetCustomers();
            List<empmodel> emps = new List<empmodel>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new empmodel
                {
                    EmpCode = item.EmpCode,
                    Email = item.Email,
                    EmpName = item.EmpName,
                    //    DateOfBirth = item.DateOfBirth,
                    DeptCode = item.DeptCode
                });
            }
            return emps;

        }

       
        

       
        public void Post([FromBody] empmodel empdata)
        {
            EmpProfiles empbal = new EmpProfiles();
            empbal.EmpCode = empdata.EmpCode;
            empbal.Email = empdata.Email;
            empbal.EmpName = empdata.EmpName;
            empbal.DeptCode = empdata.DeptCode;



            obj.Insertcustomer(empbal);


        }

       
        [HttpPut]
        public void Put([FromBody] empmodel empdata)
        {

            EmpProfiles empbal = new EmpProfiles();
            empbal.EmpCode = empdata.EmpCode;
            empbal.Email = empdata.Email;
            empbal.EmpName = empdata.EmpName;
            empbal.DeptCode = empdata.DeptCode;

            obj.UpdateCustomer(empbal);

        }


        
        public void Delete(int id)
        {

            obj.Remove(id);


        }
        //[Route("FindById/{id:int?}")]
        public empmodel Get(int id)
        {
            EmpProfiles empbal = new EmpProfiles();
            empbal = obj.search(id);
            empmodel emp = new empmodel();

            emp.EmpCode = id;
            emp.EmpName = empbal.EmpName;
            emp.Email = empbal.Email;
            emp.DeptCode = empbal.DeptCode;


            return emp;

        }



    }
}

