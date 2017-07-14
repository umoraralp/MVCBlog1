using MvcBlog1.Areas.Admin.Models.DTO;
using MvcBlog1.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog1.Areas.Admin.Controllers
{
    public class SiteMenuController : BaseController
    {
        //
        // GET: /Admin/SiteMenu/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSiteMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSiteMenu(SiteMenuVM model) {
            SiteMenu sitemenu = new SiteMenu();
            sitemenu.Name = model.Name;
            sitemenu.Url = model.Url;
            sitemenu.cssClass = model.cssClass;

            db.SiteMenu.Add(sitemenu);
            db.SaveChanges();

            ViewBag.IslemDurum = 1;

            return View();
        }

        public ActionResult AddSiteMenuwithJSON() {
            
            return View();
        }

        public JsonResult AddSiteMenuJSON(SiteMenuVM model)
        {
            SiteMenu sitemenu = new SiteMenu();
            sitemenu.Name = model.Name;
            sitemenu.Url = model.Url;
            sitemenu.cssClass = model.cssClass;

            db.SiteMenu.Add(sitemenu);
            db.SaveChanges();

            return Json("");
        }
	}
}