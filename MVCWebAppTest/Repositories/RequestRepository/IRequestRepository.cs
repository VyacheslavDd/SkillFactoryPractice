using MVCWebAppTest.Models.db;

namespace MVCWebAppTest.Repositories.RequestRepository
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<List<Request>> GetAllRequests();
    }
}
