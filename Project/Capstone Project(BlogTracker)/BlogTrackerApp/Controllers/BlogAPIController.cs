using BlogDAL;
using BlogTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogTrackerApp.Controllers
{
    public class BlogAPIController : ApiController
    {
        // GET api/<controller>
        BlogInfoDAL ms = null;
        public BlogAPIController()
        {
            ms = new BlogInfoDAL();
        }
        List<BlogModel> s = new List<BlogModel>();
        [Route("GetAllBlogDetails")]
        public IEnumerable<BlogModel> Get()
        {
            List<BlogInfo> c = ms.GetAllBlogDetails();
            foreach (var item in c)
            {
                BlogModel v = new BlogModel();
                v.BlogID = item.BlogID;
                v.Title = item.Title;
                v.Subject = item.Subject;
                v.DateOfCreation = item.DateOfCreation;
                v.BlogURL = item.BlogURL;
                v.EmpEmailID = item.EmpEmailID;

                s.Add(v);
            }
            return s;
        }

        // GET api/<controller>/5
        [Route("GetAllBlogDetailsByBlogID/{id}")]
        public BlogModel Get(int id)
        {
            BlogModel r = new BlogModel();
            BlogInfo p = new BlogInfo();
            p = ms.GetAllBlogDetailsByBlogID(id);

            r.BlogID = Convert.ToInt32(p.BlogID);
            r.Title = p.Title.ToString();
            r.Subject = p.Subject.ToString();
            r.DateOfCreation= Convert.ToDateTime(p.DateOfCreation);
            r.BlogURL = p.BlogURL.ToString();
            r.EmpEmailID = p.EmpEmailID.ToString();

            return r;
        }

        // POST api/<controller>
        [Route("AddBlogDetails")]
        public HttpResponseMessage Post([FromBody] BlogModel value)
        {
            BlogInfo r = new BlogInfo();
            r.BlogID = value.BlogID;
            r.Title = value.Title;
            r.Subject = value.Subject;
            r.DateOfCreation = value.DateOfCreation;
            r.BlogURL = value.BlogURL;
            r.EmpEmailID = value.EmpEmailID;
            bool k = ms.AddBlog(r);
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
        [Route("UpdateBlogDetails/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] BlogModel value)
        {
            BlogInfo r = new BlogInfo();
            r.BlogID = value.BlogID;
            r.Title = value.Title;
            r.Subject = value.Subject;
            r.DateOfCreation = value.DateOfCreation;
            r.BlogURL = value.BlogURL;
            r.EmpEmailID = value.EmpEmailID;

            bool k = ms.UpdateBlogDetails(id, r);
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
        [Route("DeleteBlogDetails/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool k = ms.DeleteBlogDetails(id);
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