using Microsoft.EntityFrameworkCore;
using MVCAuthentication.Models;

namespace MVCAuthentication
{
    public class UserRepository : IUserRepository
    {
        private UserContext context;

        public UserRepository(UserContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User?> GetByLogin(string login)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Login == login);
        }

        public async Task<Role?> FindRoleById(int id)
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await context.Roles.ToListAsync();
        }
    }
}
