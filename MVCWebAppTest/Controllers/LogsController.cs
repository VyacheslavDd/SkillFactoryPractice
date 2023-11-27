using Microsoft.AspNetCore.Mvc;
using MVCWebAppTest.Repositories.RequestRepository;

namespace MVCWebAppTest.Controllers
{
    public class LogsController : Controller
    {
        private IRequestRepository requestRepository;

        public LogsController(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        public async Task<IActionResult> Index()
        {
            var logs = await requestRepository.GetAllRequests();
            logs = logs.OrderBy(x => x.Date).ToList();
            return View(logs);
        }
    }
}
