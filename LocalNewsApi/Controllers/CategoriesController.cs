using LocalNewsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetCategories().ToArray();
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Category> GetByID(int id)
        {
            DatabaseContext articleContext = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;

            return articleContext.GetCategories(id).ToArray();
        }
    }
}
