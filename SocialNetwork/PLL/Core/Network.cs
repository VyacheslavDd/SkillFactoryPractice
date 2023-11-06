using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Additional;
using SocialNetwork.PLL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Core
{
    public class Network
    {
        private static UserService userService;
        private Logger logger;
        private Profile profile;
        private RegistrationView regView;
        private AuthenticationView autView;

        public Network()
        {
            userService = new UserService();
            logger = Logger.GetLogger();
            regView = new RegistrationView(userService);
            autView = new AuthenticationView(userService);
        }

        private void Greeting()
        {
            Console.WriteLine("Добро пожаловать в социальную сеть SharpNetwork!");
            Console.WriteLine("Хотите зарегистрироваться (1) или войти? (2)");
        }

        public void Run()
        {
            try
            {
                userService = new UserService();
                Greeting();
                var choice = ChoiceGetter.GetChoice(1, 2, logger);
                regView.ProcessRegistration(choice);
                var user = autView.ProcessAuthentication();
                profile = new Profile(user, userService);
                profile.Run();
            }
            catch (Exception ex)
            {
                logger.ErrorOutput(ex.Message);
            }
        }
    }
}
