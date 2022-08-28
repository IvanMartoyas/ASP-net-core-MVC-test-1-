using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace test_1.Domains
{
    public class AddDbContext : IdentityDbContext<IdentityUser>
    {
        public AddDbContext(DbContextOptions options) : base (options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // вносит первую статью в БД, чтоб при первом создании база была не пустая
            builder.Entity<Article>().HasData(new Article
            {
                Id = new Guid("84912384-4324823-4234-23423"),
                Title = "hellow rold",
                Text = "text text"
            });

        }
    }
}
