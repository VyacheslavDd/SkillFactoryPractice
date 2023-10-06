using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_1_4
    {
        private static int[] GetArray()
        {
            Console.WriteLine("Введите кол-во чисел: ");
            var numbersCount = int.Parse(Console.ReadLine());
            var numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine("Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        } 

        private static bool IsArrayOrderedByAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    return false;
            }
            return true;
        }

        public static bool CheckingArrayTask()
        {
            var numbers = GetArray();
            return IsArrayOrderedByAscending(numbers);
        }
    }
}
