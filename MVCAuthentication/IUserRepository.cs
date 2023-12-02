using MVCAuthentication.Models;

namespace MVCAuthentication
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetByLogin(string login);

        Task<Role> FindRoleById(int id);

        Task<IEnumerable<Role>> GetAllRoles();
    }
}
