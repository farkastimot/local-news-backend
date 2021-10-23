using System.Linq;

namespace LocalNewsApi.Models
{
    public interface ISearchRepository
    {
        public IQueryable<Article> Search(string q, int? page, int? amount);
    }
}
