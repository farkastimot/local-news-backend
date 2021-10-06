using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly LocalNewsContext _context;

        public ArticleController(LocalNewsContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public Article GetArticle(int id)
        {
            return _context.Articles.Find(id);
        }
    }
}
