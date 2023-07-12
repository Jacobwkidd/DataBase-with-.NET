using Microsoft.EntityFrameworkCore;
using WebsiteBlogs.Models;

namespace WebsiteBlogs.Data;

public class ApplicationDbContext : DbContext
{
    /*************************************
			TODO:
			Define which tables should be created off of which models.
			Remember that you DO NOT need to define junction tables here.

		*************************************/

        public DbSet<User> Users{get;set;}
        public DbSet<Blog> Blogs{get;set;}
        public DbSet<Comment> Comments{get;set;}
        public DbSet<Post> Posts{get;set;}
        public DbSet<Tag> Tags{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=websiteblogs.db");
}