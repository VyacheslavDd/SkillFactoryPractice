using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Additional
{
    public class Logger
    {
        private static Logger logger;

        private ConsoleColor standardColor = ConsoleColor.White;

        private Logger()
        {
        }

        private void DifferentOutput(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = standardColor;
        }

        public void ErrorOutput(string message)
        {
            DifferentOutput(ConsoleColor.Red, message);
        }

        public void SuccessOutput(string message)
        {
            DifferentOutput(ConsoleColor.Green, message);
        }

        public static Logger GetLogger()
        {
            if (logger is null)
                logger = new Logger();
            return logger;
        }
    }
}
