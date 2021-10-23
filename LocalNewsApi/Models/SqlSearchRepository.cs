using System.Collections.Generic;
using System.Linq;
using LocalNewsApi.Data;

namespace LocalNewsApi.Models
{
    public class SqlSearchRepository : ISearchRepository
    {
        private readonly LocalNewsContext _context;

        public SqlSearchRepository(LocalNewsContext context)
        {
            _context = context;
        }

        public IQueryable<Article> Search(string q, int? page, int? amount)
        {
            if (page == null) page = 0;
            if (amount == null) amount = 10;
            if (q == null) q = "";
            return _context.Articles.Skip((int)page * (int)amount).Take((int)amount).Where(x => x.Content.Contains(q));
        }
    }
}
