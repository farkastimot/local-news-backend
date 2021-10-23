using System.Linq;
using LocalNewsApi.Data;

namespace LocalNewsApi.Models
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly LocalNewsContext _context;

        public SqlCategoryRepository(LocalNewsContext context)
        {
            _context = context;
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories;
        }

        public IQueryable<Article> GetByID(int id)
        {
            return _context.Articles.Where(x => x.Category == id);
        }
    }
}
