using System.Linq;
using LocalNewsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalNewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repo;

        public CategoriesController(ICategoryRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IQueryable<Category> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id:int}")]
        public IQueryable<Article> GetByID(int id)
        {
            return _repo.GetByID(id);
        }
    }
}
