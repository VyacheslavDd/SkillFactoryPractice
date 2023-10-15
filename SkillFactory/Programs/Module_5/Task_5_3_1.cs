using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{
    internal class Task_5_3_1
    {
        public static void AnonymousSelecting()
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
            var sortedWords = words.Select(word => new { Word = word, Length = word.Length }).OrderBy(word => word.Length);
            foreach (var word in sortedWords) Console.WriteLine(word.Word);
        }
    }
}
