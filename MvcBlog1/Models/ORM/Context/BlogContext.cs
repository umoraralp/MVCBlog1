using MvcBlog1.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace MvcBlog1.Models.ORM.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext(){
            Database.Connection.ConnectionString = "Server=DESKTOP-D43EGO9;Database=OnlineBlog;Trusted_Connection=True;";


            
    }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<BlogPost> BlogPost { get;set; }
        public DbSet<SiteMenu> SiteMenu { get; set; }

        internal void SiteMenus()
        {
            throw new NotImplementedException();
        }
    }
}