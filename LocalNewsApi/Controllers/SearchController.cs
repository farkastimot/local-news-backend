using System.Collections.Generic;
using System.Linq;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : Controller
    {
        [HttpGet]
        public IEnumerable<Article> Search(string q, int category, int page, int amount)
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;
            return articleContext.Articles.Skip(page * amount).Take(amount).Where(x => x.Content.Contains(q) && x.Category == category);
        }
    }
}
