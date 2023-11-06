
using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Validators;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UpdateProfileView
    {
        private User user;
        private UserService userService;
        private Logger logger;
        private UserDataValidator validator;

        public UpdateProfileView(User user, UserService service)
        {
            this.user = user;
            userService = service;
            logger = Logger.GetLogger();
            validator = UserDataValidator.GetValidator();
        }

        public void ChangeProfileData()
        {
            try
            {
                var firstName = Helper.InputField("Введите новое имя: ");
                var lastName = Helper.InputField("Введите новую фамилию: ");
                var photoUrl = Helper.InputField("Ссылка на новое фото: ");
                var film = Helper.InputField("Любимый фильм: ");
                var book = Helper.InputField("Любимая книга: ");

                validator.ValidateName(firstName, lastName);

                user.FirstName = firstName;
                user.LastName = lastName;
                user.Photo = photoUrl;
                user.FavouriteMovie = film;
                user.FavouriteBook = book;

                userService.Update(user);
                logger.SuccessOutput("Ваш профиль успешно обновлён!");
            }
            catch (Exception)
            {
                logger.ErrorOutput("Невозможно обновить профиль.");
            }
        }
    }
}
