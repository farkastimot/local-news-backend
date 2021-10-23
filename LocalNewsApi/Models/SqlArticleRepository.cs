using System.Linq;
using LocalNewsApi.Data;

namespace LocalNewsApi.Models
{
    public class SqlArticleRepository : IArticleRepository
    {
        private readonly LocalNewsContext _context;

        public SqlArticleRepository(LocalNewsContext context)
        {
            _context = context;
        }

        public IQueryable<Article> GetAllArticles()
        {
            return _context.Articles;
        }

        public Article GetArticle(int id)
        {
            return _context.Articles.Find(id);
        }
    }
}
