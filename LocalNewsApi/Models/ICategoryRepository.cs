using System.Collections.Generic;

namespace LocalNewsApi.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Article> GetByID(int id);
        public IEnumerable<Category> GetAll();
    }
}
