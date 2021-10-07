using System.Collections.Generic;

namespace LocalNewsApi.Models
{
    public interface ISearchRepository
    {
        public IEnumerable<Article> Search(string q, int? page, int? amount);
    }
}
