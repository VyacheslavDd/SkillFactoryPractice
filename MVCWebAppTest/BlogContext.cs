using Microsoft.EntityFrameworkCore;
using MVCWebAppTest.Models.db;

namespace MVCWebAppTest
{
    public class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> Posts { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
