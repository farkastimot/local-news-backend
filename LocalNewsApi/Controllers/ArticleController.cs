﻿using System.Collections.Generic;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IEnumerable<Article> GetArticle(int id)
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;

            return (IEnumerable<Article>)articleContext.Articles.Find(id);
        }
    }
}
