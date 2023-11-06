
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        private UserService userService;
        private Logger logger;

        public RegistrationView(UserService service)
        {
            userService = service;
            logger = Logger.GetLogger();
        }

        private UserRegistrationData InputRegistrationData()
        {
            var firstName = Helper.InputField("Введите имя: ");
            var lastName = Helper.InputField("Введите фамилию: ");
            var email = Helper.InputField("Введите E-mail: ");
            var password = Helper.InputField("Введите пароль: ");

            return new UserRegistrationData()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
        }

        public void ProcessRegistration(int choice)
        {
            if (choice == 1)
            {
                var userData = InputRegistrationData();
                userService.Register(userData);
                logger.SuccessOutput("Регистрация прошла успешно!");
            }
        }
    }
}
