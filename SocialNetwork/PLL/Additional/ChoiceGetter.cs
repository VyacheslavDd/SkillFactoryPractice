using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Additional
{
    public static class ChoiceGetter
    {
        public static int GetChoice(int from, int to, Logger logger)
        {
            while (true)
            {
                try
                {
                    var choice = int.Parse(Console.ReadLine());
                    if (choice < from || choice > to) throw new ArgumentException();
                    return choice;
                }
                catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
                {
                    logger.ErrorOutput("Попробуйте ещё раз.");
                }
            }
        }
    }
}
