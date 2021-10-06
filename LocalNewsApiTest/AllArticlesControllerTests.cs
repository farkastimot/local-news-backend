using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LocalNewsApi.Controllers;
using LocalNewsApi.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LocalNewsApiTest
{
    public class AllArticlesControllerTests : BaseTest
    {
        public AllArticlesControllerTests()
            : base(
                  new DbContextOptionsBuilder<LocalNewsContext>()
                    .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=LocalNewsTest;Trusted_Connection=true")
                    .Options)
                  { }

        [Test]
        public void Get_ShouldReturnAllArticles()
        {
            using var context = new LocalNewsContext(ContextOptions);
            var controller = new AllArticlesController(context);
            var articles = controller.Get().ToList();

            Assert.AreEqual(25, articles.Count);
        }

        [Test]
        public void Get_ShouldReturnCorrectArticles()
        {
            using var context = new LocalNewsContext(ContextOptions);
            var controller = new AllArticlesController(context);
            var articles = controller.Get().ToList();

            Assert.AreEqual("Title4", articles[24].Title);
        }
    }
}
