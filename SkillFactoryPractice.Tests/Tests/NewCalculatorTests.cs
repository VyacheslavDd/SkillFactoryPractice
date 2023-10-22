using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SkillFactory.Programs.Module_7;

namespace SkillFactoryPractice.Tests.Tests
{
    [TestFixture]
    internal class NewCalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new NewCalculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.AreEqual(94, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new NewCalculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.AreEqual(120, result);
        }
    }
}
