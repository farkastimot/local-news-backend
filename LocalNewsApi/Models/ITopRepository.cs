using System.Linq;

namespace LocalNewsApi.Models
{
    public interface ITopRepository
    {
        public IQueryable<Article> GetTop(int? category, int? page, int? amount);
    }
}
