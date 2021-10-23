using System.Linq;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _repo;

        public ArticleController(IArticleRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IQueryable<Article> GetAllArticles()
        {
            return _repo.GetAllArticles();
        }

        [HttpGet("{id:int}")]
        public Article GetArticle(int id)
        {
            return _repo.GetArticle(id);
        }
    }
}
