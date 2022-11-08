using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogDAL;
using BlogTrackerApp.Models;

namespace BlogTrackerApp.Controllers
{
    public class EmpAPIController : ApiController
    {
        // GET api/<controller>
        EmpInfoDAL ms = null;
        public EmpAPIController()
        {
            ms = new EmpInfoDAL();
        }
        List<EmpModel> s = new List<EmpModel>();
        [Route("GetAllEmployeeDetails")]
        public IEnumerable<EmpModel> Get()
        {
            List<EmpInfo> c = ms.GetAllEmployeeDetails();
            foreach (var item in c)
            {
                EmpModel v = new EmpModel();
                v.EmailID = item.EmailID;
                v.Name = item.Name;
                v.DateOfJoining = item.DateOfJoining;
                v.Passcode = item.Passcode;
                s.Add(v);
            }
            return s;
        }

        // GET api/<controller>/5
        [Route("GetEmployeeDetailsByPasscode/{id}")]
        public EmpModel Get(int id)
        {
            EmpModel r = new EmpModel();
            EmpInfo p = new EmpInfo();
            p = ms.GetEmployeeDetailsByPasscode(id);

            r.EmailID = p.EmailID.ToString();
            r.Name = p.Name.ToString();
            r.DateOfJoining = Convert.ToDateTime(p.DateOfJoining);
            r.Passcode = Convert.ToInt32(p.Passcode);

            return r;
        }

        // POST api/<controller>
        [Route("AddEmployeeDetails")]
        public HttpResponseMessage Post([FromBody] EmpModel value)
        {
            EmpInfo r = new EmpInfo();
            r.EmailID = value.EmailID;
            r.Name = value.Name;
            r.DateOfJoining = value.DateOfJoining;
            r.Passcode = value.Passcode;
            bool k = ms.AddEmp(r);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // PUT api/<controller>/5
        [Route("UpdateEmployeeDetails/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] EmpModel value)
        {
            EmpInfo r = new EmpInfo();
            r.EmailID = value.EmailID;
            r.Name = value.Name;
            r.DateOfJoining = value.DateOfJoining;
            r.Passcode = value.Passcode;

            bool k = ms.UpdateEmployeeDetails(id, r);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE api/<controller>/5
        [Route("DeleteEmployeeDetails/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool k = ms.DeleteEmployeeDetails(id);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}