using MvcBlog1.Areas.Admin.Models.Attributes;
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
            List<CategoryVM> model = db.Categories.Where(x => x.IsDeleted == false).OrderBy(x =>
                x.AddDate).Select(x => new CategoryVM
                {
                    Name = x.Name,
                    Description = x.Description,
                    ID = x.ID
                }).ToList();

            return View(model);
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

        public JsonResult DeleteCategory(int id) {
            Category category = db.Categories.FirstOrDefault(x => x.ID==id);
            category.IsDeleted = true;
            category.DeleteDate = DateTime.Now;
            db.SaveChanges();

            return Json("");
        }

        public ActionResult UpdateCategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(x=>x.ID==id);
            CategoryVM model = new CategoryVM();
            model.Name = category.Name;
            model.Description = category.Description;
            return View(model);


        }
        [HttpPost]
        public ActionResult UpdateCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == model.ID);
                category.Name = model.Name;
                category.Description = model.Description;
                db.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.IslemDurum = 2;
                return View();
            }
           


        }
	}
}