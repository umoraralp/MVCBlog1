using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog1.Models.ORM.Entity
{
    public class SiteMenu:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string cssClass { get; set; }
    }
}