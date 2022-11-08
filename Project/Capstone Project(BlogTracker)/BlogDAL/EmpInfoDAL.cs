using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class EmpInfoDAL
    {
        MyContext context = null;
        public EmpInfoDAL()
        {
            context = new MyContext();

        }
        public bool AddEmp(EmpInfo p)
        {
            try
            {
                context.EmpInfos.Add(p);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteEmployeeDetails(int id)
        {
            try
            {

                List<EmpInfo> s = context.EmpInfos.ToList();
                EmpInfo r = s.Find(pr => pr.Passcode == id);

                context.EmpInfos.Remove(r);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public EmpInfo GetEmployeeDetailsByPasscode(int id)
        {
            List<EmpInfo> s = context.EmpInfos.ToList();
            EmpInfo r = s.Find(pr => pr.Passcode == id);
            return r;
        }
        public List<EmpInfo> GetAllEmployeeDetails()
        {
            return context.EmpInfos.ToList();
        }
        public bool UpdateEmployeeDetails(int id, EmpInfo p)
        {
            try
            {

                List<EmpInfo> s = context.EmpInfos.ToList();
                EmpInfo k = s.Find(pr => pr.Passcode == id);

                k.EmailID = p.EmailID;
                k.Name = p.Name;
                k.DateOfJoining = p.DateOfJoining;
                k.Passcode = p.Passcode;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;


            }
        }

        public bool ValidateEmp(string email, int pass)
        {
            bool ans = false;
            var find = context.EmpInfos.ToList();
            foreach (var item in find)
            {
                if (item.EmailID == email && item.Passcode == pass)
                {
                    ans = true;
                }
            }
            return ans;
        }

    }
}
