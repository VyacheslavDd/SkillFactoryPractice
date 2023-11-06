using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Additional
{
    public static class Helper
    {
        public static string InputField(string phrase)
        {
            Console.Write(phrase);
            return Console.ReadLine();
        }
    }
}
