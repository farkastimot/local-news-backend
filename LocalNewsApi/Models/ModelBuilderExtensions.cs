using Microsoft.EntityFrameworkCore;

namespace LocalNewsApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        Id = 1,
                        Name = "ModelBuilderTest"
                    }
                );
        }
    }
}
