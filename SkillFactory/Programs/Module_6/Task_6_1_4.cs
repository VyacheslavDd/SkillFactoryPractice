using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    internal class Task_6_1_4
    {
        public static void FindCommonLetters(string word1, string word2)
        {
            var char1 = word1.ToCharArray();
            var char2 = word2.ToCharArray();
            var commonSymbols = char1.Intersect(char2);
            foreach ( var symbol in commonSymbols)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}
