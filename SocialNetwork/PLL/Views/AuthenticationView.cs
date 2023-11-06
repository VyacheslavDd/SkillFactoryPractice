
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        private UserService userService;
        private Logger logger;

        public AuthenticationView(UserService service)
        {
            userService = service;
            logger = Logger.GetLogger();
        }

        private UserAuthenticationData InputAuthenticationData()
        {
            var email = Helper.InputField("Введите E-mail: ");
            var password = Helper.InputField("Введите пароль: ");

            return new UserAuthenticationData()
            {
                Email = email,
                Password = password
            };
        }

        public User ProcessAuthentication()
        {
            var authenticationData = InputAuthenticationData();
            var user = userService.Authenticate(authenticationData);
            logger.SuccessOutput($"Авторизация прошла успешно! Добро пожаловать, {user.FirstName}");
            return user;
        }
    }
}
