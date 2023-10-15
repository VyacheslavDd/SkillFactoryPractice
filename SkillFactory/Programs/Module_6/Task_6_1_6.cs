using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    internal class Task_6_1_6
    {
        public static void FindUniqueSymbols(string input)
        {
            var uniqueSymbols = input.Where(symbol => char.IsLetter(symbol)).Distinct();
            foreach (var symbol in uniqueSymbols)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}
