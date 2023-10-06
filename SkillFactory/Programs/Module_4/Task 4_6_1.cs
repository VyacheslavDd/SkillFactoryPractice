using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_6_1
    {
        private static LinkedList<string> CreateLinkedList(List<string> words)
        {
            var linkedWords = new LinkedList<string>();
            foreach (var word in words)
            {
                linkedWords.AddLast(word);
            }
            return linkedWords;
        }

        private static double WatchListInsert(List<string> words, int index)
        {
            var watch = new Stopwatch();
            watch.Start();
            words.Insert(index, "XDDDD");
            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }

        private static double WatchLinkedListInsert(LinkedList<string> words, string word)
        {
            var watch = new Stopwatch();
            watch.Start();
            var node = words.Find(word);
            words.AddAfter(node, "XDDDD");
            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }

        public static void CompareListInserting()
        {
            var path = "C:\\skill\\SkillFactoryPractice\\SkillFactory\\Additional files\\task416.txt";
            var text = File.ReadAllText(path);
            var wordsList = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var linkedWordsList = CreateLinkedList(wordsList);
            var medianWord = wordsList[wordsList.Count / 2];
            var listInsertTime = WatchListInsert(wordsList, wordsList.Count / 2);
            var linkedListInsertTime = WatchLinkedListInsert(linkedWordsList, medianWord);
            Console.WriteLine($"Вставка в обычный лист: {listInsertTime} мс.");
            Console.WriteLine($"Вставка в связанный лист: {linkedListInsertTime} мс.");
            Console.WriteLine($"Связанный лист быстрее обычного на {listInsertTime - linkedListInsertTime} мс.");
        }
    }
}
