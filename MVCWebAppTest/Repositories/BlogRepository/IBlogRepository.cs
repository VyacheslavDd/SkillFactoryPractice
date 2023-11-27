using MVCWebAppTest.Models.db;

namespace MVCWebAppTest.Repositories.BlogRepository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<List<User>> GetUsers();
    }
}
