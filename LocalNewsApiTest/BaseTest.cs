using System;
using LocalNewsApi;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalNewsApiTest
{
    public class BaseTest
    {

        public DbContextOptions<LocalNewsContext> ContextOptions { get; private set; }

        public BaseTest(DbContextOptions<LocalNewsContext> contextOptions)
        {
            ContextOptions = contextOptions;

            Seed();
        }

        private void Seed()
        {
            using (var context = new LocalNewsContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var article1 = new Article { Title = "Title1", Author = "Author1", Category = 1, Content = "Content1", Description = "Description1", PublishedAt = DateTime.Now, UrlToImage = "Image1" };
                var article2 = new Article { Title = "Title2", Author = "Author2", Category = 2, Content = "Content2", Description = "Description2", PublishedAt = DateTime.Now, UrlToImage = "Image2" };
                var article3 = new Article { Title = "Title3", Author = "Author3", Category = 3, Content = "Content3", Description = "Description3", PublishedAt = DateTime.Now, UrlToImage = "Image3" };
                var article4 = new Article { Title = "Title4", Author = "Author4", Category = 4, Content = "Content4", Description = "Description4", PublishedAt = DateTime.Now, UrlToImage = "Image4" };
                var category1 = new Category { Name = "Category1" };
                var category2 = new Category { Name = "Category2" };
                context.AddRange(article1, article2, article3, article4, category1, category2);
                context.SaveChanges();
            }
        }
    }
}