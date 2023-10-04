using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_3
{
    internal class Task_3_5_1
    {
        private interface ICalculator
        {
            public double Sum(double a, double b);
        }

        private interface ILogger
        {
            public void Success(string message);
            public void Error(string message);
        }

        private class Logger : ILogger
        {
            public void Error(string message)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.BackgroundColor = ConsoleColor.Black;
            }

            public void Success(string message)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        private class Calculator : ICalculator
        {
            public ILogger Logger { get; }
            public Calculator(ILogger logger)
            {
                Logger = logger;
            }

            public double Sum(double a, double b)
            {
                return a + b;
            }
        }

        public static void InterfaceCalculatorShowCase()
        {
            var calculator = new Calculator(new Logger());
            try
            {
                var firstNumber = double.Parse(Console.ReadLine());
                var secondNumber = double.Parse(Console.ReadLine());
                calculator.Logger.Success(calculator.Sum(firstNumber, secondNumber).ToString());
            }
            catch (FormatException ex)
            {
                calculator.Logger.Error(ex.Message);
            }
            finally
            {
                Console.WriteLine("Программа завершена!");
            }
        }
    }
}
