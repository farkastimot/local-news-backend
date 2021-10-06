using System.Collections.Generic;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllArticlesController : ControllerBase
    {
        private readonly LocalNewsContext _context;

        public AllArticlesController(LocalNewsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return _context.Articles;
        }
    }
}
