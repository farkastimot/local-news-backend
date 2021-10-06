using System.Collections.Generic;
using System.Linq;
using LocalNewsApi.Data;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly LocalNewsContext _context;

        public CategoriesController(LocalNewsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Article> GetByID(int id)
        {
            return _context.Articles.Where(x => x.Category == id);
        }
    }
}
