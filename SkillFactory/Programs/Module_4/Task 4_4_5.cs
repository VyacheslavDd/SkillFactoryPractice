using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_4_5
    {
        private static long MeasureDictionaryInserting(IDictionary<string, string> dict, string name, string value)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            dict.Add("Oleg", "Chill");
            stopWatch.Stop();
            return stopWatch.ElapsedTicks;
        }

        public static void CompareDictionariesAdding()
        {
            var standardDictionary = new Dictionary<string, string>()
            {
                ["Dima"] = "Chill",
                ["Anton"] = "Not chill"
            };
            var sortedDictionary = new SortedDictionary<string, string>()
            {
                ["Dima"] = "Chill",
                ["Anton"] = "Not chill"
            };

            Console.WriteLine($"Вставка для обычного словаря заняла: {MeasureDictionaryInserting(standardDictionary, "Oleg", "Chill")} таймер-тиков");
            Console.WriteLine($"Вставка для сортированного словаря заняла: {MeasureDictionaryInserting(sortedDictionary, "Oleg", "Chill")} таймер-тиков");
        }
    }
}
