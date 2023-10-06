using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_5_4
    {
        public static void StackInput()
        {
            var words = new Stack<string>();

            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "pop")
                    words.TryPop(out var res);
                else if (input == "peek")
                {
                    var elem = "";
                    if (words.TryPeek(out elem))
                        Console.WriteLine(elem);
                }
                else
                    words.Push(input); // Изменить здесь


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}
