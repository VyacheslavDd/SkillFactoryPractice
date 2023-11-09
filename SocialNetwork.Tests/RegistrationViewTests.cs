using NUnit;
using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.Tests.Data;

namespace SocialNetwork.Tests
{
    [TestFixture, Order(1)]
    public class RegistrationViewTests
    {
        [Test, Order(1)]
        public void UserRegistrationCheck()
        {
            var userService = new UserService();
            userService.DeleteUsers();
            var person = new UserRegistrationData()
            {
                FirstName = PersonData.FirstName,
                LastName = PersonData.LastName,
                Email = PersonData.Email,
                Password = PersonData.Password
            };
            userService.Register(person);
            var result = userService.FindByEmail(person.Email);
            Assert.IsNotNull(result);
            Assert.AreEqual(person.Email, result.Email);
        }

        [Test, Order(2)]
        public void CheckUserServiceThrowsErrorWhenRegisteringPersonWithSameEmail()
        {
            var userService = new UserService();
            var person = new UserRegistrationData()
            {
                FirstName = "Me",
                LastName = "Me",
                Email = PersonData.Email,
                Password = "memememememe"
            };
            Assert.Throws<ArgumentNullException>(() => { userService.Register(person); });
        }
    }
}