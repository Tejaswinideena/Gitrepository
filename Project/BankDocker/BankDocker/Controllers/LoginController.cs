using Microsoft.AspNetCore.Mvc;
using BankDocker.Models;

namespace BankDocker.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<LoginModel> value()
        {
            var users = new List<LoginModel>
            {
                new LoginModel{username="user1",password="pass1"},
                new LoginModel{username="user2",password="pass2"},
            };
            return users;
        }

        [HttpPost]
        public IActionResult Verify(LoginModel users)
        {
            var u = value();

            var ue = u.Where(u => u.username.Equals(users.username));

            var up = ue.Where(p => p.password.Equals(users.password));

            if (up.Count() == 1)
            {
                ViewBag.message = "Login Success";
                return View("Dashboard");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Index");
            }
        }
    }
}