using System.Linq;
using LocalNewsApi.Controllers;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LocalNewsApiTest
{
    class SearchControllerTests : BaseTest
    {
        public SearchControllerTests()
            : base(
                  new DbContextOptionsBuilder<LocalNewsContext>()
                    .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=LocalNewsTest;Trusted_Connection=true")
                    .Options)
        { }

        [Test]
        public void Search_ShouldReturnAllArticles()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlSearchRepository repo = new SqlSearchRepository(context);
            var controller = new SearchController(repo);
            var articles = controller.Search("Civ", null, null).ToList();

            Assert.AreEqual(1, articles.Count);
        }

        [Test]
        public void Search_ShouldReturnCorrectArticles()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            SqlSearchRepository repo = new SqlSearchRepository(context);
            var controller = new SearchController(repo);
            var articles = controller.Search("Civ", null, null).ToList();

            Assert.AreEqual("Magyar György: Karácsony és Márki-Zay nem írhatja át a játékszabályokat - Index.hu", articles[0].Title);
        }


    }
}
