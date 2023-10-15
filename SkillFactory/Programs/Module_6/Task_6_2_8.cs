using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    internal class Task_6_2_8
    {
        private static void ShowInfo(List<int> numbers)
        {
            Console.WriteLine($"Кол-во элементов: {numbers.Count}");
            Console.WriteLine($"Сумма элементов: {numbers.Sum()}");
            Console.WriteLine($"Наибольшее число: {numbers.Max()}");
            Console.WriteLine($"Наименьшее число: {numbers.Min()}");
            Console.WriteLine($"Среднее значение: {numbers.Average()}");
        }
    
        public static void ArithmeticLINQPractice()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Введите число: ");
                var isParsed = int.TryParse(Console.ReadLine(), out int number);
                if (isParsed)
                {
                    numbers.Add(number);
                    ShowInfo(numbers);
                }
                else
                    Console.WriteLine("Некорректный ввод. Повторите попытку");
            }
        }
    }
}
