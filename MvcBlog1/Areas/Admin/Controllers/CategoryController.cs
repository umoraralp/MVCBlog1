using MvcBlog1.Areas.Admin.Models.DTO;
using MvcBlog1.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog1.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = model.Name;
                category.Description = model.Description;

                db.Categories.Add(category);
                db.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View();
                
            }
            else
            {
                ViewBag.Islemdurum = 2;
                return View();
            }
        }
	}
}