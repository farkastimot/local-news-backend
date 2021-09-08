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
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetAllArticles().ToArray();
        }
    }
}
