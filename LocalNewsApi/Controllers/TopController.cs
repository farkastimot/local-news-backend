using System.Collections.Generic;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopController : ControllerBase
    {
        private readonly ITopRepository _repo;

        public TopController(ITopRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Article> GetTop(int? category, int? page, int? amount)
        {
            return _repo.GetTop(category, page, amount);
        }
    }
}
