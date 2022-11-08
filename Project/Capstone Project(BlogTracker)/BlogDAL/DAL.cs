using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class AdminInfo
    {
        [Required()]
        [Key]
        public string EmailID { get; set; }
        public string Password { get; set; }
    }
    public class EmpInfo
    {
        [Required()]
        [Key]
        public int Passcode { get; set; }
        public string EmailID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
    public class BlogInfo
    {
        [Required()]
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string BlogURL { get; set; }
        public string EmpEmailID { get; set; }
    }
    public class MyContext : DbContext
    {
        public virtual DbSet<AdminInfo> AdminInfos { get; set; }
        public virtual DbSet<EmpInfo> EmpInfos { get; set; }
        public virtual DbSet<BlogInfo> BlogInfos { get; set; }
    }
    public class AdminInfoDbInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            var depts = new List<AdminInfo> {
                new AdminInfo { EmailID = "sahid@gmail.com", Password = "12345"},
                new AdminInfo { EmailID = "admin@gmail.com", Password = "12345" },
                new AdminInfo { EmailID = "ramy@gmail.com", Password = "12345" },

            };
            depts.ForEach(s => context.AdminInfos.Add(s));
            context.SaveChanges();
        }
    }
}
