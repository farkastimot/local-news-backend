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
    public class ArticleController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IEnumerable<Article> GetArticle(int id)
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetSingleArticle(id).ToArray();
        }
    }
}
