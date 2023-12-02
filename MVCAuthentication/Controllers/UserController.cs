using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCAuthentication.Models;
using System.Security.Authentication;
using System.Security.Claims;

namespace MVCAuthentication.Controllers
{
    [ExceptionHandler]
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private ILogger logger;
        private IUserRepository userRepo;

        public UserController(ILogger logger, IUserRepository userRepo)
        {
            this.logger = logger;
            this.userRepo = userRepo;
            logger.WriteEvent("Сообщение о событии");
            logger.WriteError("Сообщение об ошибке");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "unk",
                LastName = "w",
                Email = "email",
                Password = "none",
                Login = "xd"
            };
        }

        [Authorize(Roles ="Ad")]
        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "xd"
            };

            UserViewModel userViewModel = new UserViewModel(user);

            return userViewModel;
        }

        [HttpPost]
        [Route("authenticate")]
        public async Task<UserViewModel> Authenticate(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Логин или пароль не могут быть пустыми!");
            }
            var user = userRepo.GetByLogin(login).Result;
            if (user is null || user.Password != password) throw new AuthenticationException("Пользователя не существует или введён некорректный пароль!");

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login));
            claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, userRepo.FindRoleById(user.RoleId).Result.Name));

            var identity = new ClaimsIdentity(claims, "AppCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            return new UserViewModel(user);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
