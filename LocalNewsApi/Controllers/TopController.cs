using System.Collections.Generic;
using System.Linq;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Article> GetTop(int category, int page, int amount)
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;

            return articleContext.Articles.Skip(page * amount).Take(amount).Where(x => x.Category == category);
        }
    }
}
