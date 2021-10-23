using System.Linq;

namespace LocalNewsApi.Models
{
    public interface ICategoryRepository
    {
        public IQueryable<Article> GetByID(int id);
        public IQueryable<Category> GetAll();
    }
}
