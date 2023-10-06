using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_1_6
    {
        public static void CountWordsInBook()
        {
            string bookPath = "C:\\skill\\SkillFactoryPractice\\SkillFactory\\Additional files\\task416.txt";
            var text = File.ReadAllText(bookPath);
            var words = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
    }
}
