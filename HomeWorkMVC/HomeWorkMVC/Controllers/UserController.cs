using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWorkMVC.Models;
using HomeWorkMVC.Models.ViewModels;

namespace HomeWorkMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LogonViewModel pageData)
        {
            if (pageData.Account == "ruby.lin@iisigroup.com" && pageData.Password == "tree")
            {
                pageData.Message = $"您使用{pageData.Account}登入成功。";

            }
            return View(pageData);
        }
    }
}