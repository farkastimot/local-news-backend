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
    public class TopController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Article> GetTop(int category, int page)
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetTopArticles(category, page).ToArray();
        }
    }
}
