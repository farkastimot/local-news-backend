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
        private readonly LocalNewsContext _context;

        public TopController(LocalNewsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Article> GetTop(int? category, int? page, int? amount)
        {
            if (page == null) page = 0;
            if (amount == null) amount = 10;
            return _context.Articles.Where(x => x.Category == category).Skip((int)page * (int)amount).Take((int)amount);
        }
    }
}
