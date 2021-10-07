using System.Linq;
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
            SqlArticleRepository repo = new SqlArticleRepository(context);
            ArticleController controller = new ArticleController(repo);
            Article article = controller.GetArticle(25);

            Assert.AreEqual("Title4", article.Title);
        }

        [Test]
        public void Get_ShouldReturnAllArticles()
        {
            using var context = new LocalNewsContext(ContextOptions);
            SqlArticleRepository repo = new SqlArticleRepository(context);
            ArticleController controller = new ArticleController(repo);
            var articles = controller.GetAllArticles().ToList();

            Assert.AreEqual(25, articles.Count);
        }

        [Test]
        public void Get_ShouldReturnCorrectArticles()
        {
            using var context = new LocalNewsContext(ContextOptions);
            SqlArticleRepository repo = new SqlArticleRepository(context);
            ArticleController controller = new ArticleController(repo);
            var articles = controller.GetAllArticles().ToList();

            Assert.AreEqual("Title4", articles[24].Title);
        }
    }
}
