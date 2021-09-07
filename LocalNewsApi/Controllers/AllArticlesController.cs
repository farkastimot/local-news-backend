using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllArticlesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            ArticleContext articleContext = HttpContext.RequestServices.GetService(typeof(ArticleContext)) as ArticleContext;

            return articleContext.GetAllArticles().ToArray();
        }
    }
}
