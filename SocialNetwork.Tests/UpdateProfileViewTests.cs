using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Tests
{
    [TestFixture, Order(3)]
    public class UpdateProfileViewTests
    {
        [Test, Order(1)]
        public void CheckUpdatingProfileIsSuccessful()
        {
            var userService = new UserService();
            var authenticationData = new UserAuthenticationData()
            {
                Email = PersonData.Email,
                Password = PersonData.Password
            };
            var user = userService.Authenticate(authenticationData);
            var previousFavouriteMovie = user.FavouriteMovie;
            user.FavouriteMovie = PersonData.FavouriteMovie;
            userService.Update(user);
            user = userService.FindByEmail(user.Email);
            Assert.AreNotEqual(previousFavouriteMovie, user.FavouriteMovie);
            Assert.AreEqual(user.FavouriteMovie, PersonData.FavouriteMovie);
        }
    }
}
