using System.Linq;
using LocalNewsApi.Controllers;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LocalNewsApiTest
{
    class CategoriesControllerTests : BaseTest
    {
        public CategoriesControllerTests()
            : base(
                  new DbContextOptionsBuilder<LocalNewsContext>()
                    .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=LocalNewsTest;Trusted_Connection=true")
                    .Options)
        { }

        [Test]
        public void GetAll_ShouldReturnAllCategories()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlCategoryRepository repo = new SqlCategoryRepository(context);
            var controller = new CategoriesController(repo);
            var categories = controller.GetAll().ToList();

            Assert.AreEqual(7, categories.Count);
        }

        [Test]
        public void GetAll_ShouldReturnCorrectCategories()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlCategoryRepository repo = new SqlCategoryRepository(context);
            var controller = new CategoriesController(repo);
            var categories = controller.GetAll().ToList();

            Assert.AreEqual("Category2", categories[6].Name);
        }

        [Test]
        public void GetByID_ShouldReturnAllArticlesByCategoryId()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlCategoryRepository repo = new SqlCategoryRepository(context);
            var controller = new CategoriesController(repo);
            var articles = controller.GetByID(7).ToList();

            Assert.AreEqual(1, articles.Count);
        }

        [Test]
        public void GetByID_ShouldReturnCorrectArticles()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlCategoryRepository repo = new SqlCategoryRepository(context);
            var controller = new CategoriesController(repo);
            var articles = controller.GetByID(7).ToList();

            Assert.AreEqual("Title4", articles[0].Title);
        }

    }
}
