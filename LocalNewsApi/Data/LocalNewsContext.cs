using LocalNewsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalNewsApi.Data
{
    public class LocalNewsContext : DbContext
    {
        public LocalNewsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
