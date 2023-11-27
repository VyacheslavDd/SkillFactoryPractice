using Microsoft.EntityFrameworkCore;
using MVCWebAppTest.Models.db;

namespace MVCWebAppTest.Repositories.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext context;

        public BlogRepository(BlogContext context)
        {
            this.context = context;
        }

        public async Task AddUser(User user)
        {
            user.Id = Guid.NewGuid();
            user.JoinDate = DateTime.Now;
            await context.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<List<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }
    }
}
