using System.Linq;
using LocalNewsApi.Controllers;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LocalNewsApiTest
{
    class TopControllerTests : BaseTest
    {
        public TopControllerTests()
            : base(
                  new DbContextOptionsBuilder<LocalNewsContext>()
                    .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=LocalNewsTest;Trusted_Connection=true")
                    .Options)
        { }

        [Test]
        public void GetTop_ShouldReturnAllArticles()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlTopRepository repo = new SqlTopRepository(context);
            var controller = new TopController(repo);
            var articles = controller.GetTop(7, null, null).ToList();

            Assert.AreEqual(1, articles.Count);
        }

        [Test]
        public void GetTop_ShouldReturnCorrectArticles()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlTopRepository repo = new SqlTopRepository(context);
            var controller = new TopController(repo);
            var articles = controller.GetTop(7, null, null).ToList();

            Assert.AreEqual("Title4", articles[0].Title);
        }


    }
}
