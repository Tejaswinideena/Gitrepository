using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class BlogInfoDAL
    { 
    MyContext context = null;
    public BlogInfoDAL()
    {
        context = new MyContext();

    }
    public bool AddBlog(BlogInfo p)
    {
        try
        {
            context.BlogInfos.Add(p);
            context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool DeleteBlogDetails(int id)
    {
        try
        {

            List<BlogInfo> s = context.BlogInfos.ToList();
                BlogInfo r = s.Find(pr => pr.BlogID == id);

            context.BlogInfos.Remove(r);
            context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public BlogInfo GetAllBlogDetailsByBlogID(int id)
    {
        List<BlogInfo> s = context.BlogInfos.ToList();
        BlogInfo r = s.Find(pr => pr.BlogID == id);
        return r;
    }
    public List<BlogInfo> GetAllBlogDetails()
    {
        return context.BlogInfos.ToList();
    }
    public bool UpdateBlogDetails(int id, BlogInfo p)
    {
        try
        {

            List<BlogInfo> s = context.BlogInfos.ToList();
                BlogInfo k = s.Find(pr => pr.BlogID == id);

            k.BlogID = p.BlogID;
            k.Title = p.Title;
            k.Subject = p.Subject;
            k.DateOfCreation = p.DateOfCreation;
            k.BlogURL = p.BlogURL;
            k.EmpEmailID = p.EmpEmailID;
            context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;


        }
    }
}
}
