using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Validators;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.BLL.Services
{
    public class UserService
    {
        private IUserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        private User CreateUser(UserRegistrationData data)
        {
            return new User()
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                Password = data.Password
            };
        }

        public User FindByEmail(string email)
        {
            return userRepository.FindByEmail(email);
        }

        public User FindById(int id)
        {
            return userRepository.FindById(id);
        }

        public User Authenticate(UserAuthenticationData userAuthenticationData)
        {
            var user = userRepository.FindByEmail(userAuthenticationData.Email);
            if (user is null) throw new UserNotFoundException("Такого пользователя не существует!");

            if (user.Password != userAuthenticationData.Password) throw new WrongPasswordException("Некорректный пароль! Попробуйте ещё раз.");
            return user;
        }

        public void Register(UserRegistrationData userRegistrationData)
        {
            var userDataValidator = UserDataValidator.GetValidator();
            userDataValidator.ValidateData(userRegistrationData);

            if (userRepository.FindByEmail(userRegistrationData.Email) != null)
                throw new ArgumentNullException("Человек с таким E-mail адресом уже существует!");

            var newPerson = CreateUser(userRegistrationData);
            if (userRepository.Create(newPerson) == 0)
                throw new ArgumentNullException("Произошла непредвиденная ошибка! Попробуйте ещё раз.");
        }

        public void Update(User user)
        {
            if (userRepository.Update(user) == 0) throw new Exception("Непредвиденная ошибка при обновлении данных. Попробуйте ещё раз!");
        }

        public void DeleteUsers()
        {
            userRepository.DeleteAll();
        }
    }
}
