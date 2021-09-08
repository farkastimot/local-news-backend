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
    public class SearchController : Controller
    {
        [HttpGet]
        public IEnumerable<Article> Search(string q, int category, int page, int amount)
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetArticles((q == null ? "" : q), category, page, false, (amount == 0 ? 10 : amount)).ToArray();
        }
    }
}
