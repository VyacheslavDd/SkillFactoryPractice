using Microsoft.AspNetCore.Mvc;
using MVCWebAppTest.Models.db;
using MVCWebAppTest.Repositories.BlogRepository;

namespace MVCWebAppTest.Controllers
{
    public class UsersController : Controller
    {
        private ILogger<UsersController> logger;
        private IBlogRepository blogRepository;

        public UsersController(ILogger<UsersController> logger, IBlogRepository blogRepository)
        {
            this.logger = logger;
            this.blogRepository = blogRepository;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User newUser)
        {
            await blogRepository.AddUser(newUser);
            return View(newUser);
        }
        //public async Task<IActionResult> RegSucceeded()
        //{
        //    if (Request.HasFormContentType)
        //    {
        //        var form = Request.Form;
        //        var firstName = form["FirstName"];
        //        var lastName = form["LastName"];
        //        if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
        //        {
        //            var user = new User() { FirstName = firstName, LastName = lastName };
        //            await blogRepository.AddUser(user);
        //        }
        //    }
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var authors = await blogRepository.GetUsers();
            return View(authors);
        }
    }
}
