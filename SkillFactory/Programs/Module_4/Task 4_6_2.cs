using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_6_2
    {
        private static void FillWordsCount(Dictionary<string, int> dict, string[] words)
        {
            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                    dict[word] = 1;
                else
                    dict[word] += 1;
            }
        }

        private static void FillReversedDict(Dictionary<string, int> dict, SortedDictionary<int, List<string>> reversedDict)
        {
            foreach (var keyValuePair in dict)
            {
                if (!reversedDict.ContainsKey(keyValuePair.Value))
                    reversedDict[keyValuePair.Value] = new List<string>() { keyValuePair.Key };
                else
                    reversedDict[keyValuePair.Value].Add(keyValuePair.Key);
            }
        }

        private static void PrintTenMostPopularWords(SortedDictionary<int, List<string>> dict)
        {
            var wordsPrinted = 0;
            var keys = dict.Keys.ToList();
            keys.Reverse();
            foreach (var count in keys) 
            { 
                var words = dict[count];
                foreach (var word in words)
                {
                    Console.WriteLine($"Слово '{word}' встречается раз: {count}");
                    wordsPrinted += 1;
                    if (wordsPrinted >= 10) return;
                }
            }
        }

        public static void FindMostPopularTenWords()
        {
            var path = "C:\\skill\\SkillFactoryPractice\\SkillFactory\\Additional files\\task416.txt";
            var text = File.ReadAllText(path, Encoding.UTF8);
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            var words = noPunctuationText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();
            var reversedDict = new SortedDictionary<int, List<string>>();
            FillWordsCount(wordsCount, words);
            FillReversedDict(wordsCount, reversedDict);
            PrintTenMostPopularWords(reversedDict);
        }
    }
}
