using Microsoft.EntityFrameworkCore;
using MVCWebAppTest.Models.db;

namespace MVCWebAppTest
{
    public class RequestContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }

        public RequestContext(DbContextOptions<RequestContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
