using System.Collections.Generic;

namespace LocalNewsApi.Models
{
    public interface IArticleRepository
    {
        public Article GetArticle(int Id);
        public IEnumerable<Article> GetAllArticles();
    }
}
