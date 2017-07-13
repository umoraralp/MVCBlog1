using MvcBlog1.Areas.Admin.Models.Attributes;
using MvcBlog1.Models.ORM.Context;
using MvcBlog1.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog1.Areas.Admin.Controllers
{
    [LoginControl]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //kullanıcı ad ve soyadı login olduktan sonra aldğımız mail ile yakaladık

            //BlogContext db = new BlogContext();
            //string email = HttpContext.User.Identity.Name;
            //AdminUser adminuser = db.AdminUsers.FirstOrDefault(x=>x.Email==email);
            //string name = adminuser.Name;
            //string surname = adminuser.Surname;

            return View();
        }
	}
}