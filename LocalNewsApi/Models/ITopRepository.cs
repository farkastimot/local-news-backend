using System.Collections.Generic;

namespace LocalNewsApi.Models
{
    public interface ITopRepository
    {
        public IEnumerable<Article> GetTop(int? category, int? page, int? amount);
    }
}
