using System.Linq;
using LocalNewsApi.Data;

namespace LocalNewsApi.Models
{
    public class SqlTopRepository : ITopRepository
    {
        private readonly LocalNewsContext _context;

        public SqlTopRepository(LocalNewsContext context)
        {
            _context = context;
        }
        public IQueryable<Article> GetTop(int? category, int? page, int? amount)
        {
            if (page == null) page = 0;
            if (amount == null) amount = 10;
            return _context.Articles.Where(x => x.Category == category).Skip((int)page * (int)amount).Take((int)amount);
        }
    }
}
