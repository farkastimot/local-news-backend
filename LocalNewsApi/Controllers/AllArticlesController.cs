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
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;

            return articleContext.Articles;
        }
    }
}
