using NUnit.Framework;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Tests
{
    [TestFixture, Order(2)]
    public class AuthenticationViewTests
    {
        [Test, Order(1)]
        public void CheckAuthenticationGoSuccessful()
        {
            var userService = new UserService();
            var authenticationData = new UserAuthenticationData()
            {
                Email = PersonData.Email,
                Password = PersonData.Password
            };
            var user = userService.Authenticate(authenticationData);
            Assert.IsNotNull(user);
            Assert.AreEqual(PersonData.Email, user.Email);
        }

        [Test, Order(2)]
        public void CheckServiceThrowsExceptionOnWrongEmailInput()
        {
            var userService = new UserService();
            var authenticationData = new UserAuthenticationData()
            {
                Email = "IDK@whattosay.ru",
                Password = "doesntmatter"
            };
            Assert.Throws<UserNotFoundException>(() => userService.Authenticate(authenticationData));
        }

        [Test, Order(3)]
        public void CheckServiceThrowsExceptionOnWrongPassword()
        {
            var userService = new UserService();
            var authenticationData = new UserAuthenticationData()
            {
                Email = PersonData.Email,
                Password = "doesmatter"
            };
            Assert.Throws<WrongPasswordException>(() => userService.Authenticate(authenticationData));
        }
    }
}
