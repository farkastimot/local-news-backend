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
        public IEnumerable<Article> Search(string q, int? page, int? amount)
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;
            if (page == null) page = 0;
            if (amount == null) amount = 10;
            if (q == null) q = "";
            return articleContext.Articles.Skip((int)page * (int)amount).Take((int)amount).Where(x => x.Content.Contains(q));
        }
    }
}
