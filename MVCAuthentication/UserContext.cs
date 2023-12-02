using Microsoft.EntityFrameworkCore;
using MVCAuthentication.Models;

namespace MVCAuthentication
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
