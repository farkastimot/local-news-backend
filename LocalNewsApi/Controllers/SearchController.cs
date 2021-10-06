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
        private readonly LocalNewsContext _context;

        public SearchController(LocalNewsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Article> Search(string q, int? page, int? amount)
        {
            if (page == null) page = 0;
            if (amount == null) amount = 10;
            if (q == null) q = "";
            return _context.Articles.Skip((int)page * (int)amount).Take((int)amount).Where(x => x.Content.Contains(q));
        }
    }
}
