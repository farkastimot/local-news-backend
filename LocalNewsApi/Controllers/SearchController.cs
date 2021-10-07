﻿using System.Collections.Generic;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : Controller
    {
        private readonly ISearchRepository _repo;

        public SearchController(ISearchRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Article> Search(string q, int? page, int? amount)
        {
            return _repo.Search(q, page, amount);
        }
    }
}
