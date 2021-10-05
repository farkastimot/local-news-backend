using System.Collections.Generic;
using System.Linq;
using LocalNewsApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;

            return articleContext.Categories;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Category> GetByID(int id)
        {
            LocalNewsContext articleContext = HttpContext.RequestServices.GetService(typeof(LocalNewsContext)) as LocalNewsContext;

            return (IEnumerable<Category>)articleContext.Categories.Find(id);
        }
    }
}
