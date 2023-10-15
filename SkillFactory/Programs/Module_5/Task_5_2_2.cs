using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{
    internal class Task_5_2_2
    {
        public static void ArrayStringTask()
        {
            string[] text = { "Раз два три",
                            "четыре пять шесть",
                            "семь восемь девять" };
            var words = from str in text from word in str.Split() select word;
            foreach (var word in words) Console.Write(word + " ");
            Console.WriteLine();
            words = text.SelectMany(str => str.Split());
            foreach (var word in words) Console.Write(word + " ");
        }
    }
}
