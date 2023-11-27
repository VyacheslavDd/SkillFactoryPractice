using Microsoft.EntityFrameworkCore;
using MVCWebAppTest.Models.db;

namespace MVCWebAppTest.Repositories.RequestRepository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly RequestContext context;

        public RequestRepository(RequestContext context)
        {
            this.context = context;
        }

        public async Task AddRequest(Request request)
        {
            await context.Requests.AddAsync(request);
            await context.SaveChangesAsync();
        }

        public async Task<List<Request>> GetAllRequests()
        {
            var result = await context.Requests.ToListAsync();
            return result;
        }
    }
}
