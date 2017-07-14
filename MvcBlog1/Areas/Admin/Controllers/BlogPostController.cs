using MvcBlog1.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog1.Areas.Admin.Controllers
{
    public class BlogPostController : BaseController
    {
        //
        // GET: /Admin/BlogPost/
        public ActionResult AddBlogPost()
        {
            BlogPostVM model = new BlogPostVM();
            model.drpCategories = db.Categories.Select(x => new SelectListItem()
            {
                Text=x.Name,
                Value=x.ID.ToString()
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model) {
            if (ModelState.IsValid)
            {
               
            }
            
            return View();
        }
	}
}