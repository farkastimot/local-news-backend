﻿using LocalNewsApi.Models;
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
        public IEnumerable<Article> GetTop(string q, int category, int page, int amount)
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            //return articleContext.GetTopArticles(category, page, (amount==0?10:amount)).ToArray();
            return articleContext.GetArticles((q==null?"":q), category, page, true, (amount == 0 ? 10 : amount)).ToArray();
        }
    }
}
