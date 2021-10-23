using System.Linq;

namespace LocalNewsApi.Models
{
    public interface IArticleRepository
    {
        public Article GetArticle(int Id);
        public IQueryable<Article> GetAllArticles();
    }
}
