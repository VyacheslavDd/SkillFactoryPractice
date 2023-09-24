using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_6_1
    {
        public class BadCodeException : Exception
        {
            public BadCodeException() : base()
            {

            }
            public BadCodeException(string? message) : base(message)
            {
            }
        }

        public static void IterateExceptions()
        {
            var exceptions = new Exception[] { new ArgumentException(), new FormatException(), new DivideByZeroException(),
            new FileNotFoundException(), new BadCodeException("You're writing terrible code!") };
            foreach (var exception in exceptions)
            {
                try 
                {
                    throw exception;
                }
                catch
                {
                    Console.WriteLine(exception.GetType().Name + ": " + exception.Message);
                }
            }
        }
    }
}
