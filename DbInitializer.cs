using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebsite_BL.Entities;

namespace MyWebsite_DAL
{
    internal class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    BlogId = 1,
                    Url = "http://blogs.packtpub.com/dotnet"
                }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 2,
                    Title = "Test",
                    Content = "lorem ipsum",
                    BlogId = 1

                }

                );
        }
    }
}
