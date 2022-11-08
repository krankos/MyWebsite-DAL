using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebsite_BL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyWebsite_DAL
{
    internal class MyWebsiteContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionalBuilder)
        {
            optionalBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBIRM21;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();

        }


    }
}
