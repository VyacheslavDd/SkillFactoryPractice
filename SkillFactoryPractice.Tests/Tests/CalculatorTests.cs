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
    internal class CalculatorTests
    {
        [Test]
        public static void SubtractionShouldReturnCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(-3, calculator.Subtraction(5, 8));
        }

        [Test]
        public static void DivisionShouldReturnCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(4, calculator.Division(8, 2));
        }

        [Test]
        public static void DivisionShouldThrowDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws(typeof(DivideByZeroException), () => calculator.Division(8, 0));
        }
    }
}
