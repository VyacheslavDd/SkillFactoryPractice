using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_3_10
    {
        public static void CountSymbolsInSentence()
        {
            while (true)
            {
                var sentence = Console.ReadLine();

                var charSet = new HashSet<char>();
                foreach (var symbol in sentence)
                {
                    charSet.Add(symbol);
                }
                charSet.ExceptWith(new char[] { ',', '.', ' ' });
                var curCharCount = charSet.Count;
                Console.WriteLine(curCharCount);
                charSet.ExceptWith(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
                if (curCharCount > charSet.Count)
                {
                    Console.WriteLine("В предложении были цифры!");
                }
            }
        }
    }
}
