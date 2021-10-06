using System;
using System.Collections.Generic;
using System.Text;
using LocalNewsApi.Controllers;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LocalNewsApiTest
{
    class ArticleControllerTests : BaseTest
    {
        public ArticleControllerTests()
            : base(
                  new DbContextOptionsBuilder<LocalNewsContext>()
                    .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=LocalNewsTest;Trusted_Connection=true")
                    .Options)
                { }

        [Test]
        public void GetArticle_ShouldReturnCorrectArticle()
        {
            using LocalNewsContext context = new LocalNewsContext(ContextOptions);
            ArticleController controller = new ArticleController(context);
            Article article = controller.GetArticle(25);

            Assert.AreEqual("Title4", article.Title);
        }
    }
}
