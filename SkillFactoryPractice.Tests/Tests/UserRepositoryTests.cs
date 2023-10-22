using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using SkillFactory.Programs.Module_7;

namespace SkillFactoryPractice.Tests.Tests
{
    [TestFixture]
    internal class UserRepositoryTests
    {
        [Test]
        public static void UserRepositoryShouldReturnFoundPeople()
        {
            var mock = new Mock<Task_7_3_1.IUserRepository>();
            mock.Setup(s => s.FindAll()).Returns(new List<Task_7_3_1.User>()
            {
                new Task_7_3_1.User { Name = "Антон" },
                new Task_7_3_1.User { Name = "Иван" },
                new Task_7_3_1.User { Name = "Алексей" }
            });
            var userRepositoryTest = mock.Object;
            Assert.That(userRepositoryTest.FindAll().Any(x => x.Name == "Антон"));
        }
    }
}
